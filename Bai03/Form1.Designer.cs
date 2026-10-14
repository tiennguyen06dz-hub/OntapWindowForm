using System.Drawing;
using System.Windows.Forms;

namespace ItemListManager
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpInput;
        private GroupBox grpList;

        private Label lblMaVT;
        private Label lblTenVT;
        private Label lblDonViTinh;
        private Label lblDonGia;

        private TextBox txtMaVT;
        private TextBox txtTenVT;
        private TextBox txtDonGia;

        private ComboBox cboDonViTinh;

        private ListView lvItems;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteAll;

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

            this.grpInput = new GroupBox();
            this.grpList = new GroupBox();

            this.lblMaVT = new Label();
            this.lblTenVT = new Label();
            this.lblDonViTinh = new Label();
            this.lblDonGia = new Label();

            this.txtMaVT = new TextBox();
            this.txtTenVT = new TextBox();
            this.txtDonGia = new TextBox();

            this.cboDonViTinh = new ComboBox();

            this.lvItems = new ListView();

            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnDeleteAll = new Button();

            this.grpInput.SuspendLayout();
            this.grpList.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions =
                new SizeF(7F, 15F);

            this.AutoScaleMode =
                AutoScaleMode.Font;

            this.ClientSize =
                new Size(900, 550);

            this.MinimumSize =
                new Size(750, 450);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Text =
                "Item List Manager";

            // Group Input
            this.grpInput.Text =
                "Thông tin vật tư";

            this.grpInput.Dock =
                DockStyle.Left;

            this.grpInput.Width = 300;

            this.grpInput.Padding =
                new Padding(15);

            // Mã vật tư
            this.lblMaVT.Text =
                "Mã vật tư:";

            this.lblMaVT.Location =
                new Point(20, 40);

            this.lblMaVT.AutoSize = true;

            this.txtMaVT.Location =
                new Point(20, 65);

            this.txtMaVT.Width = 240;

            this.txtMaVT.TabIndex = 0;

            // Tên vật tư
            this.lblTenVT.Text =
                "Tên vật tư:";

            this.lblTenVT.Location =
                new Point(20, 105);

            this.lblTenVT.AutoSize = true;

            this.txtTenVT.Location =
                new Point(20, 130);

            this.txtTenVT.Width = 240;

            this.txtTenVT.TabIndex = 1;

            // Đơn vị tính
            this.lblDonViTinh.Text =
                "Đơn vị tính:";

            this.lblDonViTinh.Location =
                new Point(20, 170);

            this.lblDonViTinh.AutoSize = true;

            this.cboDonViTinh.Location =
                new Point(20, 195);

            this.cboDonViTinh.Width = 240;

            this.cboDonViTinh.DropDownStyle =
                ComboBoxStyle.DropDownList;

            this.cboDonViTinh.Items.AddRange(
                new object[]
                {
                    "Cái",
                    "Bộ",
                    "Kg",
                    "Mét"
                });

            this.cboDonViTinh.SelectedIndex = 0;
            this.cboDonViTinh.TabIndex = 2;

            // Đơn giá
            this.lblDonGia.Text =
                "Đơn giá nhập:";

            this.lblDonGia.Location =
                new Point(20, 235);

            this.lblDonGia.AutoSize = true;

            this.txtDonGia.Location =
                new Point(20, 260);

            this.txtDonGia.Width = 240;

            this.txtDonGia.TabIndex = 3;

            // Thêm
            this.btnAdd.Text =
                "Thêm mới";

            this.btnAdd.Location =
                new Point(20, 310);

            this.btnAdd.Size =
                new Size(115, 40);

            this.btnAdd.TabIndex = 4;

            this.btnAdd.Click +=
                new System.EventHandler(
                    this.btnAdd_Click);

            // Cập nhật
            this.btnUpdate.Text =
                "Cập nhật";

            this.btnUpdate.Location =
                new Point(145, 310);

            this.btnUpdate.Size =
                new Size(115, 40);

            this.btnUpdate.TabIndex = 5;

            this.btnUpdate.Click +=
                new System.EventHandler(
                    this.btnUpdate_Click);

            // Xóa dòng
            this.btnDelete.Text =
                "Xóa dòng";

            this.btnDelete.Location =
                new Point(20, 365);

            this.btnDelete.Size =
                new Size(115, 40);

            this.btnDelete.TabIndex = 6;

            this.btnDelete.Click +=
                new System.EventHandler(
                    this.btnDelete_Click);

            // Xóa toàn bộ
            this.btnDeleteAll.Text =
                "Xóa toàn bộ";

            this.btnDeleteAll.Location =
                new Point(145, 365);

            this.btnDeleteAll.Size =
                new Size(115, 40);

            this.btnDeleteAll.TabIndex = 7;

            this.btnDeleteAll.Click +=
                new System.EventHandler(
                    this.btnDeleteAll_Click);

            this.grpInput.Controls.Add(
                this.lblMaVT);

            this.grpInput.Controls.Add(
                this.txtMaVT);

            this.grpInput.Controls.Add(
                this.lblTenVT);

            this.grpInput.Controls.Add(
                this.txtTenVT);

            this.grpInput.Controls.Add(
                this.lblDonViTinh);

            this.grpInput.Controls.Add(
                this.cboDonViTinh);

            this.grpInput.Controls.Add(
                this.lblDonGia);

            this.grpInput.Controls.Add(
                this.txtDonGia);

            this.grpInput.Controls.Add(
                this.btnAdd);

            this.grpInput.Controls.Add(
                this.btnUpdate);

            this.grpInput.Controls.Add(
                this.btnDelete);

            this.grpInput.Controls.Add(
                this.btnDeleteAll);

            // Group List
            this.grpList.Text =
                "Danh sách vật tư";

            this.grpList.Dock =
                DockStyle.Fill;

            this.grpList.Padding =
                new Padding(10);

            // ListView
            this.lvItems.Dock =
                DockStyle.Fill;

            this.lvItems.View =
                View.Details;

            this.lvItems.FullRowSelect =
                true;

            this.lvItems.GridLines =
                true;

            this.lvItems.MultiSelect =
                false;

            this.lvItems.HideSelection =
                false;

            this.lvItems.Columns.Add(
                "Mã VT",
                100);

            this.lvItems.Columns.Add(
                "Tên VT",
                220);

            this.lvItems.Columns.Add(
                "Đơn vị tính",
                120);

            this.lvItems.Columns.Add(
                "Đơn giá",
                150);

            this.lvItems.SelectedIndexChanged +=
                new System.EventHandler(
                    this.lvItems_SelectedIndexChanged);

            this.grpList.Controls.Add(
                this.lvItems);

            // Add controls
            this.Controls.Add(
                this.grpList);

            this.Controls.Add(
                this.grpInput);

            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();

            this.grpList.ResumeLayout(false);

            this.ResumeLayout(false);
        }
    }
}