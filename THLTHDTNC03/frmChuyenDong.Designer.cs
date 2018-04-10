namespace THLTHDTNC03
{
    partial class frmChuyenDong
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVAnTocBanDau = new System.Windows.Forms.Label();
            this.lblGiaTocDeu = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblVanToc = new System.Windows.Forms.Label();
            this.txtViTriBanDau = new System.Windows.Forms.TextBox();
            this.txtVanTocBanDau = new System.Windows.Forms.TextBox();
            this.txtGiaTocDeu = new System.Windows.Forms.TextBox();
            this.txtVanToc = new System.Windows.Forms.TextBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.hsbThoiGian = new System.Windows.Forms.HScrollBar();
            this.txtThoiGianMin = new System.Windows.Forms.TextBox();
            this.txtThoiGianMax = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblBienThoiGian = new System.Windows.Forms.Label();
            this.lblViTri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vị trí ban đầu:";
            // 
            // lblVAnTocBanDau
            // 
            this.lblVAnTocBanDau.AutoSize = true;
            this.lblVAnTocBanDau.Location = new System.Drawing.Point(35, 71);
            this.lblVAnTocBanDau.Name = "lblVAnTocBanDau";
            this.lblVAnTocBanDau.Size = new System.Drawing.Size(90, 13);
            this.lblVAnTocBanDau.TabIndex = 0;
            this.lblVAnTocBanDau.Text = "Vận tốc ban đầu:";
            // 
            // lblGiaTocDeu
            // 
            this.lblGiaTocDeu.AutoSize = true;
            this.lblGiaTocDeu.Location = new System.Drawing.Point(35, 112);
            this.lblGiaTocDeu.Name = "lblGiaTocDeu";
            this.lblGiaTocDeu.Size = new System.Drawing.Size(66, 13);
            this.lblGiaTocDeu.TabIndex = 0;
            this.lblGiaTocDeu.Text = "Gia tốc đều:";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(35, 151);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(54, 13);
            this.lblThoiGian.TabIndex = 0;
            this.lblThoiGian.Text = "Thời gian:";
            // 
            // lblVanToc
            // 
            this.lblVanToc.AutoSize = true;
            this.lblVanToc.Location = new System.Drawing.Point(174, 244);
            this.lblVanToc.Name = "lblVanToc";
            this.lblVanToc.Size = new System.Drawing.Size(44, 13);
            this.lblVanToc.TabIndex = 1;
            this.lblVanToc.Text = "Vận tốc";
            // 
            // txtViTriBanDau
            // 
            this.txtViTriBanDau.Location = new System.Drawing.Point(153, 21);
            this.txtViTriBanDau.Name = "txtViTriBanDau";
            this.txtViTriBanDau.Size = new System.Drawing.Size(196, 20);
            this.txtViTriBanDau.TabIndex = 2;
            this.txtViTriBanDau.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtVanTocBanDau
            // 
            this.txtVanTocBanDau.Location = new System.Drawing.Point(153, 64);
            this.txtVanTocBanDau.Name = "txtVanTocBanDau";
            this.txtVanTocBanDau.Size = new System.Drawing.Size(196, 20);
            this.txtVanTocBanDau.TabIndex = 2;
            this.txtVanTocBanDau.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtGiaTocDeu
            // 
            this.txtGiaTocDeu.Location = new System.Drawing.Point(153, 105);
            this.txtGiaTocDeu.Name = "txtGiaTocDeu";
            this.txtGiaTocDeu.Size = new System.Drawing.Size(196, 20);
            this.txtGiaTocDeu.TabIndex = 2;
            this.txtGiaTocDeu.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtVanToc
            // 
            this.txtVanToc.Location = new System.Drawing.Point(253, 237);
            this.txtVanToc.Name = "txtVanToc";
            this.txtVanToc.ReadOnly = true;
            this.txtVanToc.Size = new System.Drawing.Size(147, 20);
            this.txtVanToc.TabIndex = 2;
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(253, 284);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.ReadOnly = true;
            this.txtViTri.Size = new System.Drawing.Size(147, 20);
            this.txtViTri.TabIndex = 2;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Location = new System.Drawing.Point(253, 192);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(147, 20);
            this.txtThoiGian.TabIndex = 2;
            this.txtThoiGian.Text = "0";
            // 
            // hsbThoiGian
            // 
            this.hsbThoiGian.Enabled = false;
            this.hsbThoiGian.LargeChange = 1;
            this.hsbThoiGian.Location = new System.Drawing.Point(153, 146);
            this.hsbThoiGian.Maximum = 60;
            this.hsbThoiGian.Name = "hsbThoiGian";
            this.hsbThoiGian.Size = new System.Drawing.Size(395, 17);
            this.hsbThoiGian.SmallChange = 0;
            this.hsbThoiGian.TabIndex = 3;
            this.hsbThoiGian.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbThoiGian_Scroll);
            // 
            // txtThoiGianMin
            // 
            this.txtThoiGianMin.Location = new System.Drawing.Point(153, 192);
            this.txtThoiGianMin.Name = "txtThoiGianMin";
            this.txtThoiGianMin.Size = new System.Drawing.Size(65, 20);
            this.txtThoiGianMin.TabIndex = 4;
            this.txtThoiGianMin.Text = "0";
            this.txtThoiGianMin.TextChanged += new System.EventHandler(this.txtThoiGianBien_TextChanged);
            // 
            // txtThoiGianMax
            // 
            this.txtThoiGianMax.Location = new System.Drawing.Point(482, 192);
            this.txtThoiGianMax.Name = "txtThoiGianMax";
            this.txtThoiGianMax.Size = new System.Drawing.Size(65, 20);
            this.txtThoiGianMax.TabIndex = 4;
            this.txtThoiGianMax.Text = "60";
            this.txtThoiGianMax.TextChanged += new System.EventHandler(this.txtThoiGianBien_TextChanged);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(273, 336);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblBienThoiGian
            // 
            this.lblBienThoiGian.AutoSize = true;
            this.lblBienThoiGian.Location = new System.Drawing.Point(38, 198);
            this.lblBienThoiGian.Name = "lblBienThoiGian";
            this.lblBienThoiGian.Size = new System.Drawing.Size(0, 13);
            this.lblBienThoiGian.TabIndex = 6;
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Location = new System.Drawing.Point(177, 290);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(29, 13);
            this.lblViTri.TabIndex = 7;
            this.lblViTri.Text = "Vị trí";
            // 
            // frmChuyenDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 383);
            this.Controls.Add(this.lblViTri);
            this.Controls.Add(this.lblBienThoiGian);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtThoiGianMax);
            this.Controls.Add(this.txtThoiGianMin);
            this.Controls.Add(this.hsbThoiGian);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.txtVanToc);
            this.Controls.Add(this.txtGiaTocDeu);
            this.Controls.Add(this.txtVanTocBanDau);
            this.Controls.Add(this.txtViTriBanDau);
            this.Controls.Add(this.lblVanToc);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblGiaTocDeu);
            this.Controls.Add(this.lblVAnTocBanDau);
            this.Controls.Add(this.label1);
            this.Name = "frmChuyenDong";
            this.Text = "Chuyển động có gia tốc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVAnTocBanDau;
        private System.Windows.Forms.Label lblGiaTocDeu;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblVanToc;
        private System.Windows.Forms.TextBox txtViTriBanDau;
        private System.Windows.Forms.TextBox txtVanTocBanDau;
        private System.Windows.Forms.TextBox txtGiaTocDeu;
        private System.Windows.Forms.TextBox txtVanToc;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.HScrollBar hsbThoiGian;
        private System.Windows.Forms.TextBox txtThoiGianMin;
        private System.Windows.Forms.TextBox txtThoiGianMax;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblBienThoiGian;
        private System.Windows.Forms.Label lblViTri;
    }
}