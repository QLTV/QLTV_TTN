namespace QLTV
{
    partial class frmTrangChu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnVitri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BackgroundImage = global::QLTV.Properties.Resources.sach;
            this.panel1.Controls.Add(this.btnMuonTra);
            this.panel1.Controls.Add(this.btnSinhVien);
            this.panel1.Controls.Add(this.btnSach);
            this.panel1.Controls.Add(this.btnVitri);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 498);
            this.panel1.TabIndex = 0;
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMuonTra.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnMuonTra.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMuonTra.Location = new System.Drawing.Point(429, 271);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(216, 141);
            this.btnMuonTra.TabIndex = 10;
            this.btnMuonTra.Text = "Quản lý Mượn,Trả";
            this.btnMuonTra.UseVisualStyleBackColor = false;
            this.btnMuonTra.Click += new System.EventHandler(this.btnMuontra_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSinhVien.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSinhVien.Location = new System.Drawing.Point(274, 109);
            this.btnSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(214, 141);
            this.btnSinhVien.TabIndex = 9;
            this.btnSinhVien.Text = "Quản lý Sinh Viên";
            this.btnSinhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSinhVien.UseVisualStyleBackColor = false;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click_1);
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSach.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSach.Location = new System.Drawing.Point(517, 109);
            this.btnSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(216, 141);
            this.btnSach.TabIndex = 8;
            this.btnSach.Text = "Quản lý Sách";
            this.btnSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click_1);
            // 
            // btnVitri
            // 
            this.btnVitri.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVitri.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVitri.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVitri.Location = new System.Drawing.Point(116, 271);
            this.btnVitri.Margin = new System.Windows.Forms.Padding(2);
            this.btnVitri.Name = "btnVitri";
            this.btnVitri.Size = new System.Drawing.Size(214, 141);
            this.btnVitri.TabIndex = 7;
            this.btnVitri.Text = "Quản lý Vị Trí Sách";
            this.btnVitri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVitri.UseVisualStyleBackColor = false;
            this.btnVitri.Click += new System.EventHandler(this.btnVitri_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lựa chọn chức năng";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNhanVien.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNhanVien.Location = new System.Drawing.Point(28, 109);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(216, 141);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Quản lý Nhân Viên";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click_1);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 498);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnVitri;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnMuonTra;
    }
}