using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }


        List<Oder> li_oder = new List<Oder>();
        private void btnNhap1_Click(object sender, EventArgs e)
        {
            Oder oder = new Oder(txtMadh1.Text, txtTen1.Text, txtNgaydat1.Text, Convert.ToDouble(txtSoluong1.Text), Convert.ToDouble(txtDongia1.Text));
            li_oder.Add(oder);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_oder;

            txtMadh1.Text = " ";
            txtTen1.Text = " ";
            txtNgaydat1.Text = " ";
            txtSoluong1.Text = " ";
            txtDongia1.Text = " ";
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            foreach (Oder i in li_oder)
            {
                if (txtMadh1.Text == i.MaDH)
                {
                    i.TenKH = txtTen1.Text;
                    i.NgayDH = txtNgaydat1.Text;
                    i.SoLuong = double.Parse(txtSoluong1.Text);
                    i.DonGia = double.Parse(txtDongia1.Text);
                }

            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_oder;
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            foreach (Oder i in li_oder)
            {
                if (txtMadh1.Text == i.MaDH)
                {
                    li_oder.Remove(i);
                    break;
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_oder;
        }


        List<BulkOrder> li_bu = new List<BulkOrder>();
        private void btnNhap2_Click(object sender, EventArgs e)
        {
            double tongGT = 0;
            if(Convert.ToDouble(txtSoluong2.Text) >= 20)
            {
                tongGT = (Convert.ToDouble(txtSoluong2.Text) * Convert.ToDouble(txtDongia2.Text)) * (1 - Convert.ToDouble(txtMagiamgia.Text));
            }  
            else
            {
                tongGT = Convert.ToDouble(txtSoluong2.Text) * Convert.ToDouble(txtDongia2.Text);
            }
            BulkOrder bulkOrder = new BulkOrder(txtMadh2.Text, txtTen2.Text,txtNgaydat2.Text, Convert.ToDouble(txtSoluong2.Text),Convert.ToDouble(txtDongia2.Text),/*Convert.ToDouble(txtMagiamgia.Text),*/ tongGT);

            li_bu.Add(bulkOrder);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = li_bu;

            txtMadh2.Text = " ";
            txtTen2.Text = " ";
            txtNgaydat2.Text = " ";
            txtSoluong2.Text = " ";
            txtDongia2.Text = " ";
            txtMagiamgia.Text = " ";

        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            foreach (BulkOrder i in li_bu)
            {
                if (txtMadh2.Text == i.MaDH)
                {
                    i.TenKH = txtTen2.Text;
                    i.NgayDH = txtNgaydat2.Text;
                    i.SoLuong = double.Parse(txtSoluong2.Text);
                    i.DonGia = double.Parse(txtDongia2.Text);
                }
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = li_bu;
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            foreach(BulkOrder i in li_bu)
            {
                if(txtMadh2.Text ==i.MaDH)
                {
                    li_bu.Remove(i);
                }
            }
            dataGridView2.DataSource=null;
            dataGridView2.DataSource = li_bu;
        }
       
    }
}
