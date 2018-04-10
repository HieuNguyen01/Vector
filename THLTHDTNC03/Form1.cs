using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THLTHDTNC03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuChuyenDong_Click(object sender, EventArgs e)
        {
            frmChuyenDong frm = new frmChuyenDong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuNhietHoc_Click(object sender, EventArgs e)
        {
            frmNhietHoc frm = new frmNhietHoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDienHoc_Click(object sender, EventArgs e)
        {
            frmDienHoc frm = new frmDienHoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuVector2D_Click(object sender, EventArgs e)
        {
            frmVector2D frm = new frmVector2D();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuVector3D_Click(object sender, EventArgs e)
        {
            frmVector3D frm = new frmVector3D();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("bạn có chắc chắn muốn thoát?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }
    }
}
