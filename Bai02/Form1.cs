using Microsoft.VisualBasic;
using System;
using System.Net.Quic;
using System.Windows.Forms;

namespace ITSupportTicket
{
    public partial class Form1 : Form
    {
        string imagePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter =
                "Image Files|*.jpg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                picError.ImageLocation = imagePath;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTicketId.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu!");
                txtTicketId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRequester.Text))
            {
                MessageBox.Show("Vui lòng nhập người yêu cầu!");
                txtRequester.Focus();
                return;
            }

            string priority = "";

            if (rdoLow.Checked)
                priority = "Thấp";
            else if (rdoMedium.Checked)
                priority = "Trung bình";
            else if (rdoUrgent.Checked)
                priority = "Khẩn cấp";

            string devices = "";

            if (chkDesktop.Checked)
                devices += "Máy tính bàn, ";

            if (chkLaptop.Checked)
                devices += "Laptop, ";

            if (chkPrinter.Checked)
                devices += "Máy in, ";

            if (chkPhone.Checked)
                devices += "Điện thoại, ";

            if (devices == "")
                devices = "Không chọn";

            else
                devices = devices.TrimEnd(' ', ',');

            string image = "";

            if (imagePath == "")
                image = "Không có";
            else
                image = imagePath;

            string message =
                "THÔNG TIN PHIẾU SỰ CỐ IT\n\n" +
                "Mã phiếu: " + txtTicketId.Text + "\n" +
                "Người yêu cầu: " + txtRequester.Text + "\n" +
                "Ngày ghi nhận: " +
                dtpDate.Value.ToString("dd/MM/yyyy") + "\n" +
                "Mức độ ưu tiên: " + priority + "\n" +
                "Loại sự cố: " + cboProblemType.Text + "\n" +
                "Thiết bị ảnh hưởng: " + devices + "\n" +
                "Ảnh lỗi: " + image;

            MessageBox.Show(
                message,
                "Tóm tắt phiếu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTicketId.Clear();
            txtRequester.Clear();

            dtpDate.Value = DateTime.Now;

            rdoLow.Checked = false;
            rdoMedium.Checked = true;
            rdoUrgent.Checked = false;

            cboProblemType.SelectedIndex = 0;

            chkDesktop.Checked = false;
            chkLaptop.Checked = false;
            chkPrinter.Checked = false;
            chkPhone.Checked = false;

            picError.Image = null;
            imagePath = "";

            txtTicketId.Focus();
        }
    }
}