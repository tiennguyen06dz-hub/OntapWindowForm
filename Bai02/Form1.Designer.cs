using System.Drawing;
using System.Windows.Forms;

namespace ITSupportTicket
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblTicketId;
        private Label lblRequester;
        private Label lblDate;
        private Label lblPriority;
        private Label lblProblemType;
        private Label lblDevice;
        private Label lblImage;

        private TextBox txtTicketId;
        private TextBox txtRequester;

        private DateTimePicker dtpDate;

        private RadioButton rdoLow;
        private RadioButton rdoMedium;
        private RadioButton rdoUrgent;

        private ComboBox cboProblemType;

        private CheckBox chkDesktop;
        private CheckBox chkLaptop;
        private CheckBox chkPrinter;
        private CheckBox chkPhone;

        private PictureBox picError;
        private Button btnLoadImage;
        private Button btnSubmit;
        private Button btnReset;

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
            this.components =
                new System.ComponentModel.Container();

            this.lblTitle = new Label();
            this.lblTicketId = new Label();
            this.lblRequester = new Label();
            this.lblDate = new Label();
            this.lblPriority = new Label();
            this.lblProblemType = new Label();
            this.lblDevice = new Label();
            this.lblImage = new Label();

            this.txtTicketId = new TextBox();
            this.txtRequester = new TextBox();

            this.dtpDate = new DateTimePicker();

            this.rdoLow = new RadioButton();
            this.rdoMedium = new RadioButton();
            this.rdoUrgent = new RadioButton();

            this.cboProblemType = new ComboBox();

            this.chkDesktop = new CheckBox();
            this.chkLaptop = new CheckBox();
            this.chkPrinter = new CheckBox();
            this.chkPhone = new CheckBox();

            this.picError = new PictureBox();

            this.btnLoadImage = new Button();
            this.btnSubmit = new Button();
            this.btnReset = new Button();

            this.tableLayoutPanel1 =
                new TableLayoutPanel();

            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions =
                new SizeF(7F, 15F);

            this.AutoScaleMode =
                AutoScaleMode.Font;

            this.ClientSize =
                new Size(750, 650);

            this.MinimumSize =
                new Size(650, 550);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Text =
                "IT Support Ticket Form";

            // Table
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Padding =
                new Padding(25);

            this.tableLayoutPanel1.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    35F));

            this.tableLayoutPanel1.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    65F));

            for (int i = 0; i < 10; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(
                    new RowStyle(
                        SizeType.Absolute,
                        50F));
            }

            // Title
            this.lblTitle.Text =
                "TIẾP NHẬN & PHÂN LOẠI SỰ CỐ IT";

            this.lblTitle.Dock =
                DockStyle.Fill;

            this.lblTitle.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblTitle.Font =
                new Font(
                    "Segoe UI",
                    14F,
                    FontStyle.Bold);

            this.tableLayoutPanel1.Controls.Add(
                this.lblTitle,
                0,
                0);

            this.tableLayoutPanel1.SetColumnSpan(
                this.lblTitle,
                2);

            // Mã phiếu
            this.lblTicketId.Text =
                "Mã phiếu:";

            this.lblTicketId.Dock =
                DockStyle.Fill;

            this.lblTicketId.TextAlign =
                ContentAlignment.MiddleLeft;

            this.tableLayoutPanel1.Controls.Add(
                this.lblTicketId,
                0,
                1);

            this.txtTicketId.Dock =
                DockStyle.Fill;

            this.txtTicketId.TabIndex = 0;

            this.tableLayoutPanel1.Controls.Add(
                this.txtTicketId,
                1,
                1);

            // Người yêu cầu
            this.lblRequester.Text =
                "Người yêu cầu:";

            this.lblRequester.Dock =
                DockStyle.Fill;

            this.lblRequester.TextAlign =
                ContentAlignment.MiddleLeft;

            this.tableLayoutPanel1.Controls.Add(
                this.lblRequester,
                0,
                2);

            this.txtRequester.Dock =
                DockStyle.Fill;

            this.txtRequester.TabIndex = 1;

            this.tableLayoutPanel1.Controls.Add(
                this.txtRequester,
                1,
                2);

            // Ngày
            this.lblDate.Text =
                "Ngày ghi nhận:";

            this.lblDate.Dock =
                DockStyle.Fill;

            this.lblDate.TextAlign =
                ContentAlignment.MiddleLeft;

            this.tableLayoutPanel1.Controls.Add(
                this.lblDate,
                0,
                3);

            this.dtpDate.Dock =
                DockStyle.Fill;

            this.dtpDate.Format =
                DateTimePickerFormat.Short;

            this.dtpDate.TabIndex = 2;

            this.tableLayoutPanel1.Controls.Add(
                this.dtpDate,
                1,
                3);

            // Priority
            this.lblPriority.Text =
                "Mức độ ưu tiên:";

            this.lblPriority.Dock =
                DockStyle.Fill;

            this.lblPriority.TextAlign =
                ContentAlignment.MiddleLeft;

            this.tableLayoutPanel1.Controls.Add(
                this.lblPriority,
                0,
                4);

            FlowLayoutPanel priorityPanel =
                new FlowLayoutPanel();

            priorityPanel.Dock =
                DockStyle.Fill;

            priorityPanel.Controls.Add(
                this.rdoLow);

            priorityPanel.Controls.Add(
                this.rdoMedium);

            priorityPanel.Controls.Add(
                this.rdoUrgent);

            this.rdoLow.Text = "Thấp";
            this.rdoMedium.Text = "Trung bình";
            this.rdoUrgent.Text = "Khẩn cấp";

            this.rdoMedium.Checked = true;

            this.tableLayoutPanel1.Controls.Add(
                priorityPanel,
                1,
                4);

            // Loại sự cố
            this.lblProblemType.Text =
                "Loại sự cố:";

            this.lblProblemType.Dock =
                DockStyle.Fill;

            this.lblProblemType.TextAlign =
                ContentAlignment.MiddleLeft;

            this.tableLayoutPanel1.Controls.Add(
                this.lblProblemType,
                0,
                5);

            this.cboProblemType.Dock =
                DockStyle.Fill;

            this.cboProblemType.DropDownStyle =
                ComboBoxStyle.DropDownList;

            this.cboProblemType.Items.AddRange(
                new object[]
                {
                    "Phần cứng",
                    "Phần mềm",
                    "Mạng",
                    "Tài khoản"
                });

            this.cboProblemType.SelectedIndex = 0;
            this.cboProblemType.TabIndex = 3;

            this.tableLayoutPanel1.Controls.Add(
                this.cboProblemType,
                1,
                5);

            // Thiết bị
            this.lblDevice.Text =
                "Thiết bị ảnh hưởng:";

            this.lblDevice.Dock =
                DockStyle.Fill;

            this.lblDevice.TextAlign =
                ContentAlignment.MiddleLeft;

            this.tableLayoutPanel1.Controls.Add(
                this.lblDevice,
                0,
                6);

            FlowLayoutPanel devicePanel =
                new FlowLayoutPanel();

            devicePanel.Dock =
                DockStyle.Fill;

            this.chkDesktop.Text =
                "Máy tính bàn";

            this.chkLaptop.Text =
                "Laptop";

            this.chkPrinter.Text =
                "Máy in";

            this.chkPhone.Text =
                "Điện thoại";

            devicePanel.Controls.Add(
                this.chkDesktop);

            devicePanel.Controls.Add(
                this.chkLaptop);

            devicePanel.Controls.Add(
                this.chkPrinter);

            devicePanel.Controls.Add(
                this.chkPhone);

            this.tableLayoutPanel1.Controls.Add(
                devicePanel,
                1,
                6);

            // Picture
            this.lblImage.Text =
                "Ảnh chụp lỗi:";

            this.lblImage.Dock =
                DockStyle.Fill;

            this.lblImage.TextAlign =
                ContentAlignment.MiddleLeft;

            this.tableLayoutPanel1.Controls.Add(
                this.lblImage,
                0,
                7);

            FlowLayoutPanel imagePanel =
                new FlowLayoutPanel();

            imagePanel.Dock =
                DockStyle.Fill;

            this.picError.Size =
                new Size(120, 70);

            this.picError.SizeMode =
                PictureBoxSizeMode.StretchImage;

            this.picError.BorderStyle =
                BorderStyle.FixedSingle;

            this.btnLoadImage.Text =
                "Tải ảnh lỗi";

            this.btnLoadImage.AutoSize = true;

            this.btnLoadImage.Click +=
                new System.EventHandler(
                    this.btnLoadImage_Click);

            imagePanel.Controls.Add(
                this.picError);

            imagePanel.Controls.Add(
                this.btnLoadImage);

            this.tableLayoutPanel1.Controls.Add(
                imagePanel,
                1,
                7);

            // Buttons
            this.btnSubmit.Text =
                "Gửi yêu cầu";

            this.btnSubmit.Dock =
                DockStyle.Fill;

            this.btnSubmit.TabIndex = 4;

            this.btnSubmit.Click +=
                new System.EventHandler(
                    this.btnSubmit_Click);

            this.tableLayoutPanel1.Controls.Add(
                this.btnSubmit,
                0,
                8);

            this.btnReset.Text =
                "Nhập lại";

            this.btnReset.Dock =
                DockStyle.Fill;

            this.btnReset.TabIndex = 5;

            this.btnReset.Click +=
                new System.EventHandler(
                    this.btnReset_Click);

            this.tableLayoutPanel1.Controls.Add(
                this.btnReset,
                1,
                8);

            this.Controls.Add(
                this.tableLayoutPanel1);

            this.ResumeLayout(false);
        }
    }
}