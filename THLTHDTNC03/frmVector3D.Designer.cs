namespace THLTHDTNC03
{
    partial class frmVector3D
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
            this.lblV3 = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblHieu = new System.Windows.Forms.Label();
            this.lblTichVH = new System.Windows.Forms.Label();
            this.lblTichCH = new System.Windows.Forms.Label();
            this.lblTichHonTap = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtV1X = new System.Windows.Forms.TextBox();
            this.txtV1Y = new System.Windows.Forms.TextBox();
            this.txtV1Z = new System.Windows.Forms.TextBox();
            this.txtV1Module = new System.Windows.Forms.TextBox();
            this.txtV2X = new System.Windows.Forms.TextBox();
            this.txtV2Y = new System.Windows.Forms.TextBox();
            this.txtV2Z = new System.Windows.Forms.TextBox();
            this.txtV2Module = new System.Windows.Forms.TextBox();
            this.txtV3X = new System.Windows.Forms.TextBox();
            this.txtV3Y = new System.Windows.Forms.TextBox();
            this.txtV3Z = new System.Windows.Forms.TextBox();
            this.txtV3Module = new System.Windows.Forms.TextBox();
            this.txtTongX = new System.Windows.Forms.TextBox();
            this.txtTongY = new System.Windows.Forms.TextBox();
            this.txtTongZ = new System.Windows.Forms.TextBox();
            this.txtTongModule = new System.Windows.Forms.TextBox();
            this.txtHieuX = new System.Windows.Forms.TextBox();
            this.txtHieuY = new System.Windows.Forms.TextBox();
            this.txtHieuZ = new System.Windows.Forms.TextBox();
            this.txtHieuModule = new System.Windows.Forms.TextBox();
            this.txtTichCHX = new System.Windows.Forms.TextBox();
            this.txtTichCHY = new System.Windows.Forms.TextBox();
            this.txtTichCHZ = new System.Windows.Forms.TextBox();
            this.txtTichCHModule = new System.Windows.Forms.TextBox();
            this.txtTichVH = new System.Windows.Forms.TextBox();
            this.txtTichHonTap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVector2D
            // 
            this.lblVector2D.AutoSize = true;
            this.lblVector2D.Location = new System.Drawing.Point(55, 27);
            this.lblVector2D.Name = "lblVector2D";
            this.lblVector2D.Size = new System.Drawing.Size(55, 13);
            this.lblVector2D.TabIndex = 0;
            this.lblVector2D.Text = "Vector 2D";
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(55, 77);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(23, 13);
            this.lblV1.TabIndex = 0;
            this.lblV1.Text = "V1:";
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Location = new System.Drawing.Point(55, 122);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(23, 13);
            this.lblV2.TabIndex = 0;
            this.lblV2.Text = "V2:";
            // 
            // lblV3
            // 
            this.lblV3.AutoSize = true;
            this.lblV3.Location = new System.Drawing.Point(55, 164);
            this.lblV3.Name = "lblV3";
            this.lblV3.Size = new System.Drawing.Size(23, 13);
            this.lblV3.TabIndex = 0;
            this.lblV3.Text = "V3:";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(55, 206);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(39, 13);
            this.lblTong.TabIndex = 0;
            this.lblTong.Text = "V1+V2";
            // 
            // lblHieu
            // 
            this.lblHieu.AutoSize = true;
            this.lblHieu.Location = new System.Drawing.Point(55, 243);
            this.lblHieu.Name = "lblHieu";
            this.lblHieu.Size = new System.Drawing.Size(36, 13);
            this.lblHieu.TabIndex = 0;
            this.lblHieu.Text = "V1-V2";
            // 
            // lblTichVH
            // 
            this.lblTichVH.AutoSize = true;
            this.lblTichVH.Location = new System.Drawing.Point(55, 289);
            this.lblTichVH.Name = "lblTichVH";
            this.lblTichVH.Size = new System.Drawing.Size(36, 13);
            this.lblTichVH.TabIndex = 0;
            this.lblTichVH.Text = "V1.V2";
            // 
            // lblTichCH
            // 
            this.lblTichCH.AutoSize = true;
            this.lblTichCH.Location = new System.Drawing.Point(55, 329);
            this.lblTichCH.Name = "lblTichCH";
            this.lblTichCH.Size = new System.Drawing.Size(42, 13);
            this.lblTichCH.TabIndex = 0;
            this.lblTichCH.Text = "[V1,V2]";
            // 
            // lblTichHonTap
            // 
            this.lblTichHonTap.AutoSize = true;
            this.lblTichHonTap.Location = new System.Drawing.Point(55, 365);
            this.lblTichHonTap.Name = "lblTichHonTap";
            this.lblTichHonTap.Size = new System.Drawing.Size(58, 13);
            this.lblTichHonTap.TabIndex = 0;
            this.lblTichHonTap.Text = "V1.[V2.V3]";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(184, 27);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(55, 13);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "Hoành độ";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(300, 27);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(48, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Tung độ";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(414, 27);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(42, 13);
            this.lblZ.TabIndex = 1;
            this.lblZ.Text = "Cao độ";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(547, 27);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(42, 13);
            this.lblModule.TabIndex = 1;
            this.lblModule.Text = "Module";
            // 
            // btnTinh
            // 
            this.btnTinh.Enabled = false;
            this.btnTinh.Location = new System.Drawing.Point(273, 424);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(446, 424);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtV1X
            // 
            this.txtV1X.Location = new System.Drawing.Point(150, 69);
            this.txtV1X.Name = "txtV1X";
            this.txtV1X.Size = new System.Drawing.Size(100, 20);
            this.txtV1X.TabIndex = 3;
            this.txtV1X.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtV1Y
            // 
            this.txtV1Y.Location = new System.Drawing.Point(273, 69);
            this.txtV1Y.Name = "txtV1Y";
            this.txtV1Y.Size = new System.Drawing.Size(100, 20);
            this.txtV1Y.TabIndex = 3;
            this.txtV1Y.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtV1Z
            // 
            this.txtV1Z.Location = new System.Drawing.Point(405, 69);
            this.txtV1Z.Name = "txtV1Z";
            this.txtV1Z.Size = new System.Drawing.Size(100, 20);
            this.txtV1Z.TabIndex = 3;
            this.txtV1Z.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtV1Module
            // 
            this.txtV1Module.Location = new System.Drawing.Point(537, 70);
            this.txtV1Module.Name = "txtV1Module";
            this.txtV1Module.ReadOnly = true;
            this.txtV1Module.Size = new System.Drawing.Size(100, 20);
            this.txtV1Module.TabIndex = 3;
            // 
            // txtV2X
            // 
            this.txtV2X.Location = new System.Drawing.Point(150, 115);
            this.txtV2X.Name = "txtV2X";
            this.txtV2X.Size = new System.Drawing.Size(100, 20);
            this.txtV2X.TabIndex = 3;
            this.txtV2X.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtV2Y
            // 
            this.txtV2Y.Location = new System.Drawing.Point(273, 115);
            this.txtV2Y.Name = "txtV2Y";
            this.txtV2Y.Size = new System.Drawing.Size(100, 20);
            this.txtV2Y.TabIndex = 3;
            this.txtV2Y.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtV2Z
            // 
            this.txtV2Z.Location = new System.Drawing.Point(405, 115);
            this.txtV2Z.Name = "txtV2Z";
            this.txtV2Z.Size = new System.Drawing.Size(100, 20);
            this.txtV2Z.TabIndex = 3;
            this.txtV2Z.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtV2Module
            // 
            this.txtV2Module.Location = new System.Drawing.Point(537, 116);
            this.txtV2Module.Name = "txtV2Module";
            this.txtV2Module.ReadOnly = true;
            this.txtV2Module.Size = new System.Drawing.Size(100, 20);
            this.txtV2Module.TabIndex = 3;
            // 
            // txtV3X
            // 
            this.txtV3X.Location = new System.Drawing.Point(150, 157);
            this.txtV3X.Name = "txtV3X";
            this.txtV3X.Size = new System.Drawing.Size(100, 20);
            this.txtV3X.TabIndex = 3;
            this.txtV3X.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtV3Y
            // 
            this.txtV3Y.Location = new System.Drawing.Point(273, 157);
            this.txtV3Y.Name = "txtV3Y";
            this.txtV3Y.Size = new System.Drawing.Size(100, 20);
            this.txtV3Y.TabIndex = 3;
            this.txtV3Y.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtV3Z
            // 
            this.txtV3Z.Location = new System.Drawing.Point(405, 157);
            this.txtV3Z.Name = "txtV3Z";
            this.txtV3Z.Size = new System.Drawing.Size(100, 20);
            this.txtV3Z.TabIndex = 3;
            this.txtV3Z.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtV3Module
            // 
            this.txtV3Module.Location = new System.Drawing.Point(537, 158);
            this.txtV3Module.Name = "txtV3Module";
            this.txtV3Module.ReadOnly = true;
            this.txtV3Module.Size = new System.Drawing.Size(100, 20);
            this.txtV3Module.TabIndex = 3;
            // 
            // txtTongX
            // 
            this.txtTongX.Location = new System.Drawing.Point(150, 199);
            this.txtTongX.Name = "txtTongX";
            this.txtTongX.ReadOnly = true;
            this.txtTongX.Size = new System.Drawing.Size(100, 20);
            this.txtTongX.TabIndex = 3;
            // 
            // txtTongY
            // 
            this.txtTongY.Location = new System.Drawing.Point(273, 199);
            this.txtTongY.Name = "txtTongY";
            this.txtTongY.ReadOnly = true;
            this.txtTongY.Size = new System.Drawing.Size(100, 20);
            this.txtTongY.TabIndex = 3;
            // 
            // txtTongZ
            // 
            this.txtTongZ.Location = new System.Drawing.Point(405, 199);
            this.txtTongZ.Name = "txtTongZ";
            this.txtTongZ.ReadOnly = true;
            this.txtTongZ.Size = new System.Drawing.Size(100, 20);
            this.txtTongZ.TabIndex = 3;
            // 
            // txtTongModule
            // 
            this.txtTongModule.Location = new System.Drawing.Point(537, 200);
            this.txtTongModule.Name = "txtTongModule";
            this.txtTongModule.ReadOnly = true;
            this.txtTongModule.Size = new System.Drawing.Size(100, 20);
            this.txtTongModule.TabIndex = 3;
            // 
            // txtHieuX
            // 
            this.txtHieuX.Location = new System.Drawing.Point(150, 236);
            this.txtHieuX.Name = "txtHieuX";
            this.txtHieuX.ReadOnly = true;
            this.txtHieuX.Size = new System.Drawing.Size(100, 20);
            this.txtHieuX.TabIndex = 3;
            // 
            // txtHieuY
            // 
            this.txtHieuY.Location = new System.Drawing.Point(273, 236);
            this.txtHieuY.Name = "txtHieuY";
            this.txtHieuY.ReadOnly = true;
            this.txtHieuY.Size = new System.Drawing.Size(100, 20);
            this.txtHieuY.TabIndex = 3;
            // 
            // txtHieuZ
            // 
            this.txtHieuZ.Location = new System.Drawing.Point(405, 236);
            this.txtHieuZ.Name = "txtHieuZ";
            this.txtHieuZ.ReadOnly = true;
            this.txtHieuZ.Size = new System.Drawing.Size(100, 20);
            this.txtHieuZ.TabIndex = 3;
            // 
            // txtHieuModule
            // 
            this.txtHieuModule.Location = new System.Drawing.Point(537, 237);
            this.txtHieuModule.Name = "txtHieuModule";
            this.txtHieuModule.ReadOnly = true;
            this.txtHieuModule.Size = new System.Drawing.Size(100, 20);
            this.txtHieuModule.TabIndex = 3;
            // 
            // txtTichCHX
            // 
            this.txtTichCHX.Location = new System.Drawing.Point(150, 322);
            this.txtTichCHX.Name = "txtTichCHX";
            this.txtTichCHX.ReadOnly = true;
            this.txtTichCHX.Size = new System.Drawing.Size(100, 20);
            this.txtTichCHX.TabIndex = 3;
            // 
            // txtTichCHY
            // 
            this.txtTichCHY.Location = new System.Drawing.Point(273, 322);
            this.txtTichCHY.Name = "txtTichCHY";
            this.txtTichCHY.ReadOnly = true;
            this.txtTichCHY.Size = new System.Drawing.Size(100, 20);
            this.txtTichCHY.TabIndex = 3;
            // 
            // txtTichCHZ
            // 
            this.txtTichCHZ.Location = new System.Drawing.Point(405, 322);
            this.txtTichCHZ.Name = "txtTichCHZ";
            this.txtTichCHZ.ReadOnly = true;
            this.txtTichCHZ.Size = new System.Drawing.Size(100, 20);
            this.txtTichCHZ.TabIndex = 3;
            // 
            // txtTichCHModule
            // 
            this.txtTichCHModule.Location = new System.Drawing.Point(537, 323);
            this.txtTichCHModule.Name = "txtTichCHModule";
            this.txtTichCHModule.ReadOnly = true;
            this.txtTichCHModule.Size = new System.Drawing.Size(100, 20);
            this.txtTichCHModule.TabIndex = 3;
            // 
            // txtTichVH
            // 
            this.txtTichVH.Location = new System.Drawing.Point(150, 282);
            this.txtTichVH.Name = "txtTichVH";
            this.txtTichVH.ReadOnly = true;
            this.txtTichVH.Size = new System.Drawing.Size(100, 20);
            this.txtTichVH.TabIndex = 3;
            // 
            // txtTichHonTap
            // 
            this.txtTichHonTap.Location = new System.Drawing.Point(150, 358);
            this.txtTichHonTap.Name = "txtTichHonTap";
            this.txtTichHonTap.ReadOnly = true;
            this.txtTichHonTap.Size = new System.Drawing.Size(100, 20);
            this.txtTichHonTap.TabIndex = 3;
            // 
            // frmVector3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 479);
            this.Controls.Add(this.txtTichCHModule);
            this.Controls.Add(this.txtHieuModule);
            this.Controls.Add(this.txtTongModule);
            this.Controls.Add(this.txtV3Module);
            this.Controls.Add(this.txtV2Module);
            this.Controls.Add(this.txtV1Module);
            this.Controls.Add(this.txtTichCHZ);
            this.Controls.Add(this.txtHieuZ);
            this.Controls.Add(this.txtTongZ);
            this.Controls.Add(this.txtV3Z);
            this.Controls.Add(this.txtV2Z);
            this.Controls.Add(this.txtV1Z);
            this.Controls.Add(this.txtTichCHY);
            this.Controls.Add(this.txtTichCHX);
            this.Controls.Add(this.txtHieuY);
            this.Controls.Add(this.txtTichHonTap);
            this.Controls.Add(this.txtTichVH);
            this.Controls.Add(this.txtHieuX);
            this.Controls.Add(this.txtTongY);
            this.Controls.Add(this.txtTongX);
            this.Controls.Add(this.txtV3Y);
            this.Controls.Add(this.txtV3X);
            this.Controls.Add(this.txtV2Y);
            this.Controls.Add(this.txtV2X);
            this.Controls.Add(this.txtV1Y);
            this.Controls.Add(this.txtV1X);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblTichHonTap);
            this.Controls.Add(this.lblTichCH);
            this.Controls.Add(this.lblTichVH);
            this.Controls.Add(this.lblHieu);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.lblV3);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.lblV1);
            this.Controls.Add(this.lblVector2D);
            this.Name = "frmVector3D";
            this.Text = "Vector trong không gian Oxyz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVector2D;
        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.Label lblV3;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblHieu;
        private System.Windows.Forms.Label lblTichVH;
        private System.Windows.Forms.Label lblTichCH;
        private System.Windows.Forms.Label lblTichHonTap;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtV1X;
        private System.Windows.Forms.TextBox txtV1Y;
        private System.Windows.Forms.TextBox txtV1Z;
        private System.Windows.Forms.TextBox txtV1Module;
        private System.Windows.Forms.TextBox txtV2X;
        private System.Windows.Forms.TextBox txtV2Y;
        private System.Windows.Forms.TextBox txtV2Z;
        private System.Windows.Forms.TextBox txtV2Module;
        private System.Windows.Forms.TextBox txtV3X;
        private System.Windows.Forms.TextBox txtV3Y;
        private System.Windows.Forms.TextBox txtV3Z;
        private System.Windows.Forms.TextBox txtV3Module;
        private System.Windows.Forms.TextBox txtTongX;
        private System.Windows.Forms.TextBox txtTongY;
        private System.Windows.Forms.TextBox txtTongZ;
        private System.Windows.Forms.TextBox txtTongModule;
        private System.Windows.Forms.TextBox txtHieuX;
        private System.Windows.Forms.TextBox txtHieuY;
        private System.Windows.Forms.TextBox txtHieuZ;
        private System.Windows.Forms.TextBox txtHieuModule;
        private System.Windows.Forms.TextBox txtTichCHX;
        private System.Windows.Forms.TextBox txtTichCHY;
        private System.Windows.Forms.TextBox txtTichCHZ;
        private System.Windows.Forms.TextBox txtTichCHModule;
        private System.Windows.Forms.TextBox txtTichVH;
        private System.Windows.Forms.TextBox txtTichHonTap;
    }
}