using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanGiay.DTO;

namespace QLBanGiay.DAO
{
    class Giay_DAO
    {
        private static Giay_DAO instance;

        internal static Giay_DAO Instance
        {
            get { if (instance == null) instance = new Giay_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<Giay_DTO> GetAll()
        {
            List<Giay_DTO> list = new List<Giay_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Giay");
            foreach (DataRow item in data.Rows)
            {
                Giay_DTO giay = new Giay_DTO(item);
                list.Add(giay);
            }
            return list;
        }

        public bool Insert(string tenGiay, int soLuong, float donGia)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("insert into Giay(TenGiay, SoLuong, DonGia) values( @tenGiay , @soLuong , @donGia )", new object[] { tenGiay, soLuong, donGia });
            return result > 0;
        }

        public bool Update(int idGiay, string tenGiay, int soLuong, float donGia)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("update Giay set TenGiay = @tenGiay , soLuong = @soLuong , donGia  = @donGia where idGiay = @idGiay", new object[] { tenGiay, soLuong, donGia, idGiay });

            return result > 0;
        }
        public bool Delete(int idGiay)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("delete Giay where idGiay = @idGiay", new object[] { idGiay });

            return result > 0;
        }
        public List<Giay_DTO> Search(string searchValue)
        {
            List<Giay_DTO> list = new List<Giay_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_Giay_Search @searchValue", new object[] { searchValue });
            foreach (DataRow item in data.Rows)
            {
                Giay_DTO giay = new Giay_DTO(item);
                list.Add(giay);
            }
            return list;
        }
    }
}
