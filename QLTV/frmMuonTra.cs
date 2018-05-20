﻿using System;
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
		}
		public static string ma = string.Empty;
		private void frmMuonTra_Load(object sender, EventArgs e)
		{
			ShowMaSV();
			ShowMaNV();
			ShowData();
		}

		#region ShowData
		DataConnections connect = new DataConnections();
		List<string> lstPM = new List<string>();
		public void ShowData()
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
				ListViewItem listview = new ListViewItem();
				listview.SubItems.Add(reader.GetString(4));
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

		
	}
}
