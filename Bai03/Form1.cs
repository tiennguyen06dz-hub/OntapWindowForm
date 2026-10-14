using System;
using System.Windows.Forms;

namespace ItemListManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            foreach (ListViewItem item in lvItems.Items)
            {
                if (item.SubItems[0].Text.Equals(
                    txtMaVT.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Mã vật tư đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtMaVT.Focus();
                    return;
                }
            }

            ListViewItem newItem =
                new ListViewItem(txtMaVT.Text.Trim());

            newItem.SubItems.Add(txtTenVT.Text.Trim());
            newItem.SubItems.Add(cboDonViTinh.Text);
            newItem.SubItems.Add(
                decimal.Parse(txtDonGia.Text).ToString("N0"));

            lvItems.Items.Add(newItem);

            ClearInput();
        }

        private void lvItems_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
                return;

            ListViewItem item =
                lvItems.SelectedItems[0];

            txtMaVT.Text =
                item.SubItems[0].Text;

            txtTenVT.Text =
                item.SubItems[1].Text;

            cboDonViTinh.Text =
                item.SubItems[2].Text;

            txtDonGia.Text =
                item.SubItems[3].Text.Replace(",", "");
        }

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn dòng cần cập nhật!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidateInput())
                return;

            ListViewItem item =
                lvItems.SelectedItems[0];

            string oldMa =
                item.SubItems[0].Text;

            foreach (ListViewItem x in lvItems.Items)
            {
                if (x != item &&
                    x.SubItems[0].Text.Equals(
                        txtMaVT.Text.Trim(),
                        StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Mã vật tư đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtMaVT.Focus();
                    return;
                }
            }

            item.SubItems[0].Text =
                txtMaVT.Text.Trim();

            item.SubItems[1].Text =
                txtTenVT.Text.Trim();

            item.SubItems[2].Text =
                cboDonViTinh.Text;

            item.SubItems[3].Text =
                decimal.Parse(txtDonGia.Text).ToString("N0");

            ClearInput();
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn dòng cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa dòng này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lvItems.Items.Remove(
                    lvItems.SelectedItems[0]);

                ClearInput();
            }
        }

        private void btnDeleteAll_Click(
            object sender,
            EventArgs e)
        {
            if (lvItems.Items.Count == 0)
                return;

            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa toàn bộ?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lvItems.Items.Clear();
                ClearInput();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaVT.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã vật tư!");

                txtMaVT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenVT.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên vật tư!");

                txtTenVT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboDonViTinh.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn đơn vị tính!");

                cboDonViTinh.Focus();
                return false;
            }

            decimal donGia;

            if (!decimal.TryParse(
                txtDonGia.Text.Replace(",", ""),
                out donGia))
            {
                MessageBox.Show(
                    "Đơn giá phải là số!");

                txtDonGia.Focus();
                return false;
            }

            if (donGia < 0)
            {
                MessageBox.Show(
                    "Đơn giá không được nhỏ hơn 0!");

                txtDonGia.Focus();
                return false;
            }

            return true;
        }

        private void ClearInput()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            cboDonViTinh.SelectedIndex = 0;
            txtDonGia.Clear();

            lvItems.SelectedItems.Clear();

            txtMaVT.Focus();
        }
    }
}