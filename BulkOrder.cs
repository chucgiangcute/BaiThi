using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class BulkOrder : Oder
    {
        double tongGT;
       

        public double TongGT { get => tongGT; set => tongGT = value; }
        

        public BulkOrder() : base () { }
        
        public BulkOrder(string maDH, string tenKH, string ngayDH, double soLuong, double donGia, double tongGT) : base(maDH,tenKH, ngayDH,soLuong,donGia)
        {
            this.MaDH = maDH;
            this.TenKH = tenKH;
            this.NgayDH = ngayDH;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.TongGT = tongGT;
            
        }

      
    }
}
