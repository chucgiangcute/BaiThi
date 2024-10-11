namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai1 b1 = new Bai1();
            b1.MdiParent = this;
            b1.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai2 b2 = new Bai2();
            b2.MdiParent = this;
            b2.Show();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai3 b3 = new Bai3();
            b3.MdiParent = this;
            b3.Show();
        }

        private void hỆTHỐNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn được hỗ trợ ?");
        }
    }
}
