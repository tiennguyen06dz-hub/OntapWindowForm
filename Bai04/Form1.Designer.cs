using System.Drawing;
using System.Windows.Forms;

namespace SlotBooking
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblSelected;
        private Label lblTotal;

        private ComboBox cboTime;

        private Button btnConfirm;
        private Button btnClear;

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel tableSlots;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components =
                new System.ComponentModel.Container();

            this.lblTitle = new Label();
            this.lblSelected = new Label();
            this.lblTotal = new Label();

            this.cboTime = new ComboBox();

            this.btnConfirm = new Button();
            this.btnClear = new Button();

            this.mainLayout = new TableLayoutPanel();
            this.tableSlots = new TableLayoutPanel();

            this.mainLayout.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions =
                new SizeF(7F, 15F);

            this.AutoScaleMode =
                AutoScaleMode.Font;

            this.ClientSize =
                new Size(800, 600);

            this.MinimumSize =
                new Size(700, 500);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Text =
                "Interactive Slot Booking";

            // Main Layout
            this.mainLayout.Dock =
                DockStyle.Fill;

            this.mainLayout.Padding =
                new Padding(20);

            this.mainLayout.ColumnCount = 2;
            this.mainLayout.RowCount = 5;

            this.mainLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));

            this.mainLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));

            this.mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    60F));

            this.mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F));

            this.mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    45F));

            this.mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    45F));

            this.mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    50F));

            // Title
            this.lblTitle.Text =
                "SƠ ĐỒ CHỌN VỊ TRÍ / ĐẶT BÀN";

            this.lblTitle.Dock =
                DockStyle.Fill;

            this.lblTitle.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblTitle.Font =
                new Font(
                    "Segoe UI",
                    15F,
                    FontStyle.Bold);

            this.mainLayout.Controls.Add(
                this.lblTitle,
                0,
                0);

            this.mainLayout.SetColumnSpan(
                this.lblTitle,
                2);

            // Table Slots
            this.tableSlots.Dock =
                DockStyle.Fill;

            this.tableSlots.ColumnCount = 5;
            this.tableSlots.RowCount = 4;

            for (int i = 0; i < 5; i++)
            {
                this.tableSlots.ColumnStyles.Add(
                    new ColumnStyle(
                        SizeType.Percent,
                        20F));
            }

            for (int i = 0; i < 4; i++)
            {
                this.tableSlots.RowStyles.Add(
                    new RowStyle(
                        SizeType.Percent,
                        25F));
            }

            this.mainLayout.Controls.Add(
                this.tableSlots,
                0,
                1);

            this.mainLayout.SetColumnSpan(
                this.tableSlots,
                2);

            // ComboBox
            this.cboTime.Dock =
                DockStyle.Fill;

            this.cboTime.DropDownStyle =
                ComboBoxStyle.DropDownList;

            this.cboTime.TabIndex = 0;

            this.cboTime.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cboTime_SelectedIndexChanged);

            this.mainLayout.Controls.Add(
                this.cboTime,
                0,
                2);

            // Selected
            this.lblSelected.Text =
                "Số vị trí đang chọn: 0";

            this.lblSelected.Dock =
                DockStyle.Fill;

            this.lblSelected.TextAlign =
                ContentAlignment.MiddleCenter;

            this.mainLayout.Controls.Add(
                this.lblSelected,
                1,
                2);

            // Total
            this.lblTotal.Text =
                "Tạm tính tiền: 0đ";

            this.lblTotal.Dock =
                DockStyle.Fill;

            this.lblTotal.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblTotal.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            this.mainLayout.Controls.Add(
                this.lblTotal,
                0,
                3);

            this.mainLayout.SetColumnSpan(
                this.lblTotal,
                2);

            // Confirm
            this.btnConfirm.Text =
                "Xác nhận đặt";

            this.btnConfirm.Dock =
                DockStyle.Fill;

            this.btnConfirm.TabIndex = 1;

            this.btnConfirm.Click +=
                new System.EventHandler(
                    this.btnConfirm_Click);

            this.mainLayout.Controls.Add(
                this.btnConfirm,
                0,
                4);

            // Clear
            this.btnClear.Text =
                "Hủy chọn tất cả";

            this.btnClear.Dock =
                DockStyle.Fill;

            this.btnClear.TabIndex = 2;

            this.btnClear.Click +=
                new System.EventHandler(
                    this.btnClear_Click);

            this.mainLayout.Controls.Add(
                this.btnClear,
                1,
                4);

            // Form
            this.Controls.Add(
                this.mainLayout);

            this.Load +=
                new System.EventHandler(
                    this.Form1_Load);

            this.mainLayout.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}