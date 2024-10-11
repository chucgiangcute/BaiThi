using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ElictricCar : Car
    {
        string luongPin;

        public string LuongPin { get => luongPin; set => luongPin = value; }

        public ElictricCar() { }

        public ElictricCar(string hangXe, string bienSo, string namSX, double giaBan, string luongPin) : base(hangXe, bienSo, namSX,giaBan)
        {
            this.HangXe = hangXe;
            this.BienSo = bienSo;
            this.NamSX = namSX;
            this.GiaBan = giaBan;
            this.LuongPin = luongPin;
        }
    }
}
