using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Employee
    {
        string ten;
        string maNV;
        string chucVu;
        double luong;
        double luongThucLanh;

        public string Ten { get => ten; set => ten = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public double Luong { get => luong; set => luong = value; }
        public double LuongThucLanh { get => luongThucLanh; set => luongThucLanh = value; }

        public Employee() { }  

        public Employee(string ten, string maNV, string chucVu, double luong,double luongThucLanh)
        {
            Ten = ten;
            MaNV = maNV;
            ChucVu = chucVu;
            Luong = luong;
            LuongThucLanh = luongThucLanh;
        }
    }
}
