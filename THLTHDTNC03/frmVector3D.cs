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
    public partial class frmVector3D : Form
    {
        public frmVector3D()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            float v1x, v1y, v1z, v2x, v2y, v2z, v3x, v3y, v3z;
            btnTinh.Enabled = float.TryParse(txtV1X.Text, out v1x) && float.TryParse(txtV1Y.Text, out v1y)
            && float.TryParse(txtV1Z.Text, out v1z)
            && float.TryParse(txtV2X.Text, out v2x) && float.TryParse(txtV2Y.Text, out v2y)
            && float.TryParse(txtV2Z.Text, out v2z)
            && float.TryParse(txtV3X.Text, out v3x) && float.TryParse(txtV3Y.Text, out v3y)
            && float.TryParse(txtV3Z.Text, out v3z);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            Vector3D v1 = new Vector3D(float.Parse(txtV1X.Text), float.Parse(txtV1Y.Text), float.Parse(txtV1Z.Text));
            Vector3D v2 = new Vector3D(float.Parse(txtV2X.Text), float.Parse(txtV2Y.Text), float.Parse(txtV2Z.Text));
            Vector3D v3 = new Vector3D(float.Parse(txtV3X.Text), float.Parse(txtV3Y.Text), float.Parse(txtV3Z.Text));
            txtV1Module.Text = v1.Module().ToString();
            txtV2Module.Text = v2.Module().ToString();
            txtV3Module.Text = v3.Module().ToString();
            Vector3D Tong = v1 + v2;
            txtTongX.Text = Tong.HoanhDo.ToString();
            txtTongY.Text = Tong.TungDo.ToString();
            txtTongZ.Text = Tong.CaoDo.ToString();
            txtTongModule.Text = Tong.Module().ToString();
            Vector3D Hieu = v1 - v2;
            txtHieuX.Text = Hieu.HoanhDo.ToString();
            txtHieuY.Text = Hieu.TungDo.ToString();
            txtHieuZ.Text = Hieu.CaoDo.ToString();
            txtHieuModule.Text = Hieu.Module().ToString();
            float tvh = Vector3D.ScalarProduct(v1, v2);
            txtTichVH.Text = tvh.ToString();
            Vector3D TichCH = v1 * v2;
            txtTichCHX.Text = TichCH.HoanhDo.ToString();
            txtTichCHY.Text = TichCH.TungDo.ToString();
            txtTichCHZ.Text = TichCH.CaoDo.ToString();
            txtTichCHModule.Text = TichCH.Module().ToString();
            float tht = Vector3D.MixedProduct(v1, v2, v3);
            txtTichHonTap.Text = tht.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
