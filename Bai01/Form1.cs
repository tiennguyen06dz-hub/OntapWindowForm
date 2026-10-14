using System;
using System.Windows.Forms;

namespace ServiceChargeCalculator
{
    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(
            object sender,
            EventArgs e)
        {
            decimal unitPrice;
            int quantity;
            decimal discount;

            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đơn giá dịch vụ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUnitPrice.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập số lượng khách!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtQuantity.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã giảm giá (%)!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDiscount.Focus();
                return;
            }

            if (!decimal.TryParse(
                txtUnitPrice.Text,
                out unitPrice))
            {
                MessageBox.Show(
                    "Đơn giá phải là số!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUnitPrice.Focus();
                return;
            }

            if (!int.TryParse(
                txtQuantity.Text,
                out quantity))
            {
                MessageBox.Show(
                    "Số lượng khách phải là số nguyên!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtQuantity.Focus();
                return;
            }

            if (!decimal.TryParse(
                txtDiscount.Text,
                out discount))
            {
                MessageBox.Show(
                    "Giảm giá phải là số!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDiscount.Focus();
                return;
            }

            if (unitPrice < 0)
            {
                MessageBox.Show(
                    "Đơn giá không được nhỏ hơn 0!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUnitPrice.Focus();
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show(
                    "Số lượng khách phải lớn hơn 0!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtQuantity.Focus();
                return;
            }

            if (discount < 0 || discount > 100)
            {
                MessageBox.Show(
                    "Giảm giá phải từ 0 đến 100%!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDiscount.Focus();
                return;
            }

            decimal total =
                calculator.Calculate(
                    unitPrice,
                    quantity,
                    discount);

            lblTotal.Text =
                "Tổng tiền: " +
                total.ToString("N0") +
                " VNĐ";
        }

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtDiscount.Clear();

            lblTotal.Text =
                "Tổng tiền: 0 VNĐ";

            txtUnitPrice.Focus();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}