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
    public partial class frmViTri : Form
    {
        public frmViTri()
        {
            InitializeComponent();
            txtTimKiem.ForeColor = Color.LightGray;
            txtTimKiem.Text = "Tìm kiếm";
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);

            cbbTimKiem.ForeColor = Color.LightGray;
            cbbTimKiem.Text = "Tìm kiếm theo";
            this.cbbTimKiem.Leave += new System.EventHandler(this.cbbTimKiem_Leave);
            this.cbbTimKiem.Enter += new System.EventHandler(this.cbbTimKiem_Enter);
        }

        private void frmViTri_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        DataConnections con = new DataConnections();
        List<string> lst = new List<string>();
        void ShowData()
        {
            btnSuaVT.Enabled = false;
            btnXoaVT.Enabled = false;
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from VITRISACH";
            cmd.Connection = con.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem listview = new ListViewItem(reader.GetString(0));
                listview.SubItems.Add(reader.GetString(1));
                listview.SubItems.Add(reader.GetString(2));
                lst.Add(reader.GetString(0));
                lvVT.Items.Add(listview);
            }
            reader.Close();
        }

        private void lvVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaVT.Enabled = false;
            btnThemVT.Enabled = false;
            btnSuaVT.Enabled = true;
            btnXoaVT.Enabled = true;
            if (lvVT.SelectedItems.Count == 0) return;
            ListViewItem listview = lvVT.SelectedItems[0];
            txtMaVT.Text = listview.SubItems[0].Text;
            txtViTri.Text = listview.SubItems[1].Text;
            txtTenKe.Text = listview.SubItems[2].Text;
            
        }

        #region Database
        private void ThemVT()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemVT";
                cmd.Connection = con.conn;
                cmd.Parameters.Add("@MAVT", SqlDbType.VarChar).Value = txtMaVT.Text;
                cmd.Parameters.Add("@VITRI", SqlDbType.NVarChar).Value = txtViTri.Text;
                cmd.Parameters.Add("@TENKE", SqlDbType.NVarChar).Value = txtTenKe.Text;
                int ret = cmd.ExecuteNonQuery();
                lvVT.Items.Clear();
                if (ret > 0)
                    ShowData();

                MessageBox.Show("Đã thêm thành công", "Thêm");
            }
            else
            {
                lvVT.Items.Clear();
                ShowData();
            }
        }
        private void SuaVT()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaVT";
                cmd.Connection = con.conn;
                cmd.Parameters.Add("@MAVT", SqlDbType.VarChar).Value = txtMaVT.Text;
                cmd.Parameters.Add("@VITRI", SqlDbType.NVarChar).Value = txtViTri.Text;
                cmd.Parameters.Add("@TENKE", SqlDbType.NVarChar).Value = txtTenKe.Text;
                int ret = cmd.ExecuteNonQuery();
                lvVT.Items.Clear();
                if (ret > 0)
                    ShowData();
                MessageBox.Show("Đã sửa thành công", "Sửa");
            }
            else
            {
                lvVT.Items.Clear();
                ShowData();
            }

        }
        public void XoaVT()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xoá ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaVT";
                cmd.Connection = con.conn;

                cmd.Parameters.Add("@MAVT", SqlDbType.VarChar).Value = txtMaVT.Text;
                int ret = cmd.ExecuteNonQuery();
                lvVT.Items.Clear();
                if (ret > 0)
                    ShowData();
                MessageBox.Show("Đã xóa thành công", "Xóa");
                btnThemVT.Enabled = true;
                btnSuaVT.Enabled = false;
                btnXoaVT.Enabled = false;
                txtMaVT.Enabled = true;
                txtMaVT.ResetText();
                txtTenKe.ResetText();
                txtViTri.ResetText();
              
            }
            else
            {
                btnThemVT.Enabled = true;
                btnSuaVT.Enabled = false;
                btnXoaVT.Enabled = false;
                txtMaVT.Enabled = true;
                txtMaVT.ResetText();
                txtTenKe.ResetText();
                txtViTri.ResetText();
                lvVT.Items.Clear();
                ShowData();
            }
        }



        #endregion
        #region Button
        private void btnThemVT_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (txtMaVT.Text != "")
            {
                foreach (string us in lst)
                {
                    if (us.Contains(txtMaVT.Text) && txtMaVT.Text.Contains(us))
                    {
                        MessageBox.Show("Mã Vị Trí đã tồn tại!", "Thông báo");
                        check = false;
                        break;
                    }
                    check = true;
                }
                if (check == true)
                {
                    ListViewItem listview = new ListViewItem(txtMaVT.Text);
                    listview.SubItems.Add(txtMaVT.Text);
                    listview.SubItems.Add(txtViTri.Text);
                    listview.SubItems.Add(txtTenKe.Text);
                    lvVT.Items.Add(listview);
                    ThemVT();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã vị trí!", "Thông báo");
            }
        }

        private void btnSuaVT_Click(object sender, EventArgs e)
        {
            btnThemVT.Enabled = true;
            if (lvVT.SelectedItems.Count == 0) return;
            ListViewItem lv = lvVT.SelectedItems[0];
            lv.SubItems[0].Text = txtMaVT.Text;
            lv.SubItems[1].Text = txtViTri.Text;
            lv.SubItems[2].Text = txtTenKe.Text;
            SuaVT();
        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            if (lvVT.SelectedItems != null)
            {
                for (int i = 0; i < lvVT.Items.Count; i++)
                {
                    if (lvVT.Items[i].Selected)
                    {
                        lvVT.Items[i].Remove();
                        i--;
                    }
                }
            }
            XoaVT();
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            btnThemVT.Enabled = true;
            btnSuaVT.Enabled = false;
            btnXoaVT.Enabled = false;
            txtMaVT.Enabled = true;
            txtMaVT.ResetText();
            txtTenKe.ResetText();
            txtViTri.ResetText();            
            lvVT.Items.Clear();
            ShowData();
        }



        #endregion

        #region TimKiem

        private void btnTimKiemVT_Click(object sender, EventArgs e)
        {
            if (cbbTimKiem.SelectedIndex == 0)
            {
                string str = txtTimKiem.Text;
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from VITRISACH Where MAVT like '%" + str + "%'";
                cmd.Connection = con.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvVT.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    
                    lvVT.Items.Add(lv);
                }
                reader.Close();
            }
            else if (cbbTimKiem.SelectedIndex == 2)
            {
                string str = txtTimKiem.Text;
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from VITRISACH Where VITRI like N'%" + str + "%'";
                cmd.Connection = con.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvVT.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    lvVT.Items.Add(lv);
                }
                reader.Close();
            }
            else if (cbbTimKiem.SelectedIndex == 1)
            {
                string str = txtTimKiem.Text;
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from VITRISACH Where TENKE like N'%" + str + "%'";
                cmd.Connection = con.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvVT.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    lvVT.Items.Add(lv);
                }
                reader.Close();
            }
            
            else
            {
                MessageBox.Show("Yêu cầu chọn trường tìm kiếm");
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void cbbTimKiem_Enter(object sender, EventArgs e)
        {
            if (cbbTimKiem.Text == "Tìm kiếm theo")
            {
                cbbTimKiem.Text = "";
                cbbTimKiem.ForeColor = Color.Black;
            }
        }

        private void cbbTimKiem_Leave(object sender, EventArgs e)
        {
            if (cbbTimKiem.Text == "")
            {
                cbbTimKiem.Text = "Tìm kiếm theo";
                cbbTimKiem.ForeColor = Color.Gray;
            }
        }
        #endregion
    }
}
