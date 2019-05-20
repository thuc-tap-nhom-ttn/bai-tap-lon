using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanGiay.GUI
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGiay_Click_1(object sender, EventArgs e)
        {
            Giay n = new Giay();
            this.Hide();
            n.ShowDialog();
            this.Show();
        }

        private void btnBaoCaoThongKe_Click_1(object sender, EventArgs e)
        {
            ThongKe_NV frame = new ThongKe_NV();
            this.Hide();
            frame.ShowDialog();
            this.Show();
        }
    }
}
