using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
	public partial class frmChitietSach : Form
	{
		public frmChitietSach()
		{
			InitializeComponent();
			ShowSach();
			lvSach.CheckBoxes = true;
		}
		DataConnections connect = new DataConnections();
 		public void ShowSach()
		{
			connect.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from SACH";
			cmd.Connection = connect.conn;

			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				ListViewItem listview = new ListViewItem();
				listview.SubItems.Add(reader.GetString(0));
				listview.SubItems.Add(reader.GetString(1));
				listview.SubItems.Add(reader.GetString(2));
				listview.SubItems.Add(reader.GetString(3));
				listview.SubItems.Add(reader.GetString(4));
				listview.SubItems.Add(reader.GetString(5));
				listview.SubItems.Add(reader.GetDateTime(6).ToString());
				listview.SubItems.Add(reader.GetInt32(7).ToString());

 				lvSach.Items.Add(listview);
			}
			reader.Close();
		}
		public delegate void GETDATA(string vl1 ,string vl2);
		public GETDATA mydata;
		string ma = null;
		string ten = null;
  		private void lvSach_ItemCheck(object sender, ItemCheckEventArgs e)
		{

			if (lvSach.SelectedIndices.Count == 0) return;
			ListViewItem liv = lvSach.SelectedItems[0];
			ma += liv.SubItems[1].Text +",";
			ten += liv.SubItems[2].Text + ",";
			mydata(ma, ten);
		}
	}
}
