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
    public partial class frmChuyenDong : Form
    {
        public frmChuyenDong()
        {
            InitializeComponent();
        }

        #region 
        private bool ThamSoBanDauHopLe = false;
        private bool BienThoiGianHopLe = true;
        #endregion

        private void TinhToan()
        {
            float s0 = float.Parse(txtViTriBanDau.Text);
            float v0 = float.Parse(txtVanTocBanDau.Text);
            float a = float.Parse(txtGiaTocDeu.Text);
            int t = hsbThoiGian.Value;
            txtThoiGian.Text = t.ToString();
            txtVanToc.Text = (v0 + a * t).ToString();
            txtViTri.Text = (s0 + v0 * t + a * t * t / 2).ToString();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            float s0, v0, a;
            ThamSoBanDauHopLe = float.TryParse(txtViTriBanDau.Text, out s0)
            && float.TryParse(txtVanTocBanDau.Text, out v0)
            && float.TryParse(txtGiaTocDeu.Text, out a);
            hsbThoiGian.Enabled = ThamSoBanDauHopLe && BienThoiGianHopLe;
            if (hsbThoiGian.Enabled) TinhToan();
        }

        private void txtThoiGianBien_TextChanged(object sender, EventArgs e)
        {
            int tgMin = 0, tgMax = 0;
            BienThoiGianHopLe = int.TryParse(txtThoiGianMin.Text, out tgMin)
            && int.TryParse(txtThoiGianMax.Text, out tgMax) && tgMin <= tgMax;
            if (BienThoiGianHopLe)
            {
                hsbThoiGian.Minimum = tgMin;
                hsbThoiGian.Maximum = tgMax;
                txtThoiGian.Text = hsbThoiGian.Value.ToString();
                lblBienThoiGian.Text = "";
                hsbThoiGian.Enabled = ThamSoBanDauHopLe && BienThoiGianHopLe;
                if (hsbThoiGian.Enabled) TinhToan();
            }
            else
            {
                lblBienThoiGian.Text = "Sai biên thời gian";
                txtThoiGian.Text = "";
                txtVanToc.Text = "";
                txtViTri.Text = "";
            }
        }

        private void hsbThoiGian_Scroll(object sender, ScrollEventArgs e)
        {
            TinhToan();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
