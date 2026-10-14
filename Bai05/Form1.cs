using System;
using System.Windows.Forms;

namespace DeliveryOrderDashboard
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer =
            new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            dgvItems.EditingControlShowing +=
                dgvItems_EditingControlShowing;

            dgvItems.CellValueChanged +=
                dgvItems_CellValueChanged;

            dgvItems.RowsRemoved +=
                dgvItems_RowsRemoved;

            dgvItems.KeyDown +=
                dgvItems_KeyDown;
        }

        private void Form1_Load(
            object? sender,
            EventArgs e)
        {
            UpdateStatus();
        }

        private void Timer_Tick(
            object? sender,
            EventArgs e)
        {
            lblTime.Text =
                "Thời gian: " +
                DateTime.Now.ToString(
                    "dd/MM/yyyy HH:mm:ss");
        }

        private void dgvItems_EditingControlShowing(
            object? sender,
            DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= Cell_KeyPress;
            e.Control.KeyPress += Cell_KeyPress;
        }

        private void Cell_KeyPress(
            object? sender,
            KeyPressEventArgs e)
        {
            TextBox? textBox = sender as TextBox;

            if (textBox == null)
                return;

            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dgvItems_CellValueChanged(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 1 ||
                e.ColumnIndex == 2 ||
                e.ColumnIndex == 3)
            {
                CalculateRow(e.RowIndex);
            }

            UpdateStatus();
        }

        private void CalculateRow(int rowIndex)
        {
            if (rowIndex < 0 ||
                rowIndex >= dgvItems.Rows.Count - 1)
                return;

            DataGridViewRow row =
                dgvItems.Rows[rowIndex];

            int soLuong = 0;
            decimal trongLuong = 0;
            decimal donGia = 0;

            int.TryParse(
                Convert.ToString(row.Cells[1].Value),
                out soLuong);

            decimal.TryParse(
                Convert.ToString(row.Cells[2].Value),
                out trongLuong);

            decimal.TryParse(
                Convert.ToString(row.Cells[3].Value),
                out donGia);

            row.Cells[4].Value =
                soLuong * donGia;

            ValidateRow(rowIndex);
        }

        private void ValidateRow(int rowIndex)
        {
            if (rowIndex < 0 ||
                rowIndex >= dgvItems.Rows.Count - 1)
                return;

            DataGridViewRow row =
                dgvItems.Rows[rowIndex];

            int soLuong = 0;
            decimal trongLuong = 0;

            int.TryParse(
                Convert.ToString(row.Cells[1].Value),
                out soLuong);

            decimal.TryParse(
                Convert.ToString(row.Cells[2].Value),
                out trongLuong);

            if (soLuong <= 0)
            {
                errorProvider.SetError(
                    dgvItems,
                    "Số lượng phải lớn hơn 0!");
            }
            else if (trongLuong <= 0)
            {
                errorProvider.SetError(
                    dgvItems,
                    "Trọng lượng phải lớn hơn 0!");
            }
            else
            {
                errorProvider.SetError(
                    dgvItems,
                    "");
            }
        }

        private void UpdateStatus()
        {
            int totalQuantity = 0;
            decimal totalWeight = 0;
            decimal totalMoney = 0;

            foreach (DataGridViewRow row
                in dgvItems.Rows)
            {
                if (row.IsNewRow)
                    continue;

                int quantity = 0;
                decimal weight = 0;
                decimal money = 0;

                int.TryParse(
                    Convert.ToString(row.Cells[1].Value),
                    out quantity);

                decimal.TryParse(
                    Convert.ToString(row.Cells[2].Value),
                    out weight);

                decimal.TryParse(
                    Convert.ToString(row.Cells[4].Value),
                    out money);

                totalQuantity += quantity;
                totalWeight += weight;
                totalMoney += money;
            }

            lblQuantity.Text =
                "Tổng số lượng: " +
                totalQuantity;

            lblWeight.Text =
                "Tổng trọng lượng: " +
                totalWeight.ToString("N2") +
                " kg";

            lblMoney.Text =
                "Tổng tiền: " +
                totalMoney.ToString("N0") +
                " đ";
        }

        private void dgvItems_RowsRemoved(
            object? sender,
            DataGridViewRowsRemovedEventArgs e)
        {
            UpdateStatus();
        }

        private void dgvItems_KeyDown(
            object? sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                dgvItems.Rows.Add();

                int rowIndex =
                    dgvItems.Rows.Count - 2;

                dgvItems.CurrentCell =
                    dgvItems.Rows[rowIndex].Cells[0];

                dgvItems.BeginEdit(true);

                e.Handled = true;
            }

            if (e.KeyCode == Keys.Delete)
            {
                if (dgvItems.CurrentRow != null &&
                    !dgvItems.CurrentRow.IsNewRow)
                {
                    dgvItems.Rows.Remove(
                        dgvItems.CurrentRow);

                    UpdateStatus();
                }

                e.Handled = true;
            }
        }
    }
}