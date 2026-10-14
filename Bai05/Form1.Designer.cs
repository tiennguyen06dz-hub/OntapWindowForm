namespace DeliveryOrderDashboard
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private SplitContainer splitContainer;

        private Label lblCustomerTitle;
        private Label lblOrderTitle;

        private TabControl tabControl;
        private TabPage tabCustomer;
        private TabPage tabTransport;

        private Label lblName;
        private Label lblPhone;
        private Label lblAddress;

        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtAddress;

        private RadioButton rdoNormal;
        private RadioButton rdoFast;
        private RadioButton rdoUrgent;

        private DataGridView dgvItems;

        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colWeight;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colTotal;

        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblTime;
        private ToolStripStatusLabel lblQuantity;
        private ToolStripStatusLabel lblWeight;
        private ToolStripStatusLabel lblMoney;

        private ErrorProvider errorProvider;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            splitContainer =
                new SplitContainer();

            lblCustomerTitle =
                new Label();

            lblOrderTitle =
                new Label();

            tabControl =
                new TabControl();

            tabCustomer =
                new TabPage();

            tabTransport =
                new TabPage();

            lblName =
                new Label();

            lblPhone =
                new Label();

            lblAddress =
                new Label();

            txtName =
                new TextBox();

            txtPhone =
                new TextBox();

            txtAddress =
                new TextBox();

            rdoNormal =
                new RadioButton();

            rdoFast =
                new RadioButton();

            rdoUrgent =
                new RadioButton();

            dgvItems =
                new DataGridView();

            colName =
                new DataGridViewTextBoxColumn();

            colQuantity =
                new DataGridViewTextBoxColumn();

            colWeight =
                new DataGridViewTextBoxColumn();

            colPrice =
                new DataGridViewTextBoxColumn();

            colTotal =
                new DataGridViewTextBoxColumn();

            statusStrip =
                new StatusStrip();

            lblTime =
                new ToolStripStatusLabel();

            lblQuantity =
                new ToolStripStatusLabel();

            lblWeight =
                new ToolStripStatusLabel();

            lblMoney =
                new ToolStripStatusLabel();

            errorProvider =
                new ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)
                splitContainer).BeginInit();

            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();

            tabControl.SuspendLayout();
            tabCustomer.SuspendLayout();
            tabTransport.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                dgvItems).BeginInit();

            statusStrip.SuspendLayout();

            SuspendLayout();

            // =========================================
            // SPLIT CONTAINER
            // =========================================

            splitContainer.Dock =
                DockStyle.Fill;

            splitContainer.Orientation =
                Orientation.Vertical;

            splitContainer.Name =
                "splitContainer";

            splitContainer.TabIndex =
                0;

            // Không đặt SplitterDistance ở đây
            // Không đặt Panel1MinSize
            // Không đặt Panel2MinSize

            // =========================================
            // PANEL 1
            // =========================================

            splitContainer.Panel1.BackColor =
                System.Drawing.Color.FromArgb(
                    245,
                    247,
                    250);

            splitContainer.Panel1.Padding =
                new Padding(12);

            splitContainer.Panel1.Controls.Add(
                tabControl);

            splitContainer.Panel1.Controls.Add(
                lblCustomerTitle);

            // =========================================
            // TIÊU ĐỀ KHÁCH HÀNG
            // =========================================

            lblCustomerTitle.AutoSize =
                true;

            lblCustomerTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Bold);

            lblCustomerTitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    40,
                    60,
                    80);

            lblCustomerTitle.Location =
                new System.Drawing.Point(
                    12,
                    12);

            lblCustomerTitle.Name =
                "lblCustomerTitle";

            lblCustomerTitle.Text =
                "THÔNG TIN KHÁCH HÀNG";

            // =========================================
            // TAB CONTROL
            // =========================================

            tabControl.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            tabControl.Location =
                new System.Drawing.Point(
                    12,
                    45);

            tabControl.Name =
                "tabControl";

            tabControl.Size =
                new System.Drawing.Size(
                    290,
                    520);

            tabControl.TabIndex =
                0;

            tabControl.Controls.Add(
                tabCustomer);

            tabControl.Controls.Add(
                tabTransport);

            // =========================================
            // TAB KHÁCH HÀNG
            // =========================================

            tabCustomer.BackColor =
                System.Drawing.Color.White;

            tabCustomer.Controls.Add(
                txtAddress);

            tabCustomer.Controls.Add(
                lblAddress);

            tabCustomer.Controls.Add(
                txtPhone);

            tabCustomer.Controls.Add(
                lblPhone);

            tabCustomer.Controls.Add(
                txtName);

            tabCustomer.Controls.Add(
                lblName);

            tabCustomer.Location =
                new System.Drawing.Point(
                    4,
                    24);

            tabCustomer.Name =
                "tabCustomer";

            tabCustomer.Padding =
                new Padding(12);

            tabCustomer.Size =
                new System.Drawing.Size(
                    282,
                    492);

            tabCustomer.TabIndex =
                0;

            tabCustomer.Text =
                "Khách hàng";

            // =========================================
            // LABEL TÊN
            // =========================================

            lblName.AutoSize =
                true;

            lblName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            lblName.Location =
                new System.Drawing.Point(
                    12,
                    20);

            lblName.Name =
                "lblName";

            lblName.Text =
                "Tên khách hàng";

            // =========================================
            // TEXTBOX TÊN
            // =========================================

            txtName.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            txtName.Location =
                new System.Drawing.Point(
                    12,
                    45);

            txtName.Name =
                "txtName";

            txtName.Size =
                new System.Drawing.Size(
                    250,
                    27);

            txtName.TabIndex =
                0;

            // =========================================
            // LABEL PHONE
            // =========================================

            lblPhone.AutoSize =
                true;

            lblPhone.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            lblPhone.Location =
                new System.Drawing.Point(
                    12,
                    85);

            lblPhone.Name =
                "lblPhone";

            lblPhone.Text =
                "Số điện thoại";

            // =========================================
            // TEXTBOX PHONE
            // =========================================

            txtPhone.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            txtPhone.Location =
                new System.Drawing.Point(
                    12,
                    110);

            txtPhone.Name =
                "txtPhone";

            txtPhone.Size =
                new System.Drawing.Size(
                    250,
                    27);

            txtPhone.TabIndex =
                1;

            // =========================================
            // LABEL ADDRESS
            // =========================================

            lblAddress.AutoSize =
                true;

            lblAddress.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            lblAddress.Location =
                new System.Drawing.Point(
                    12,
                    150);

            lblAddress.Name =
                "lblAddress";

            lblAddress.Text =
                "Địa chỉ giao hàng";

            // =========================================
            // TEXTBOX ADDRESS
            // =========================================

            txtAddress.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            txtAddress.Location =
                new System.Drawing.Point(
                    12,
                    175);

            txtAddress.Multiline =
                true;

            txtAddress.Name =
                "txtAddress";

            txtAddress.ScrollBars =
                ScrollBars.Vertical;

            txtAddress.Size =
                new System.Drawing.Size(
                    250,
                    260);

            txtAddress.TabIndex =
                2;

            // =========================================
            // TAB VẬN CHUYỂN
            // =========================================

            tabTransport.BackColor =
                System.Drawing.Color.White;

            tabTransport.Controls.Add(
                rdoUrgent);

            tabTransport.Controls.Add(
                rdoFast);

            tabTransport.Controls.Add(
                rdoNormal);

            tabTransport.Location =
                new System.Drawing.Point(
                    4,
                    24);

            tabTransport.Name =
                "tabTransport";

            tabTransport.Padding =
                new Padding(20);

            tabTransport.Size =
                new System.Drawing.Size(
                    282,
                    492);

            tabTransport.TabIndex =
                1;

            tabTransport.Text =
                "Vận chuyển";

            // =========================================
            // RADIO THƯỜNG
            // =========================================

            rdoNormal.AutoSize =
                true;

            rdoNormal.Location =
                new System.Drawing.Point(
                    25,
                    30);

            rdoNormal.Name =
                "rdoNormal";

            rdoNormal.Size =
                new System.Drawing.Size(
                    120,
                    19);

            rdoNormal.TabIndex =
                0;

            rdoNormal.Text =
                "Giao hàng thường";

            rdoNormal.UseVisualStyleBackColor =
                true;

            rdoNormal.Checked =
                true;

            // =========================================
            // RADIO NHANH
            // =========================================

            rdoFast.AutoSize =
                true;

            rdoFast.Location =
                new System.Drawing.Point(
                    25,
                    70);

            rdoFast.Name =
                "rdoFast";

            rdoFast.Size =
                new System.Drawing.Size(
                    120,
                    19);

            rdoFast.TabIndex =
                1;

            rdoFast.Text =
                "Giao hàng nhanh";

            rdoFast.UseVisualStyleBackColor =
                true;

            // =========================================
            // RADIO HỎA TỐC
            // =========================================

            rdoUrgent.AutoSize =
                true;

            rdoUrgent.Location =
                new System.Drawing.Point(
                    25,
                    110);

            rdoUrgent.Name =
                "rdoUrgent";

            rdoUrgent.Size =
                new System.Drawing.Size(
                    130,
                    19);

            rdoUrgent.TabIndex =
                2;

            rdoUrgent.Text =
                "Giao hàng hỏa tốc";

            rdoUrgent.UseVisualStyleBackColor =
                true;

            // =========================================
            // PANEL 2
            // =========================================

            splitContainer.Panel2.BackColor =
                System.Drawing.Color.White;

            splitContainer.Panel2.Padding =
                new Padding(12);

            splitContainer.Panel2.Controls.Add(
                dgvItems);

            splitContainer.Panel2.Controls.Add(
                lblOrderTitle);

            // =========================================
            // TIÊU ĐỀ ĐƠN HÀNG
            // =========================================

            lblOrderTitle.AutoSize =
                true;

            lblOrderTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Bold);

            lblOrderTitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    40,
                    60,
                    80);

            lblOrderTitle.Location =
                new System.Drawing.Point(
                    12,
                    12);

            lblOrderTitle.Name =
                "lblOrderTitle";

            lblOrderTitle.Text =
                "CHI TIẾT ĐƠN HÀNG";

            // =========================================
            // DATAGRIDVIEW
            // =========================================

            dgvItems.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvItems.BackgroundColor =
                System.Drawing.Color.White;

            dgvItems.BorderStyle =
                BorderStyle.FixedSingle;

            dgvItems.ColumnHeadersHeight =
                40;

            dgvItems.EnableHeadersVisualStyles =
                false;

            dgvItems.Location =
                new System.Drawing.Point(
                    12,
                    45);

            dgvItems.Name =
                "dgvItems";

            dgvItems.RowHeadersWidth =
                35;

            dgvItems.RowTemplate.Height =
                35;

            dgvItems.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvItems.MultiSelect =
                false;

            dgvItems.Size =
                new System.Drawing.Size(
                    800,
                    520);

            dgvItems.TabIndex =
                0;

            dgvItems.AllowUserToAddRows =
                true;

            dgvItems.AllowUserToDeleteRows =
                true;

            dgvItems.AllowUserToResizeRows =
                false;

            dgvItems.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvItems.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(
                    45,
                    65,
                    85);

            dgvItems.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;

            dgvItems.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            dgvItems.DefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            // =========================================
            // COLUMN TÊN HÀNG
            // =========================================

            colName.HeaderText =
                "Tên hàng";

            colName.Name =
                "colName";

            colName.FillWeight =
                170;

            // =========================================
            // COLUMN SỐ LƯỢNG
            // =========================================

            colQuantity.HeaderText =
                "Số lượng";

            colQuantity.Name =
                "colQuantity";

            colQuantity.FillWeight =
                80;

            // =========================================
            // COLUMN TRỌNG LƯỢNG
            // =========================================

            colWeight.HeaderText =
                "Trọng lượng (kg)";

            colWeight.Name =
                "colWeight";

            colWeight.FillWeight =
                120;

            // =========================================
            // COLUMN ĐƠN GIÁ
            // =========================================

            colPrice.HeaderText =
                "Đơn giá";

            colPrice.Name =
                "colPrice";

            colPrice.FillWeight =
                110;

            // =========================================
            // COLUMN THÀNH TIỀN
            // =========================================

            colTotal.HeaderText =
                "Thành tiền";

            colTotal.Name =
                "colTotal";

            colTotal.FillWeight =
                130;

            colTotal.ReadOnly =
                true;

            dgvItems.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    colName,
                    colQuantity,
                    colWeight,
                    colPrice,
                    colTotal
                });

            // =========================================
            // STATUS STRIP
            // =========================================

            statusStrip.Dock =
                DockStyle.Bottom;

            statusStrip.Name =
                "statusStrip";

            statusStrip.SizingGrip =
                false;

            statusStrip.Items.Add(
                lblTime);

            statusStrip.Items.Add(
                lblQuantity);

            statusStrip.Items.Add(
                lblWeight);

            statusStrip.Items.Add(
                lblMoney);

            // =========================================
            // STATUS TIME
            // =========================================

            lblTime.Name =
                "lblTime";

            lblTime.Spring =
                true;

            lblTime.Text =
                "Thời gian: ";

            lblTime.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // =========================================
            // STATUS QUANTITY
            // =========================================

            lblQuantity.Name =
                "lblQuantity";

            lblQuantity.Spring =
                true;

            lblQuantity.Text =
                "Tổng số lượng: 0";

            lblQuantity.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =========================================
            // STATUS WEIGHT
            // =========================================

            lblWeight.Name =
                "lblWeight";

            lblWeight.Spring =
                true;

            lblWeight.Text =
                "Tổng trọng lượng: 0 kg";

            lblWeight.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =========================================
            // STATUS MONEY
            // =========================================

            lblMoney.Name =
                "lblMoney";

            lblMoney.Spring =
                true;

            lblMoney.Text =
                "Tổng tiền: 0 đ";

            lblMoney.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;

            // =========================================
            // ERROR PROVIDER
            // =========================================

            errorProvider.BlinkStyle =
                ErrorBlinkStyle.NeverBlink;

            errorProvider.ContainerControl =
                this;

            // =========================================
            // FORM
            // =========================================

            AutoScaleDimensions =
                new System.Drawing.SizeF(
                    7F,
                    15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new System.Drawing.Size(
                    1200,
                    700);

            MinimumSize =
                new System.Drawing.Size(
                    900,
                    600);

            Name =
                "Form1";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Delivery Order Dashboard";

            // =========================================
            // ADD CONTROL
            // =========================================

            Controls.Add(
                splitContainer);

            Controls.Add(
                statusStrip);

            // =========================================
            // EVENT
            // =========================================

            Load +=
                Form1_Load;

            // =========================================
            // RESUME
            // =========================================

            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                dgvItems).EndInit();

            tabTransport.ResumeLayout(false);
            tabTransport.PerformLayout();

            tabCustomer.ResumeLayout(false);
            tabCustomer.PerformLayout();

            tabControl.ResumeLayout(false);

            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();

            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                splitContainer).EndInit();

            splitContainer.ResumeLayout(false);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}