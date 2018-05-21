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
    public partial class frmMuonTra : Form
    {
        public frmMuonTra()
        {
            InitializeComponent();
			ShowDataPM();
		}
 		private void frmMuonTra_Load(object sender, EventArgs e)
		{
			ShowMaSV();
			ShowMaNV();
			ShowPhieuTra();
		}
		#region Phiếu Mượn
		#region ShowData
		DataConnections connect = new DataConnections();
		List<string> lstPM = new List<string>();
		public void ShowDataPM()
		{
			connect.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from PHIEUMUON";
			cmd.Connection = connect.conn;

			SqlDataReader reader = cmd.ExecuteReader();
			lvMuonSach.Items.Clear();
			while (reader.Read())
			{
				ListViewItem listview = new ListViewItem(reader.GetString(4));
 				listview.SubItems.Add(reader.GetString(5));
				listview.SubItems.Add(reader.GetString(0));
				listview.SubItems.Add(reader.GetString(1));
				listview.SubItems.Add(reader.GetString(2));
 				listview.SubItems.Add(reader.GetDateTime(3).ToString("dd/MM/yyyy"));


 				lstPM.Add(reader.GetString(0));
				lvMuonSach.Items.Add(listview);
			}
			reader.Close();
		}

		public void ShowMaNV()
		{

			connect.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from NHANVIEN";
			cmd.Connection = connect.conn;

			SqlDataReader reader = cmd.ExecuteReader();
			cbmanv.Items.Clear();
			while (reader.Read())
			{
				string manv = reader.GetString(0);
				string tennv = reader.GetString(1);

				cbmanv.Items.Add(manv + "-" + tennv);
			}
			reader.Close();
		}
		public void ShowMaSV()
		{
			connect.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from SINHVIEN";
			cmd.Connection = connect.conn;

			SqlDataReader reader = cmd.ExecuteReader();
			cbmasv.Items.Clear();
			while (reader.Read())
			{
				string masv = reader.GetString(0);
				string tensv = reader.GetString(1);

				cbmasv.Items.Add(masv + "-" + tensv);
			}
			reader.Close();
		}

		#endregion
		public void GETVALUE(string valuema ,string valueten)
		{
			txtmasach.Text = valuema;
			txttensach.Text = valueten;
		}
 		public void ThemPM()
		{
 			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "MuonSach";
			cmd.Connection = connect.conn;
			connect.OpenConnection();
			cmd.Parameters.Add("@MAPM", SqlDbType.NVarChar).Value = txtphieumuon.Text;
			cmd.Parameters.Add("@MANV", SqlDbType.NVarChar).Value = arrMA[1];
			cmd.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = arrMA[0];
			cmd.Parameters.Add("@NGAYMUON", SqlDbType.Date).Value = dtngaymuon.Value;
			cmd.Parameters.Add("@MASACH", SqlDbType.NVarChar).Value = txtmasach.Text;
			cmd.Parameters.Add("@TENSACH", SqlDbType.NVarChar).Value =txttensach.Text;
 			cmd.ExecuteNonQuery();
			connect.CloseConnection();
 		}
		#region Controller
		private void btnthongtinsach_Click(object sender, EventArgs e)
		{
			frmChitietSach frmctsach = new frmChitietSach();
			frmctsach.mydata = new frmChitietSach.GETDATA(GETVALUE);

			DialogResult dr = frmctsach.ShowDialog();
			if (dr == DialogResult.Cancel)
			{
				frmctsach.Close();
			}
		}
		private void btnMuonSach_Click(object sender, EventArgs e)
		{
			bool check = true;
			Random rd = new Random();
			int x = rd.Next(0, 20);
			if (x < 10)
				txtphieumuon.Text = "P0" + x.ToString();
			if (x > 10)
				txtphieumuon.Text = "P" + x.ToString();
			foreach (string str in lstPM)
			{
				if (str.Contains(txtphieumuon.Text))
				{
					check = false;
					break;
				}
				check = true;
			}
			if(check == true)
			{
				ListViewItem liv = new ListViewItem(txtmasach.Text);
				liv.SubItems.Add(txttensach.Text);
				liv.SubItems.Add(txtphieumuon.Text);
				liv.SubItems.Add(arrMA[1]);
				liv.SubItems.Add(arrMA[0]);
				liv.SubItems.Add(dtngaymuon.Value.ToString("dd/MM/yyyy"));

				lvMuonSach.Items.Add(liv);


				var result = MessageBox.Show("Bạn có muốn lưu ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
 				if (result == DialogResult.Yes)
				{
 					ThemPM();
				}
				 
			}
		}
		string[] arrMA = new string[2];
		private void cbmasv_SelectedIndexChanged(object sender, EventArgs e)
		{
			string valueSV = cbmasv.SelectedItem.ToString();
			string[] arrSV = valueSV.Split('-');
			arrMA[0] = arrSV[0];
		}
		private void cbmanv_SelectedIndexChanged(object sender, EventArgs e)
		{
			string valueNV = cbmanv.SelectedItem.ToString();
			string[] arrNV = valueNV.Split('-');
			arrMA[1] = arrNV[0];
		}

		#endregion

		#endregion

		#region Phiếu Trả
		string masv = "";
		public void ShowPhieuTra()
		{
			connect.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from MUONTRA";
			cmd.Connection = connect.conn;

			SqlDataReader reader = cmd.ExecuteReader();
			lvTraSach.Items.Clear();
			while (reader.Read())
			{
				ListViewItem listview = new ListViewItem();
				listview.SubItems.Add(reader.GetString(0));
				listview.SubItems.Add(reader.GetString(5));
				listview.SubItems.Add(reader.GetString(1));
				listview.SubItems.Add(reader.GetDateTime(2).ToString("dd/MM/yyyy"));
				listview.SubItems.Add(reader.GetDateTime(3).ToString("dd/MM/yyyy"));
				listview.SubItems.Add(reader.GetDouble(4).ToString());

 				lvTraSach.Items.Add(listview);
			}
			reader.Close();
		}
		public void TraSach()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "TraSach";
			cmd.Connection = connect.conn;
			connect.OpenConnection();
			cmd.Parameters.Add("@MAPM", SqlDbType.NVarChar).Value = txtmapm.Text;
			cmd.Parameters.Add("@MASACH", SqlDbType.NVarChar).Value = txtmasacht.Text;
			cmd.Parameters.Add("@NGAYMUON", SqlDbType.Date).Value = dtmuon.Value;
			cmd.Parameters.Add("@NGAYTRA", SqlDbType.Date).Value = dttra.Value;
			cmd.Parameters.Add("@TIENPHAT", SqlDbType.Float).Value = double.Parse(txttienphat.Text);
			cmd.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = masv;
			cmd.ExecuteNonQuery();
			connect.CloseConnection();
		}
		public void XoaPM()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "XoaPM";
			cmd.Connection = connect.conn;
			connect.OpenConnection();
			cmd.Parameters.Add("@MAPM", SqlDbType.NVarChar).Value = txtmapm.Text;
			cmd.ExecuteNonQuery();
			connect.CloseConnection();
		}
		#endregion


	}
}
