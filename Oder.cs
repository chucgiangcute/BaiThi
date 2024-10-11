using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Oder
    {
        string maDH;
        string tenKH;
        string ngayDH;
        double soLuong;
        double donGia;

        public string MaDH { get => maDH; set => maDH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string NgayDH { get => ngayDH; set => ngayDH = value; }
        public double SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGia { get => donGia; set => donGia = value; }

        public Oder() { }

        public Oder(string maDH, string tenKH, string ngayDH, double soLuong, double donGia)
        {
            MaDH = maDH;
            TenKH = tenKH;
            NgayDH = ngayDH;
            SoLuong = soLuong;
            DonGia = donGia;
        }
    }
}
