namespace THLTHDTNC03
{
    partial class MainForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuVatLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenDong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhietHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDienHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHinhHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVector2D = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVector3D = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtThúcChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVatLy,
            this.mnuHinhHoc,
            this.mnuHeThong});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(535, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "Main Menu";
            // 
            // mnuVatLy
            // 
            this.mnuVatLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChuyenDong,
            this.mnuNhietHoc,
            this.mnuDienHoc});
            this.mnuVatLy.Name = "mnuVatLy";
            this.mnuVatLy.Size = new System.Drawing.Size(48, 20);
            this.mnuVatLy.Text = "&Vật lý";
            // 
            // mnuChuyenDong
            // 
            this.mnuChuyenDong.Name = "mnuChuyenDong";
            this.mnuChuyenDong.Size = new System.Drawing.Size(152, 22);
            this.mnuChuyenDong.Text = "&Chuyển động";
            this.mnuChuyenDong.Click += new System.EventHandler(this.mnuChuyenDong_Click);
            // 
            // mnuNhietHoc
            // 
            this.mnuNhietHoc.Name = "mnuNhietHoc";
            this.mnuNhietHoc.Size = new System.Drawing.Size(152, 22);
            this.mnuNhietHoc.Text = "&Nhiệt học";
            this.mnuNhietHoc.Click += new System.EventHandler(this.mnuNhietHoc_Click);
            // 
            // mnuDienHoc
            // 
            this.mnuDienHoc.Name = "mnuDienHoc";
            this.mnuDienHoc.Size = new System.Drawing.Size(152, 22);
            this.mnuDienHoc.Text = "&Điện học";
            this.mnuDienHoc.Click += new System.EventHandler(this.mnuDienHoc_Click);
            // 
            // mnuHinhHoc
            // 
            this.mnuHinhHoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVector2D,
            this.mnuVector3D});
            this.mnuHinhHoc.Name = "mnuHinhHoc";
            this.mnuHinhHoc.Size = new System.Drawing.Size(68, 20);
            this.mnuHinhHoc.Text = "&Hình học";
            // 
            // mnuVector2D
            // 
            this.mnuVector2D.Name = "mnuVector2D";
            this.mnuVector2D.Size = new System.Drawing.Size(231, 22);
            this.mnuVector2D.Text = "Vector trên &mặt phẳng Oxy";
            this.mnuVector2D.Click += new System.EventHandler(this.mnuVector2D_Click);
            // 
            // mnuVector3D
            // 
            this.mnuVector3D.Name = "mnuVector3D";
            this.mnuVector3D.Size = new System.Drawing.Size(231, 22);
            this.mnuVector3D.Text = "Vector trong &không gian Oxyz";
            this.mnuVector3D.Click += new System.EventHandler(this.mnuVector3D_Click);
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.kếtThúcChươngTrìnhToolStripMenuItem,
            this.mnuKetThuc});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "Hệ &thống";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(199, 22);
            this.mnuAbout.Text = "&Vài nét về chương trình";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // kếtThúcChươngTrìnhToolStripMenuItem
            // 
            this.kếtThúcChươngTrìnhToolStripMenuItem.Enabled = false;
            this.kếtThúcChươngTrìnhToolStripMenuItem.Name = "kếtThúcChươngTrìnhToolStripMenuItem";
            this.kếtThúcChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.kếtThúcChươngTrìnhToolStripMenuItem.Text = "_________________________";
            // 
            // mnuKetThuc
            // 
            this.mnuKetThuc.Name = "mnuKetThuc";
            this.mnuKetThuc.Size = new System.Drawing.Size(199, 22);
            this.mnuKetThuc.Text = "&Kết thúc chương trình";
            this.mnuKetThuc.Click += new System.EventHandler(this.mnuKetThuc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 367);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Menu";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuVatLy;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenDong;
        private System.Windows.Forms.ToolStripMenuItem mnuNhietHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuDienHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuHinhHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuVector2D;
        private System.Windows.Forms.ToolStripMenuItem mnuVector3D;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem kếtThúcChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuKetThuc;
    }
}

