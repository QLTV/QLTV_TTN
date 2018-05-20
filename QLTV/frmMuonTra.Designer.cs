namespace QLTV
{
    partial class frmMuonTra
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lvMuonSach = new System.Windows.Forms.ListView();
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbmanv = new System.Windows.Forms.ComboBox();
			this.cbmasv = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnthongtinsach = new System.Windows.Forms.Button();
			this.txtmasach = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txttensach = new System.Windows.Forms.TextBox();
			this.dtngaymuon = new System.Windows.Forms.DateTimePicker();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnMuonSach = new System.Windows.Forms.Button();
			this.txtphieumuon = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lvTraSach = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.btnTraSach = new System.Windows.Forms.Button();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(813, 504);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
			this.tabPage1.Controls.Add(this.lvMuonSach);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(805, 478);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Mượn Sách";
			// 
			// lvMuonSach
			// 
			this.lvMuonSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
			this.lvMuonSach.FullRowSelect = true;
			this.lvMuonSach.GridLines = true;
			this.lvMuonSach.Location = new System.Drawing.Point(3, 262);
			this.lvMuonSach.Name = "lvMuonSach";
			this.lvMuonSach.Size = new System.Drawing.Size(796, 210);
			this.lvMuonSach.TabIndex = 1;
			this.lvMuonSach.UseCompatibleStateImageBehavior = false;
			this.lvMuonSach.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "STT";
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Mã Sách";
			this.columnHeader10.Width = 100;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Tên Sách";
			this.columnHeader11.Width = 100;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Mã Phiếu Mượn";
			this.columnHeader12.Width = 100;
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Mã Nhân Viên";
			this.columnHeader13.Width = 100;
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Mã Sinh Viên";
			this.columnHeader14.Width = 100;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Ngày Mượn";
			this.columnHeader15.Width = 100;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbmanv);
			this.groupBox2.Controls.Add(this.cbmasv);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.dtngaymuon);
			this.groupBox2.Controls.Add(this.btnThoat);
			this.groupBox2.Controls.Add(this.btnMuonSach);
			this.groupBox2.Controls.Add(this.txtphieumuon);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Location = new System.Drawing.Point(3, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(799, 250);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông Tin";
			// 
			// cbmanv
			// 
			this.cbmanv.FormattingEnabled = true;
			this.cbmanv.Location = new System.Drawing.Point(530, 142);
			this.cbmanv.Name = "cbmanv";
			this.cbmanv.Size = new System.Drawing.Size(200, 21);
			this.cbmanv.TabIndex = 17;
			this.cbmanv.SelectedIndexChanged += new System.EventHandler(this.cbmanv_SelectedIndexChanged);
			// 
			// cbmasv
			// 
			this.cbmasv.FormattingEnabled = true;
			this.cbmasv.Location = new System.Drawing.Point(530, 96);
			this.cbmasv.Name = "cbmasv";
			this.cbmasv.Size = new System.Drawing.Size(200, 21);
			this.cbmasv.TabIndex = 16;
			this.cbmasv.SelectedIndexChanged += new System.EventHandler(this.cbmasv_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnthongtinsach);
			this.groupBox3.Controls.Add(this.txtmasach);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.txttensach);
			this.groupBox3.Location = new System.Drawing.Point(34, 29);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(340, 103);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thông tin sách";
			// 
			// btnthongtinsach
			// 
			this.btnthongtinsach.Location = new System.Drawing.Point(272, 23);
			this.btnthongtinsach.Name = "btnthongtinsach";
			this.btnthongtinsach.Size = new System.Drawing.Size(52, 53);
			this.btnthongtinsach.TabIndex = 8;
			this.btnthongtinsach.Text = "...";
			this.btnthongtinsach.UseVisualStyleBackColor = true;
			this.btnthongtinsach.Click += new System.EventHandler(this.btnthongtinsach_Click);
			// 
			// txtmasach
			// 
			this.txtmasach.Location = new System.Drawing.Point(81, 23);
			this.txtmasach.Name = "txtmasach";
			this.txtmasach.ReadOnly = true;
			this.txtmasach.Size = new System.Drawing.Size(185, 20);
			this.txtmasach.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Mã Sách";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Tên Sách";
			// 
			// txttensach
			// 
			this.txttensach.Location = new System.Drawing.Point(81, 56);
			this.txttensach.Name = "txttensach";
			this.txttensach.ReadOnly = true;
			this.txttensach.Size = new System.Drawing.Size(185, 20);
			this.txttensach.TabIndex = 7;
			// 
			// dtngaymuon
			// 
			this.dtngaymuon.CustomFormat = "dd/MM/yyyy";
			this.dtngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtngaymuon.Location = new System.Drawing.Point(530, 197);
			this.dtngaymuon.Name = "dtngaymuon";
			this.dtngaymuon.Size = new System.Drawing.Size(200, 20);
			this.dtngaymuon.TabIndex = 14;
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(222, 195);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 13;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			// 
			// btnMuonSach
			// 
			this.btnMuonSach.Location = new System.Drawing.Point(112, 195);
			this.btnMuonSach.Name = "btnMuonSach";
			this.btnMuonSach.Size = new System.Drawing.Size(75, 23);
			this.btnMuonSach.TabIndex = 12;
			this.btnMuonSach.Text = "Mượn Sách";
			this.btnMuonSach.UseVisualStyleBackColor = true;
 			// 
			// txtphieumuon
			// 
			this.txtphieumuon.Location = new System.Drawing.Point(530, 39);
			this.txtphieumuon.Name = "txtphieumuon";
			this.txtphieumuon.ReadOnly = true;
			this.txtphieumuon.Size = new System.Drawing.Size(200, 20);
			this.txtphieumuon.TabIndex = 8;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(425, 205);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(61, 13);
			this.label11.TabIndex = 5;
			this.label11.Text = "Ngày mượn";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(422, 150);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "Mã nhân viên";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(419, 99);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Mã sinh viên";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(414, 42);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "Mã phiếu mượn";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
			this.tabPage2.Controls.Add(this.lvTraSach);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(805, 478);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Trả Sách";
			// 
			// lvTraSach
			// 
			this.lvTraSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
			this.lvTraSach.FullRowSelect = true;
			this.lvTraSach.GridLines = true;
			this.lvTraSach.Location = new System.Drawing.Point(3, 259);
			this.lvTraSach.Name = "lvTraSach";
			this.lvTraSach.Size = new System.Drawing.Size(796, 213);
			this.lvTraSach.TabIndex = 1;
			this.lvTraSach.UseCompatibleStateImageBehavior = false;
			this.lvTraSach.View = System.Windows.Forms.View.Details;
			// 
			// ColumnHeader1
			// 
			this.ColumnHeader1.Text = "STT";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã Phiếu Mượn";
			this.columnHeader2.Width = 95;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Mã Nhân Viên";
			this.columnHeader3.Width = 95;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Mã Sinh Viên";
			this.columnHeader4.Width = 95;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Mã Sách";
			this.columnHeader5.Width = 95;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Ngày Mượn ";
			this.columnHeader6.Width = 95;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Ngày Trả";
			this.columnHeader7.Width = 95;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Tiền Phạt";
			this.columnHeader8.Width = 95;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.btnLamMoi);
			this.groupBox1.Controls.Add(this.btnTraSach);
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.dateTimePicker2);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(796, 247);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông Tin";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(138, 210);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(146, 20);
			this.textBox4.TabIndex = 13;
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Location = new System.Drawing.Point(631, 208);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
			this.btnLamMoi.TabIndex = 12;
			this.btnLamMoi.Text = "Làm Mới";
			this.btnLamMoi.UseVisualStyleBackColor = true;
			// 
			// btnTraSach
			// 
			this.btnTraSach.Location = new System.Drawing.Point(506, 208);
			this.btnTraSach.Name = "btnTraSach";
			this.btnTraSach.Size = new System.Drawing.Size(75, 23);
			this.btnTraSach.TabIndex = 11;
			this.btnTraSach.Text = "Trả Sách";
			this.btnTraSach.UseVisualStyleBackColor = true;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(13, 210);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimKiem.TabIndex = 10;
			this.btnTimKiem.Text = "Tìm Kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(506, 101);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker2.TabIndex = 9;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(506, 48);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 8;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(138, 145);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(146, 20);
			this.textBox3.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(138, 94);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(146, 20);
			this.textBox2.TabIndex = 6;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(138, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(146, 20);
			this.textBox1.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(367, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ngày trả";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(367, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ngày mượn ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 148);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mã sách";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mã sinh viên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã phiếu mượn";
			// 
			// frmMuonTra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 516);
			this.Controls.Add(this.tabControl1);
			this.Name = "frmMuonTra";
			this.Text = "QUẢN LÍ MƯỢN TRẢ SÁCH";
			this.Load += new System.EventHandler(this.frmMuonTra_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvMuonSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtngaymuon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMuonSach;
        private System.Windows.Forms.TextBox txtphieumuon;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvTraSach;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnthongtinsach;
		private System.Windows.Forms.ComboBox cbmanv;
		private System.Windows.Forms.ComboBox cbmasv;
	}
}