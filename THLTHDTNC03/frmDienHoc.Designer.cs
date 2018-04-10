namespace THLTHDTNC03
{
    partial class frmDienHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDanhSachDienTro = new System.Windows.Forms.Label();
            this.lblRMoi = new System.Windows.Forms.Label();
            this.lblRNoiTiep = new System.Windows.Forms.Label();
            this.lblRTuongDuong = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtRNoiTiep = new System.Windows.Forms.TextBox();
            this.txtRTuongDuong = new System.Windows.Forms.TextBox();
            this.txtRMoi = new System.Windows.Forms.TextBox();
            this.lsDienTro = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDanhSachDienTro
            // 
            this.lblDanhSachDienTro.AutoSize = true;
            this.lblDanhSachDienTro.Location = new System.Drawing.Point(33, 32);
            this.lblDanhSachDienTro.Name = "lblDanhSachDienTro";
            this.lblDanhSachDienTro.Size = new System.Drawing.Size(98, 13);
            this.lblDanhSachDienTro.TabIndex = 0;
            this.lblDanhSachDienTro.Text = "Danh sách điện trở";
            // 
            // lblRMoi
            // 
            this.lblRMoi.AutoSize = true;
            this.lblRMoi.Location = new System.Drawing.Point(339, 32);
            this.lblRMoi.Name = "lblRMoi";
            this.lblRMoi.Size = new System.Drawing.Size(37, 13);
            this.lblRMoi.TabIndex = 0;
            this.lblRMoi.Text = "R mới:";
            // 
            // lblRNoiTiep
            // 
            this.lblRNoiTiep.AutoSize = true;
            this.lblRNoiTiep.Location = new System.Drawing.Point(266, 148);
            this.lblRNoiTiep.Name = "lblRNoiTiep";
            this.lblRNoiTiep.Size = new System.Drawing.Size(55, 13);
            this.lblRNoiTiep.TabIndex = 1;
            this.lblRNoiTiep.Text = "R nối tiếp:";
            // 
            // lblRTuongDuong
            // 
            this.lblRTuongDuong.AutoSize = true;
            this.lblRTuongDuong.Location = new System.Drawing.Point(266, 212);
            this.lblRTuongDuong.Name = "lblRTuongDuong";
            this.lblRTuongDuong.Size = new System.Drawing.Size(174, 13);
            this.lblRTuongDuong.TabIndex = 1;
            this.lblRTuongDuong.Text = "R tương đương khi mắc song song:";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(398, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Enabled = false;
            this.btnTinh.Location = new System.Drawing.Point(299, 291);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính toán";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(468, 291);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtRNoiTiep
            // 
            this.txtRNoiTiep.Location = new System.Drawing.Point(440, 140);
            this.txtRNoiTiep.Name = "txtRNoiTiep";
            this.txtRNoiTiep.ReadOnly = true;
            this.txtRNoiTiep.Size = new System.Drawing.Size(132, 20);
            this.txtRNoiTiep.TabIndex = 5;
            // 
            // txtRTuongDuong
            // 
            this.txtRTuongDuong.Location = new System.Drawing.Point(440, 205);
            this.txtRTuongDuong.Name = "txtRTuongDuong";
            this.txtRTuongDuong.ReadOnly = true;
            this.txtRTuongDuong.Size = new System.Drawing.Size(132, 20);
            this.txtRTuongDuong.TabIndex = 5;
            // 
            // txtRMoi
            // 
            this.txtRMoi.Location = new System.Drawing.Point(398, 24);
            this.txtRMoi.Name = "txtRMoi";
            this.txtRMoi.Size = new System.Drawing.Size(100, 20);
            this.txtRMoi.TabIndex = 6;
            this.txtRMoi.TextChanged += new System.EventHandler(this.txtRMoi_TextChanged);
            // 
            // lsDienTro
            // 
            this.lsDienTro.FormattingEnabled = true;
            this.lsDienTro.Location = new System.Drawing.Point(23, 63);
            this.lsDienTro.Name = "lsDienTro";
            this.lsDienTro.Size = new System.Drawing.Size(221, 303);
            this.lsDienTro.TabIndex = 7;
            // 
            // frmDienHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 440);
            this.Controls.Add(this.lsDienTro);
            this.Controls.Add(this.txtRMoi);
            this.Controls.Add(this.txtRTuongDuong);
            this.Controls.Add(this.txtRNoiTiep);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRTuongDuong);
            this.Controls.Add(this.lblRNoiTiep);
            this.Controls.Add(this.lblRMoi);
            this.Controls.Add(this.lblDanhSachDienTro);
            this.Name = "frmDienHoc";
            this.Text = "Điện học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSachDienTro;
        private System.Windows.Forms.Label lblRMoi;
        private System.Windows.Forms.Label lblRNoiTiep;
        private System.Windows.Forms.Label lblRTuongDuong;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtRNoiTiep;
        private System.Windows.Forms.TextBox txtRTuongDuong;
        private System.Windows.Forms.TextBox txtRMoi;
        private System.Windows.Forms.ListBox lsDienTro;
    }
}