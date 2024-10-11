namespace WinFormsApp1
{
    partial class Bai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Tên = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTen = new TextBox();
            txtMNV = new TextBox();
            txtLuong = new TextBox();
            txtTeam = new TextBox();
            cbxChucvu = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Tên
            // 
            Tên.AutoSize = true;
            Tên.Font = new Font("Tahoma", 12F);
            Tên.Location = new Point(383, 158);
            Tên.Name = "Tên";
            Tên.Size = new Size(71, 39);
            Tên.TabIndex = 0;
            Tên.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(246, 228);
            label1.Name = "label1";
            label1.Size = new Size(208, 39);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(322, 308);
            label2.Name = "label2";
            label2.Size = new Size(132, 39);
            label2.TabIndex = 0;
            label2.Text = "Chức vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(242, 392);
            label3.Name = "label3";
            label3.Size = new Size(212, 39);
            label3.TabIndex = 0;
            label3.Text = "Lương cơ bản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(295, 466);
            label4.Name = "label4";
            label4.Size = new Size(159, 39);
            label4.TabIndex = 0;
            label4.Text = "Team size";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Tahoma", 12F);
            txtTen.Location = new Point(565, 158);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(445, 46);
            txtTen.TabIndex = 1;
            // 
            // txtMNV
            // 
            txtMNV.Font = new Font("Tahoma", 12F);
            txtMNV.Location = new Point(565, 228);
            txtMNV.Name = "txtMNV";
            txtMNV.Size = new Size(445, 46);
            txtMNV.TabIndex = 1;
            // 
            // txtLuong
            // 
            txtLuong.Font = new Font("Tahoma", 12F);
            txtLuong.Location = new Point(565, 389);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(445, 46);
            txtLuong.TabIndex = 1;
            // 
            // txtTeam
            // 
            txtTeam.Font = new Font("Tahoma", 12F);
            txtTeam.Location = new Point(565, 466);
            txtTeam.Name = "txtTeam";
            txtTeam.Size = new Size(445, 46);
            txtTeam.TabIndex = 1;
            // 
            // cbxChucvu
            // 
            cbxChucvu.Font = new Font("Tahoma", 12F);
            cbxChucvu.FormattingEnabled = true;
            cbxChucvu.Location = new Point(565, 311);
            cbxChucvu.Name = "cbxChucvu";
            cbxChucvu.Size = new Size(445, 47);
            cbxChucvu.TabIndex = 2;
            cbxChucvu.SelectedIndexChanged += cbxChucvu_SelectedIndexChanged;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Tahoma", 12F);
            btnThem.Location = new Point(242, 573);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 54);
            btnThem.TabIndex = 3;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Tahoma", 12F);
            btnSua.Location = new Point(548, 573);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 54);
            btnSua.TabIndex = 3;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Tahoma", 12F);
            btnXoa.Location = new Point(860, 573);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 54);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "XOÁ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Tahoma", 12F);
            btnThoat.Location = new Point(1210, 573);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 54);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(281, 697);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1126, 380);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15F);
            label5.Location = new Point(479, 40);
            label5.Name = "label5";
            label5.Size = new Size(623, 48);
            label5.TabIndex = 5;
            label5.Text = "QUẢN LÝ THÔNG TIN NHÂN VIÊN";
            label5.Click += label5_Click;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ten";
            Column1.HeaderText = "Tên";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "maNV";
            Column2.HeaderText = "Mã nhân viên";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "chucVu";
            Column3.HeaderText = "Chức vụ";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "luong";
            Column4.HeaderText = "Lương cơ bản";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "teamSize";
            Column5.HeaderText = "Team size";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1596, 1122);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cbxChucvu);
            Controls.Add(txtTeam);
            Controls.Add(txtLuong);
            Controls.Add(txtMNV);
            Controls.Add(txtTen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Tên);
            Name = "Bai2";
            Text = "Bai2";
            Load += Bai2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tên;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTen;
        private TextBox txtMNV;
        private TextBox txtLuong;
        private TextBox txtTeam;
        private ComboBox cbxChucvu;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private DataGridView dataGridView1;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}