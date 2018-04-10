namespace THLTHDTNC03
{
    partial class frmNhietHoc
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
            this.lblVatLieu = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblHonHop = new System.Windows.Forms.Label();
            this.lblKhoiLuong = new System.Windows.Forms.Label();
            this.lblNhietDungRieng = new System.Windows.Forms.Label();
            this.lblNhietDo = new System.Windows.Forms.Label();
            this.txtAM = new System.Windows.Forms.TextBox();
            this.txtAC = new System.Windows.Forms.TextBox();
            this.txtAT = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtBM = new System.Windows.Forms.TextBox();
            this.txtBC = new System.Windows.Forms.TextBox();
            this.txtBT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVatLieu
            // 
            this.lblVatLieu.AutoSize = true;
            this.lblVatLieu.Location = new System.Drawing.Point(58, 48);
            this.lblVatLieu.Name = "lblVatLieu";
            this.lblVatLieu.Size = new System.Drawing.Size(42, 13);
            this.lblVatLieu.TabIndex = 0;
            this.lblVatLieu.Text = "Vật liệu";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(58, 105);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(58, 167);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 13);
            this.lblB.TabIndex = 0;
            this.lblB.Text = "B:";
            // 
            // lblHonHop
            // 
            this.lblHonHop.AutoSize = true;
            this.lblHonHop.Location = new System.Drawing.Point(58, 227);
            this.lblHonHop.Name = "lblHonHop";
            this.lblHonHop.Size = new System.Drawing.Size(48, 13);
            this.lblHonHop.TabIndex = 0;
            this.lblHonHop.Text = "Hỗn hợp";
            // 
            // lblKhoiLuong
            // 
            this.lblKhoiLuong.AutoSize = true;
            this.lblKhoiLuong.Location = new System.Drawing.Point(173, 48);
            this.lblKhoiLuong.Name = "lblKhoiLuong";
            this.lblKhoiLuong.Size = new System.Drawing.Size(75, 13);
            this.lblKhoiLuong.TabIndex = 0;
            this.lblKhoiLuong.Text = "Khối lượng(kg)";
            // 
            // lblNhietDungRieng
            // 
            this.lblNhietDungRieng.AutoSize = true;
            this.lblNhietDungRieng.Location = new System.Drawing.Point(281, 48);
            this.lblNhietDungRieng.Name = "lblNhietDungRieng";
            this.lblNhietDungRieng.Size = new System.Drawing.Size(123, 13);
            this.lblNhietDungRieng.TabIndex = 0;
            this.lblNhietDungRieng.Text = "Nhiệt dung riêng(J/kg.K)";
            // 
            // lblNhietDo
            // 
            this.lblNhietDo.AutoSize = true;
            this.lblNhietDo.Location = new System.Drawing.Point(437, 48);
            this.lblNhietDo.Name = "lblNhietDo";
            this.lblNhietDo.Size = new System.Drawing.Size(61, 13);
            this.lblNhietDo.TabIndex = 0;
            this.lblNhietDo.Text = "Nhiệt độ(C)";
            // 
            // txtAM
            // 
            this.txtAM.Location = new System.Drawing.Point(149, 97);
            this.txtAM.Name = "txtAM";
            this.txtAM.Size = new System.Drawing.Size(100, 20);
            this.txtAM.TabIndex = 1;
            this.txtAM.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtAC
            // 
            this.txtAC.Location = new System.Drawing.Point(284, 97);
            this.txtAC.Name = "txtAC";
            this.txtAC.Size = new System.Drawing.Size(100, 20);
            this.txtAC.TabIndex = 1;
            this.txtAC.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtAT
            // 
            this.txtAT.Location = new System.Drawing.Point(426, 97);
            this.txtAT.Name = "txtAT";
            this.txtAT.Size = new System.Drawing.Size(100, 20);
            this.txtAT.TabIndex = 1;
            this.txtAT.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(149, 220);
            this.txtM.Name = "txtM";
            this.txtM.ReadOnly = true;
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 1;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(284, 220);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 1;
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(426, 220);
            this.txtT.Name = "txtT";
            this.txtT.ReadOnly = true;
            this.txtT.Size = new System.Drawing.Size(100, 20);
            this.txtT.TabIndex = 1;
            // 
            // btnTinh
            // 
            this.btnTinh.Enabled = false;
            this.btnTinh.Location = new System.Drawing.Point(176, 308);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(356, 308);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtBM
            // 
            this.txtBM.Location = new System.Drawing.Point(149, 160);
            this.txtBM.Name = "txtBM";
            this.txtBM.Size = new System.Drawing.Size(100, 20);
            this.txtBM.TabIndex = 1;
            this.txtBM.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtBC
            // 
            this.txtBC.Location = new System.Drawing.Point(284, 160);
            this.txtBC.Name = "txtBC";
            this.txtBC.Size = new System.Drawing.Size(100, 20);
            this.txtBC.TabIndex = 1;
            this.txtBC.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtBT
            // 
            this.txtBT.Location = new System.Drawing.Point(426, 160);
            this.txtBT.Name = "txtBT";
            this.txtBT.Size = new System.Drawing.Size(100, 20);
            this.txtBT.TabIndex = 1;
            this.txtBT.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // frmNhietHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 406);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtBT);
            this.Controls.Add(this.txtBC);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtBM);
            this.Controls.Add(this.txtAT);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtAC);
            this.Controls.Add(this.txtAM);
            this.Controls.Add(this.lblHonHop);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblNhietDo);
            this.Controls.Add(this.lblNhietDungRieng);
            this.Controls.Add(this.lblKhoiLuong);
            this.Controls.Add(this.lblVatLieu);
            this.Name = "frmNhietHoc";
            this.Text = "Nhiệt học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVatLieu;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblHonHop;
        private System.Windows.Forms.Label lblKhoiLuong;
        private System.Windows.Forms.Label lblNhietDungRieng;
        private System.Windows.Forms.Label lblNhietDo;
        private System.Windows.Forms.TextBox txtAM;
        private System.Windows.Forms.TextBox txtAC;
        private System.Windows.Forms.TextBox txtAT;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtBM;
        private System.Windows.Forms.TextBox txtBC;
        private System.Windows.Forms.TextBox txtBT;
    }
}