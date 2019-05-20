using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanGiay.DTO
{
    class Giay_DTO
    {
        private int idGiay;
        private string tenGiay;
        private int soLuong;
        private float donGia;

        public int IdGiay
        {
            get
            {
                return idGiay;
            }

            set
            {
                idGiay = value;
            }
        }

        public string TenGiay
        {
            get
            {
                return tenGiay;
            }

            set
            {
                tenGiay = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public float DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public Giay_DTO() { }

        public Giay_DTO(DataRow row)
        {
            Int32.TryParse(row["IdGiay"].ToString(), out idGiay);
            Int32.TryParse(row["SoLuong"].ToString(), out soLuong);
            float.TryParse(row["DonGia"].ToString(), out donGia);
            TenGiay = row["Tengiay"].ToString();
        }

        public override string ToString()
        {
            return TenGiay;
        }
    }
}
