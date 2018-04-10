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
    public partial class frmDienHoc : Form
    {
        public frmDienHoc()
        {
            InitializeComponent();
        }

        #region 
        List<float> dsR = new List<float>();

        #endregion

        private void txtRMoi_TextChanged(object sender, EventArgs e)
        {
            float RMoi;
            btnAdd.Enabled = float.TryParse(txtRMoi.Text, out RMoi) && RMoi > 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float RMoi = float.Parse(txtRMoi.Text);
            dsR.Add(RMoi);
            lsDienTro.Items.Add(RMoi);
            btnAdd.Enabled = false;
            txtRMoi.Text = "";
            btnTinh.Enabled = dsR.Count > 0;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            float R = 0;
            float t = 0;
            for (int i = 0; i < dsR.Count; i++)
            {
                R += dsR[i];
                t += 1 / dsR[i];
            }
            txtRNoiTiep.Text = R.ToString();
            txtRTuongDuong.Text = (1 / t).ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
