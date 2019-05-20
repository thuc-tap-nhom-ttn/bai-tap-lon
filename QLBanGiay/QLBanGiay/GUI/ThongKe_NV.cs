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
    public partial class ThongKe_NV : MetroFramework.Forms.MetroForm
    {
        public ThongKe_NV()
        {
            InitializeComponent();
        }

       

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                return;
            }
            ThongKe frame = new ThongKe(name);
            this.Hide();
            frame.ShowDialog();
            this.Show();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
