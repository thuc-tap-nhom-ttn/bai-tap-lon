using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanGiay.DAO;
using QLBanGiay.DTO;


namespace QLBanGiay.GUI
{
    public partial class ThongKe : MetroFramework.Forms.MetroForm
    {
        private string name;
        public ThongKe(string name)
        {
            InitializeComponent();
            this.name = name;
            txtHoTen.Text = name;
            dgvThongKe.DataSource = ThongKeDAO.Instance.GetListThongKe();
            float tongTien = ThongKeDAO.Instance.GetTongTien();
            txtSum.Text = tongTien.ToString();

            DateTime currentTime = DateTime.Now;
            txtNgay.Text = currentTime.Day.ToString();
            txtThang.Text = currentTime.Month.ToString();
            txtNam.Text = currentTime.Year.ToString();
            // dgvThongKe.ScrollBars = ScrollBars.None;
        }

        

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
