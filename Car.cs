using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Car
    {
        string hangXe;
        string bienSo;
        string namSX;
        double giaBan;

        public string HangXe { get => hangXe; set => hangXe = value; }
        public string BienSo { get => bienSo; set => bienSo = value; }
        public string NamSX { get => namSX; set => namSX = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }

        public Car() { }

        public Car(string hangXe, string bienSo, string namSX, double giaBan) : base()
        {
            HangXe = hangXe;
            BienSo = bienSo;
            NamSX = namSX;
            GiaBan = giaBan;
        }
    }
}
