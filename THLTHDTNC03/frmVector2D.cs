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
    public partial class frmVector2D : Form
    {
        public frmVector2D()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            float v1x, v1y, v2x, v2y;
            btnTinh.Enabled = float.TryParse(txtV1X.Text, out v1x) && float.TryParse(txtV1Y.Text, out v1y)
            && float.TryParse(txtV2X.Text, out v2x) && float.TryParse(txtV2Y.Text, out v2y);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            Vector2D v1 = new Vector2D(float.Parse(txtV1X.Text), float.Parse(txtV1Y.Text));
            Vector2D v2 = new Vector2D(float.Parse(txtV2X.Text), float.Parse(txtV2Y.Text));
            txtV1Module.Text = v1.Module().ToString();
            txtV2Module.Text = v2.Module().ToString();
            Vector2D Tong = v1 + v2;
            txtTongX.Text = Tong.HoanhDo.ToString();
            txtTongY.Text = Tong.TungDo.ToString();
            txtTongModule.Text = Tong.Module().ToString();
            Vector2D Hieu = v1 - v2;
            txtHieuX.Text = Hieu.HoanhDo.ToString();
            txtHieuY.Text = Hieu.TungDo.ToString();
            txtHieuModule.Text = Hieu.Module().ToString();
            float tvh = Vector2D.ScalarProduct(v1, v2);
            txtTichVH.Text = tvh.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
