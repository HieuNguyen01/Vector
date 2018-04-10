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
    public partial class frmNhietHoc : Form
    {
        public frmNhietHoc()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            float am, ac, at, bm, bc, bt;
            btnTinh.Enabled = float.TryParse(txtAM.Text, out am) && float.TryParse(txtAC.Text, out ac)
            && float.TryParse(txtAT.Text, out at) && am > 0 && ac > 0 && ac < 41600 && at > -273.15
            && float.TryParse(txtBM.Text, out bm) && float.TryParse(txtBC.Text, out bc)
            && float.TryParse(txtBT.Text, out bt) && bm > 0 && bc > 0 && bc < 41600 && bt > -273.15;
            if (!btnTinh.Enabled)
                txtM.Text = txtC.Text = txtT.Text = "";
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            float am = float.Parse(txtAM.Text);
            float ac = float.Parse(txtAC.Text);
            float at = float.Parse(txtAT.Text);
            float bm = float.Parse(txtBM.Text);
            float bc = float.Parse(txtBC.Text);
            float bt = float.Parse(txtBT.Text);
            float m = am + bm;
            float mc = am * ac + bm * bc;
            float c = mc / m;
            float t = (am * ac * at + bm * bc * bt) / mc;
            txtM.Text = m.ToString();
            txtC.Text = c.ToString();
            txtT.Text = t.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
