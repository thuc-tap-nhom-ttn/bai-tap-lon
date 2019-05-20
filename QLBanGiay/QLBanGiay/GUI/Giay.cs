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

namespace QLBanGiay
{
    public partial class Giay : MetroFramework.Forms.MetroForm
    {
        BindingSource giayList = new BindingSource();

        public Giay()
        {
            InitializeComponent();
            LoadFirstTime();
        }

        private void LoadFirstTime()
        {
            dgvGiay.DataSource = giayList;
            LoadListGiay();
            EditDataGridView();
            BindingDataToFrom();
        }
        private void LoadListGiay()
        {
            giayList.DataSource = Giay_DAO.Instance.GetAll();
        }
        private void EditDataGridView()
        {
            //dgvGiay.Columns["IdGiay"].HeaderText = "Mã tác giả";
            //dgvGiay.Columns["TENTACGIA"].HeaderText = "Tên tác giả";
        }
        private void BindingDataToFrom()
        {
            txtDonGia.DataBindings.Add(new Binding("Text", dgvGiay.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
            txtIDGiay.DataBindings.Add(new Binding("Text", dgvGiay.DataSource, "IdGiay", true, DataSourceUpdateMode.Never));
            txtSoLuong.DataBindings.Add(new Binding("Text", dgvGiay.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            txtTenGiay.DataBindings.Add(new Binding("Text", dgvGiay.DataSource, "TenGiay", true, DataSourceUpdateMode.Never));
        }


        

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadListGiay();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string tenGiay;
            int soLuong;
            float donGia;
            tenGiay = txtTenGiay.Text;
            Int32.TryParse(txtSoLuong.Text, out soLuong);
            float.TryParse(txtDonGia.Text, out donGia);
            if (tenGiay == null && soLuong == null && donGia == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            Giay_DAO.Instance.Insert(tenGiay, soLuong, donGia);
            MessageBox.Show("Thêm thành công");
            LoadListGiay();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text;
            giayList.DataSource = Giay_DAO.Instance.Search(searchString);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            int idGiay;
            string tenGiay;
            int soLuong;
            float donGia;

            Int32.TryParse(txtIDGiay.Text, out idGiay);
            tenGiay = txtTenGiay.Text;
            Int32.TryParse(txtSoLuong.Text, out soLuong);
            float.TryParse(txtDonGia.Text, out donGia);

            if (tenGiay == null && soLuong == null && donGia == null)
            {
                return;
            }
            Giay_DAO.Instance.Update(idGiay, tenGiay, soLuong, donGia);
            MessageBox.Show("Sửa thành công");
            LoadListGiay();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int idGiay;
            Int32.TryParse(txtIDGiay.Text, out idGiay);

            Giay_DAO.Instance.Delete(idGiay);
            MessageBox.Show("Xóa thành công");
            LoadListGiay();
        }
    }
}
