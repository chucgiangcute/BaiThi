using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Manager : Employee
    {
        string teamSize;
        //double luongThucLanh;

        public string TeamSize { get => teamSize; set => teamSize = value; }
        //public double LuongThucLanh1 { get => luongThucLanh; set => luongThucLanh = value; }

        public Manager() : base() { }

        public Manager(string ten,string maNV, string chucVu, double luong,double luongThucLanh,string teamSize) : base(ten,maNV,chucVu,luong,luongThucLanh)
        {
            this.Ten = ten;
            this.MaNV = maNV;
            this.ChucVu = chucVu;
            this.Luong = luong;
            this.TeamSize = teamSize;
            this.LuongThucLanh = luongThucLanh;
        }
    }
}
