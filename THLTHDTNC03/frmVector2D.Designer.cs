namespace THLTHDTNC03
{
    partial class frmVector2D
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
            this.lblVector2D = new System.Windows.Forms.Label();
            this.lblV1 = new System.Windows.Forms.Label();
            this.lblV2 = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblHieu = new System.Windows.Forms.Label();
            this.lblTichVH = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.txtV1X = new System.Windows.Forms.TextBox();
            this.txtV1Y = new System.Windows.Forms.TextBox();
            this.txtV1Module = new System.Windows.Forms.TextBox();
            this.txtV2X = new System.Windows.Forms.TextBox();
            this.txtV2Y = new System.Windows.Forms.TextBox();
            this.txtV2Module = new System.Windows.Forms.TextBox();
            this.txtTongX = new System.Windows.Forms.TextBox();
            this.txtTongY = new System.Windows.Forms.TextBox();
            this.txtTongModule = new System.Windows.Forms.TextBox();
            this.txtHieuX = new System.Windows.Forms.TextBox();
            this.txtHieuY = new System.Windows.Forms.TextBox();
            this.txtHieuModule = new System.Windows.Forms.TextBox();
            this.txtTichVH = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVector2D
            // 
            this.lblVector2D.AutoSize = true;
            this.lblVector2D.Location = new System.Drawing.Point(60, 52);
            this.lblVector2D.Name = "lblVector2D";
            this.lblVector2D.Size = new System.Drawing.Size(55, 13);
            this.lblVector2D.TabIndex = 0;
            this.lblVector2D.Text = "Vector 2D";
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(60, 103);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(23, 13);
            this.lblV1.TabIndex = 0;
            this.lblV1.Text = "V1:";
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Location = new System.Drawing.Point(60, 151);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(23, 13);
            this.lblV2.TabIndex = 0;
            this.lblV2.Text = "V2:";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(60, 197);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(35, 13);
            this.lblTong.TabIndex = 0;
            this.lblTong.Text = "Tổng:";
            // 
            // lblHieu
            // 
            this.lblHieu.AutoSize = true;
            this.lblHieu.Location = new System.Drawing.Point(60, 242);
            this.lblHieu.Name = "lblHieu";
            this.lblHieu.Size = new System.Drawing.Size(32, 13);
            this.lblHieu.TabIndex = 0;
            this.lblHieu.Text = "Hiệu:";
            // 
            // lblTichVH
            // 
            this.lblTichVH.AutoSize = true;
            this.lblTichVH.Location = new System.Drawing.Point(60, 292);
            this.lblTichVH.Name = "lblTichVH";
            this.lblTichVH.Size = new System.Drawing.Size(81, 13);
            this.lblTichVH.TabIndex = 0;
            this.lblTichVH.Text = "Tích vô hướng:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(171, 51);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(55, 13);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "Hoành độ";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(324, 52);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(48, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Tung độ";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(461, 52);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(42, 13);
            this.lblModule.TabIndex = 1;
            this.lblModule.Text = "Module";
            // 
            // txtV1X
            // 
            this.txtV1X.Location = new System.Drawing.Point(144, 95);
            this.txtV1X.Name = "txtV1X";
            this.txtV1X.Size = new System.Drawing.Size(105, 20);
            this.txtV1X.TabIndex = 2;
            this.txtV1X.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtV1Y
            // 
            this.txtV1Y.Location = new System.Drawing.Point(281, 95);
            this.txtV1Y.Name = "txtV1Y";
            this.txtV1Y.Size = new System.Drawing.Size(105, 20);
            this.txtV1Y.TabIndex = 2;
            this.txtV1Y.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtV1Module
            // 
            this.txtV1Module.Location = new System.Drawing.Point(431, 95);
            this.txtV1Module.Name = "txtV1Module";
            this.txtV1Module.ReadOnly = true;
            this.txtV1Module.Size = new System.Drawing.Size(105, 20);
            this.txtV1Module.TabIndex = 2;
            // 
            // txtV2X
            // 
            this.txtV2X.Location = new System.Drawing.Point(144, 144);
            this.txtV2X.Name = "txtV2X";
            this.txtV2X.Size = new System.Drawing.Size(105, 20);
            this.txtV2X.TabIndex = 2;
            this.txtV2X.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtV2Y
            // 
            this.txtV2Y.Location = new System.Drawing.Point(281, 144);
            this.txtV2Y.Name = "txtV2Y";
            this.txtV2Y.Size = new System.Drawing.Size(105, 20);
            this.txtV2Y.TabIndex = 2;
            this.txtV2Y.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtV2Module
            // 
            this.txtV2Module.Location = new System.Drawing.Point(431, 144);
            this.txtV2Module.Name = "txtV2Module";
            this.txtV2Module.ReadOnly = true;
            this.txtV2Module.Size = new System.Drawing.Size(105, 20);
            this.txtV2Module.TabIndex = 2;
            // 
            // txtTongX
            // 
            this.txtTongX.Location = new System.Drawing.Point(144, 190);
            this.txtTongX.Name = "txtTongX";
            this.txtTongX.ReadOnly = true;
            this.txtTongX.Size = new System.Drawing.Size(105, 20);
            this.txtTongX.TabIndex = 2;
            // 
            // txtTongY
            // 
            this.txtTongY.Location = new System.Drawing.Point(281, 190);
            this.txtTongY.Name = "txtTongY";
            this.txtTongY.ReadOnly = true;
            this.txtTongY.Size = new System.Drawing.Size(105, 20);
            this.txtTongY.TabIndex = 2;
            // 
            // txtTongModule
            // 
            this.txtTongModule.Location = new System.Drawing.Point(431, 190);
            this.txtTongModule.Name = "txtTongModule";
            this.txtTongModule.ReadOnly = true;
            this.txtTongModule.Size = new System.Drawing.Size(105, 20);
            this.txtTongModule.TabIndex = 2;
            // 
            // txtHieuX
            // 
            this.txtHieuX.Location = new System.Drawing.Point(144, 235);
            this.txtHieuX.Name = "txtHieuX";
            this.txtHieuX.ReadOnly = true;
            this.txtHieuX.Size = new System.Drawing.Size(105, 20);
            this.txtHieuX.TabIndex = 2;
            // 
            // txtHieuY
            // 
            this.txtHieuY.Location = new System.Drawing.Point(281, 235);
            this.txtHieuY.Name = "txtHieuY";
            this.txtHieuY.ReadOnly = true;
            this.txtHieuY.Size = new System.Drawing.Size(105, 20);
            this.txtHieuY.TabIndex = 2;
            // 
            // txtHieuModule
            // 
            this.txtHieuModule.Location = new System.Drawing.Point(431, 235);
            this.txtHieuModule.Name = "txtHieuModule";
            this.txtHieuModule.ReadOnly = true;
            this.txtHieuModule.Size = new System.Drawing.Size(105, 20);
            this.txtHieuModule.TabIndex = 2;
            // 
            // txtTichVH
            // 
            this.txtTichVH.Location = new System.Drawing.Point(144, 284);
            this.txtTichVH.Name = "txtTichVH";
            this.txtTichVH.ReadOnly = true;
            this.txtTichVH.Size = new System.Drawing.Size(100, 20);
            this.txtTichVH.TabIndex = 3;
            // 
            // btnTinh
            // 
            this.btnTinh.Enabled = false;
            this.btnTinh.Location = new System.Drawing.Point(214, 364);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(392, 364);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmVector2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 430);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtTichVH);
            this.Controls.Add(this.txtHieuModule);
            this.Controls.Add(this.txtTongModule);
            this.Controls.Add(this.txtV2Module);
            this.Controls.Add(this.txtV1Module);
            this.Controls.Add(this.txtHieuY);
            this.Controls.Add(this.txtHieuX);
            this.Controls.Add(this.txtTongY);
            this.Controls.Add(this.txtTongX);
            this.Controls.Add(this.txtV2Y);
            this.Controls.Add(this.txtV2X);
            this.Controls.Add(this.txtV1Y);
            this.Controls.Add(this.txtV1X);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblTichVH);
            this.Controls.Add(this.lblHieu);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.lblV1);
            this.Controls.Add(this.lblVector2D);
            this.Name = "frmVector2D";
            this.Text = "Vector trên mặt phẳng Oxy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVector2D;
        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblHieu;
        private System.Windows.Forms.Label lblTichVH;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.TextBox txtV1X;
        private System.Windows.Forms.TextBox txtV1Y;
        private System.Windows.Forms.TextBox txtV1Module;
        private System.Windows.Forms.TextBox txtV2X;
        private System.Windows.Forms.TextBox txtV2Y;
        private System.Windows.Forms.TextBox txtV2Module;
        private System.Windows.Forms.TextBox txtTongX;
        private System.Windows.Forms.TextBox txtTongY;
        private System.Windows.Forms.TextBox txtTongModule;
        private System.Windows.Forms.TextBox txtHieuX;
        private System.Windows.Forms.TextBox txtHieuY;
        private System.Windows.Forms.TextBox txtHieuModule;
        private System.Windows.Forms.TextBox txtTichVH;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnDong;
    }
}