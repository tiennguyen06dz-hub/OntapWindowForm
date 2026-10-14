using System.Drawing;
using System.Windows.Forms;

namespace ServiceChargeCalculator
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblDiscount;
        private Label lblTotal;

        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtDiscount;

        private Button btnCalculate;
        private Button btnClear;

        private TableLayoutPanel tableLayoutPanel1;

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
            lblTitle = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            lblDiscount = new Label();
            lblTotal = new Label();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            txtDiscount = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            tableLayoutPanel1.SetColumnSpan(lblTitle, 2);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(62, 64);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(990, 128);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MÁY TÍNH TÍNH CƯỚC DỊCH VỤ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.Dock = DockStyle.Fill;
            lblUnitPrice.Location = new Point(62, 192);
            lblUnitPrice.Margin = new Padding(6, 0, 6, 0);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(388, 107);
            lblUnitPrice.TabIndex = 1;
            lblUnitPrice.Text = "Đơn giá dịch vụ";
            lblUnitPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            lblQuantity.Dock = DockStyle.Fill;
            lblQuantity.Location = new Point(62, 299);
            lblQuantity.Margin = new Padding(6, 0, 6, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(388, 107);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Số lượng khách";
            lblQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDiscount
            // 
            lblDiscount.Dock = DockStyle.Fill;
            lblDiscount.Location = new Point(62, 406);
            lblDiscount.Margin = new Padding(6, 0, 6, 0);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(388, 107);
            lblDiscount.TabIndex = 3;
            lblDiscount.Text = "Giảm giá (%)";
            lblDiscount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            tableLayoutPanel1.SetColumnSpan(lblTotal, 2);
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(62, 513);
            lblTotal.Margin = new Padding(6, 0, 6, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(990, 128);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Tổng tiền: 0 VNĐ";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Dock = DockStyle.Fill;
            txtUnitPrice.Location = new Point(462, 198);
            txtUnitPrice.Margin = new Padding(6);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(590, 39);
            txtUnitPrice.TabIndex = 0;
            txtUnitPrice.Text = "a";
            txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Dock = DockStyle.Fill;
            txtQuantity.Location = new Point(462, 305);
            txtQuantity.Margin = new Padding(6);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(590, 39);
            txtQuantity.TabIndex = 1;
            // 
            // txtDiscount
            // 
            txtDiscount.Dock = DockStyle.Fill;
            txtDiscount.Location = new Point(462, 412);
            txtDiscount.Margin = new Padding(6);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(590, 39);
            txtDiscount.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Dock = DockStyle.Fill;
            btnCalculate.Location = new Point(62, 647);
            btnCalculate.Margin = new Padding(6);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(388, 95);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Tính tiền";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(462, 647);
            btnClear.Margin = new Padding(6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(590, 95);
            btnClear.TabIndex = 4;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(lblUnitPrice, 0, 1);
            tableLayoutPanel1.Controls.Add(txtUnitPrice, 1, 1);
            tableLayoutPanel1.Controls.Add(lblQuantity, 0, 2);
            tableLayoutPanel1.Controls.Add(txtQuantity, 1, 2);
            tableLayoutPanel1.Controls.Add(lblDiscount, 0, 3);
            tableLayoutPanel1.Controls.Add(txtDiscount, 1, 3);
            tableLayoutPanel1.Controls.Add(lblTotal, 0, 4);
            tableLayoutPanel1.Controls.Add(btnCalculate, 0, 5);
            tableLayoutPanel1.Controls.Add(btnClear, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(56, 64, 56, 64);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1114, 960);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 960);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(6);
            MinimumSize = new Size(906, 773);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service Charge Calculator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }
    }
}