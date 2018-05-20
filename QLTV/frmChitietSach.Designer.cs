namespace QLTV
{
	partial class frmChitietSach
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
			this.lvSach = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lvSach
			// 
			this.lvSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
			this.lvSach.FullRowSelect = true;
			this.lvSach.GridLines = true;
			this.lvSach.Location = new System.Drawing.Point(3, -2);
			this.lvSach.Name = "lvSach";
			this.lvSach.Size = new System.Drawing.Size(667, 294);
			this.lvSach.TabIndex = 5;
			this.lvSach.UseCompatibleStateImageBehavior = false;
			this.lvSach.View = System.Windows.Forms.View.Details;
			this.lvSach.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvSach_ItemCheck);
 			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã Sách";
			this.columnHeader1.Width = 75;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên Sách";
			this.columnHeader2.Width = 75;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tác Giả";
			this.columnHeader3.Width = 75;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Thể Loại";
			this.columnHeader4.Width = 75;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Nhà XB";
			this.columnHeader5.Width = 75;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Mã Vị Trí";
			this.columnHeader6.Width = 75;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Năm XB";
			this.columnHeader7.Width = 75;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Số Lượng";
			this.columnHeader8.Width = 75;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Chọn";
			// 
			// frmChitietSach
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 287);
			this.Controls.Add(this.lvSach);
			this.Name = "frmChitietSach";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông tin chi tiết sách";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvSach;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
	}
}