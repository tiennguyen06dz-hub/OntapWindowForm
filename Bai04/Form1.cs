using System;
using System.Drawing;
using System.Windows.Forms;

namespace SlotBooking
{
    public partial class Form1 : Form
    {
        Button[] buttons = new Button[20];

        int soViTriChon = 0;

        decimal giaSang = 100000;
        decimal giaToi = 150000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTime.Items.Add("Sáng - 100.000đ");
            cboTime.Items.Add("Tối - 150.000đ");

            cboTime.SelectedIndex = 0;

            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();

                btn.Text = "Vị trí " + (i + 1);
                btn.Dock = DockStyle.Fill;
                btn.Margin = new Padding(5);
                btn.Font = new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

                btn.BackColor = Color.White;
                btn.Tag = i;

                btn.Click += SlotButton_Click;

                buttons[i] = btn;

                tableSlots.Controls.Add(
                    btn,
                    i % 5,
                    i / 5);
            }

            buttons[4].BackColor = Color.Red;
            buttons[4].ForeColor = Color.White;

            buttons[9].BackColor = Color.Red;
            buttons[9].ForeColor = Color.White;

            buttons[14].BackColor = Color.Red;
            buttons[14].ForeColor = Color.White;

            buttons[19].BackColor = Color.Red;
            buttons[19].ForeColor = Color.White;
        }

        private void SlotButton_Click(
            object sender,
            EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == Color.Red)
            {
                MessageBox.Show(
                    "Vị trí này đã được đặt!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (btn.BackColor == Color.LimeGreen)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;

                soViTriChon--;
            }
            else
            {
                btn.BackColor = Color.LimeGreen;
                btn.ForeColor = Color.White;

                soViTriChon++;
            }

            UpdateTotal();
        }

        private void cboTime_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal gia;

            if (cboTime.SelectedIndex == 0)
                gia = giaSang;
            else
                gia = giaToi;

            decimal total =
                soViTriChon * gia;

            lblSelected.Text =
                "Số vị trí đang chọn: " +
                soViTriChon;

            lblTotal.Text =
                "Tạm tính tiền: " +
                total.ToString("N0") +
                "đ";
        }

        private void btnConfirm_Click(
            object sender,
            EventArgs e)
        {
            if (soViTriChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn ít nhất một vị trí!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            foreach (Button btn in buttons)
            {
                if (btn.BackColor == Color.LimeGreen)
                {
                    btn.BackColor = Color.Red;
                    btn.ForeColor = Color.White;
                }
            }

            MessageBox.Show(
                "Đặt vị trí thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            soViTriChon = 0;

            UpdateTotal();
        }

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            foreach (Button btn in buttons)
            {
                if (btn.BackColor == Color.LimeGreen)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }

            soViTriChon = 0;

            UpdateTotal();
        }
    }
}