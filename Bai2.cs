using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Bai2_Load(object sender, EventArgs e)
        {
            cbxChucvu.Items.Add("Quản lý");
            cbxChucvu.Items.Add("Nhân viên");
        }


        List<Manager> li_mana = new List<Manager>();

        private void btnThem_Click(object sender, EventArgs e)
        {
            double luongTL = 0;
            double thue = 150000, bHXH = 100000;

            if (cbxChucvu.Text == "Quản lý")
            {
                luongTL = Convert.ToDouble(txtLuong.Text) - thue - bHXH;
            }
            else
            {
                luongTL = Convert.ToDouble(txtLuong.Text) - (thue * 0.3) - (bHXH * 0.4);
            }
            Manager manager = new Manager(txtTen.Text, txtMNV.Text, cbxChucvu.Text, Convert.ToDouble(txtLuong.Text), luongTL, txtTeam.Text);
            li_mana.Add(manager);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_mana;

            txtTen.Text = " ";
            txtMNV.Text = " ";
            cbxChucvu.Text = " ";
            txtLuong.Text = " ";
            txtTeam.Text = " ";


            if (cbxChucvu.Text == "Nhân viên")
            {
                txtTeam.Enabled = false;
            }
        }

        private void cbxChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChucvu.SelectedIndex == 1)
            {
                txtTeam.ReadOnly = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach (Manager i in li_mana)
            {
                if (txtTen.Text == i.Ten)
                {
                    i.Ten = txtTen.Text;
                    i.MaNV = txtMNV.Text;
                    i.ChucVu = cbxChucvu.Text;

                    i.TeamSize = txtTeam.Text;
                }

            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_mana;


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (Manager i in li_mana)
            {
                if (txtTen.Text == i.Ten)
                {
                    li_mana.Remove(i);
                    break;
                }

            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_mana;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
