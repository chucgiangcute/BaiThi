using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }


        List<Car> li_car = new List<Car>();
        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car(txtHangxe1.Text, txtBienso1.Text, txtNamSx1.Text, Convert.ToDouble(txtGiaban1.Text));
            if (string.IsNullOrEmpty(txtHangxe1.Text) || string.IsNullOrEmpty(txtBienso1.Text) || string.IsNullOrEmpty(txtNamSx1.Text) || string.IsNullOrEmpty(txtGiaban1.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                ListViewItem item = listView1.Items.Add(txtHangxe1.Text);
                item.SubItems.Add(txtBienso1.Text);
                item.SubItems.Add(txtNamSx1.Text);
                item.SubItems.Add(txtGiaban1.Text);

                txtHangxe1.Text = " ";
                txtBienso1.Text = " ";
                txtNamSx1.Text = " ";
                txtGiaban1.Text = " ";
            }


        }

        private void Bai1_Load(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[1].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[2].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[3].Width = (int)(listView1.Width * 0.25);

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;


            listView2.Columns[0].Width = (int)(listView2.Width * 0.25);
            listView2.Columns[1].Width = (int)(listView2.Width * 0.25);
            listView2.Columns[2].Width = (int)(listView2.Width * 0.25);
            listView2.Columns[3].Width = (int)(listView2.Width * 0.25);
            listView2.Columns[4].Width = (int)(listView2.Width * 0.25);

            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtHangxe1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtBienso1.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtNamSx1.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtGiaban1.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đối tượng cần sửa");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtHangxe1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtBienso1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtNamSx1.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtGiaban1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xoá");
            }
        }


        List<ElictricCar> li_el = new List<ElictricCar>();
        private void button4_Click(object sender, EventArgs e)
        {
            ElictricCar elictricCar = new ElictricCar(txtHangxe2.Text, txtBienso2.Text, txtNamSx2.Text, Convert.ToDouble(txtGiaban2.Text), txtLuongpin.Text);

            if (string.IsNullOrEmpty(txtHangxe2.Text) || string.IsNullOrEmpty(txtBienso2.Text) || string.IsNullOrEmpty(txtNamSx2.Text) || string.IsNullOrEmpty(txtGiaban2.Text) || string.IsNullOrEmpty(txtLuongpin.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin !");
            }
            else
            {
                ListViewItem item = listView2.Items.Add(txtHangxe2.Text);
                item.SubItems.Add(txtBienso2.Text);
                item.SubItems.Add(txtNamSx2.Text);
                item.SubItems.Add(txtGiaban2.Text);
                item.SubItems.Add(txtLuongpin.Text);

                txtHangxe2.Text = " ";
                txtBienso2.Text = " ";
                txtNamSx2.Text = " ";
                txtGiaban2.Text = " ";
                txtLuongpin.Text = " ";
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.SelectedItems[0].SubItems[0].Text = txtHangxe2.Text;
                listView2.SelectedItems[0].SubItems[1].Text = txtBienso2.Text;
                listView2.SelectedItems[0].SubItems[2].Text = txtNamSx2.Text;
                listView2.SelectedItems[0].SubItems[3].Text = txtGiaban2.Text;
                listView2.SelectedItems[0].SubItems[4].Text = txtLuongpin.Text;

            }
            else
            {
                MessageBox.Show("Vui lòng chọn đối thượng cần sửa");
            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                txtHangxe2.Text = listView2.SelectedItems[0].SubItems[0].Text;
                txtBienso2.Text = listView2.SelectedItems[0].SubItems[1].Text;
                txtNamSx2.Text = listView2.SelectedItems[0].SubItems[2].Text;
                txtGiaban2.Text = listView2.SelectedItems[0].SubItems[3].Text;
                txtLuongpin.Text = listView2.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            if(listView2.SelectedItems.Count > 0)
            {
                listView2.Items.Remove(listView2.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Chọn đối tượn cần xoá !");
            }
        }
    }
}
