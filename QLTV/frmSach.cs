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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
            txtTimKiem.ForeColor = Color.LightGray;
            txtTimKiem.Text = "Tìm kiếm";
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);

            cbbTK.ForeColor = Color.LightGray;
            cbbTK.Text = "Tìm kiếm theo";
            this.cbbTK.Leave += new System.EventHandler(this.cbbTK_Leave);
            this.cbbTK.Enter += new System.EventHandler(this.cbbTK_Enter);
        }
        DataConnections connect = new DataConnections();
        List<string> list = new List<string>();
        #region loadData
        public void ShowSach()
        {
            btnSuaSach.Enabled = false;
            btnXoaSach.Enabled = false;
            connect.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SACH";
            cmd.Connection = connect.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem listview = new ListViewItem(reader.GetString(0));
                listview.SubItems.Add(reader.GetString(1));
                listview.SubItems.Add(reader.GetString(2));
                listview.SubItems.Add(reader.GetString(3));
                listview.SubItems.Add(reader.GetString(4));
                listview.SubItems.Add(reader.GetString(5));
                listview.SubItems.Add(reader.GetDateTime(6).ToString());
                listview.SubItems.Add(reader.GetInt32(7).ToString());
                list.Add(reader.GetString(0));
                lvSach.Items.Add(listview);
            }
            reader.Close();
        }
        public void ShowMaVT()
        {
            connect.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from VITRISACH";
            cmd.Connection = connect.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            cbbMVT.Items.Clear();
            while (reader.Read())
            {
                string MaVT = reader.GetString(0);
                cbbMVT.Items.Add(MaVT);
            }
            reader.Close();
        }
        private void frmSach_Load(object sender, EventArgs e)
        {
            ShowSach();
            ShowMaVT();
        }
        #endregion

        #region event_click_listview
        private void lvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbMS.Enabled = false;
            btnThemSach.Enabled = false;
            btnSuaSach.Enabled = true;
            btnXoaSach.Enabled = true;
            if (lvSach.SelectedItems.Count == 0) return;
            ListViewItem listview = lvSach.SelectedItems[0];
            txbMS.Text = listview.SubItems[0].Text;
            txbTS.Text = listview.SubItems[1].Text;
            txbTG.Text = listview.SubItems[2].Text;
            txbTL.Text = listview.SubItems[3].Text;
            cbbMVT.Text = listview.SubItems[4].Text;
            txbNXB.Text = listview.SubItems[5].Text;
            dtNamxb.Text = listview.SubItems[6].Text;
            txbSoLuong.Text = listview.SubItems[7].Text;
        }
        #endregion

        #region database
        private void ThemSach()
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                connect.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemSach";
                cmd.Connection = connect.conn;
                cmd.Parameters.Add("@MASACH", SqlDbType.VarChar).Value = txbMS.Text;
                cmd.Parameters.Add("@TENSACH", SqlDbType.NVarChar).Value = txbTS.Text;
                cmd.Parameters.Add("@TACGIA", SqlDbType.NVarChar).Value = txbTG.Text;
                cmd.Parameters.Add("@THELOAI", SqlDbType.NVarChar).Value = txbTL.Text;
                cmd.Parameters.Add("@MAVT", SqlDbType.NVarChar).Value = cbbMVT.Text;
                cmd.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = txbNXB.Text;
                cmd.Parameters.Add("@NAMXB", SqlDbType.Date).Value = dtNamxb.Text;
                if(txbSoLuong.Text == "")
                {
                    cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = 0;
                }
                else
                {
                    cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = txbSoLuong.Text;
                }
               
                int ret = cmd.ExecuteNonQuery();
                lvSach.Items.Clear();
                if (ret > 0)
                    ShowSach();

                MessageBox.Show("Đã thêm thành công", "Thêm");
            }
            else
            {
                lvSach.Items.Clear();
                ShowSach();
            }
        }
        private void SuaSach()
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                connect.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaSach";
                cmd.Connection = connect.conn;
                cmd.Parameters.Add("@MASACH", SqlDbType.VarChar).Value = txbMS.Text;
                cmd.Parameters.Add("@TENSACH", SqlDbType.NVarChar).Value = txbTS.Text;
                cmd.Parameters.Add("@TACGIA", SqlDbType.NVarChar).Value = txbTG.Text;
                cmd.Parameters.Add("@THELOAI", SqlDbType.NVarChar).Value = txbTL.Text;
                cmd.Parameters.Add("@MAVT", SqlDbType.NVarChar).Value = cbbMVT.Text;
                cmd.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = txbNXB.Text;
                cmd.Parameters.Add("@NAMXB", SqlDbType.Date).Value = dtNamxb.Text;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = txbSoLuong.Text;

                int ret = cmd.ExecuteNonQuery();
                lvSach.Items.Clear();
                if (ret > 0)
                    ShowSach();
                MessageBox.Show("Đã sửa thành công", "Sửa");
            }
            else
            {
                lvSach.Items.Clear();
                ShowSach();
            }

        }
        public void XoaSach()
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                connect.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaSach";
                cmd.Connection = connect.conn;

                cmd.Parameters.Add("@MASACH", SqlDbType.VarChar).Value = txbMS.Text;
                int ret = cmd.ExecuteNonQuery();
                lvSach.Items.Clear();
                if (ret > 0)
                    ShowSach();
                MessageBox.Show("Đã xóa thành công", "Xóa");
                btnThemSach.Enabled = true;
                btnSuaSach.Enabled = false;
                btnXoaSach.Enabled = false;
                txbMS.Enabled = true;
                txbMS.ResetText();
                txbTS.ResetText();
                txbTG.ResetText();
                txbTL.ResetText();
                txbNXB.ResetText();
                cbbMVT.ResetText();
                txbSoLuong.ResetText();
            }
            else
            {
                btnThemSach.Enabled = true;
                btnSuaSach.Enabled = false;
                btnXoaSach.Enabled = false;
                txbMS.Enabled = true;
                txbMS.ResetText();
                txbTS.ResetText();
                txbTG.ResetText();
                txbTL.ResetText();
                txbNXB.ResetText();
                cbbMVT.ResetText();
                txbSoLuong.ResetText();
                lvSach.Items.Clear();
                ShowSach();
            }
        }


        #endregion

        #region event_button_click
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (txbMS.Text != "" && cbbMVT.Text != "")
            {
                foreach (string us in list)
                {
                    if (us.Contains(txbMS.Text) && txbMS.Text.Contains(us))
                    {
                        MessageBox.Show("Mã sách đã tồn tại!", "Thông báo");
                        check = false;
                        break;
                    }
                    check = true;
                }
                if (check == true)
                {
                    ListViewItem listview = new ListViewItem(txbMS.Text);
                    listview.SubItems.Add(txbTS.Text);
                    listview.SubItems.Add(txbTG.Text);
                    listview.SubItems.Add(txbTL.Text);
                    listview.SubItems.Add(cbbMVT.Text);
                    listview.SubItems.Add(txbNXB.Text);
                    listview.SubItems.Add(dtNamxb.Text);
                    listview.SubItems.Add(txbSoLuong.Text);
                    lvSach.Items.Add(listview);
                    ThemSach();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã sách hoặc mã vị trí!", "Thông báo");
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            btnThemSach.Enabled = true;
            if (lvSach.SelectedItems.Count == 0) return;
            ListViewItem lv = lvSach.SelectedItems[0];
            lv.SubItems[0].Text = txbMS.Text;
            lv.SubItems[1].Text = txbTS.Text;
            lv.SubItems[2].Text = txbTG.Text;
            lv.SubItems[3].Text = txbTL.Text;
            lv.SubItems[4].Text = cbbMVT.Text;
            lv.SubItems[5].Text = txbNXB.Text;
            lv.SubItems[6].Text = dtNamxb.Text;
            lv.SubItems[7].Text = txbSoLuong.Text;
            SuaSach();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (lvSach.SelectedItems != null)
            {
                for (int i = 0; i < lvSach.Items.Count; i++)
                {
                    if (lvSach.Items[i].Selected)
                    {
                        lvSach.Items[i].Remove();
                        i--;
                    }
                }
            }
            XoaSach();
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            btnThemSach.Enabled = true;
            btnSuaSach.Enabled = false;
            btnXoaSach.Enabled = false;
            txbMS.Enabled = true;
            txbMS.ResetText();
            txbTS.ResetText();
            txbTG.ResetText();
            txbTL.ResetText();
            txbNXB.ResetText();
            cbbMVT.ResetText();
            txbSoLuong.ResetText();
            lvSach.Items.Clear();
            ShowSach();
        }
        #endregion

        #region Tim_Kiem
        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm";
                txtTimKiem.ForeColor = Color.Gray;
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
        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            if (cbbTK.SelectedIndex == 0)
            {
                string str = txtTimKiem.Text;
                connect.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from SACH Where MASACH like '%" + str + "%'";
                cmd.Connection = connect.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvSach.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    lv.SubItems.Add(reader.GetString(3));
                    lv.SubItems.Add(reader.GetString(4));
                    lv.SubItems.Add(reader.GetString(5));
                    lv.SubItems.Add(reader.GetDateTime(6).ToString());
                    lv.SubItems.Add(reader.GetInt32(7).ToString());
                    lvSach.Items.Add(lv);
                }
                reader.Close();
            }
            else if(cbbTK.SelectedIndex == 1)
            {
                string str = txtTimKiem.Text;
                connect.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from SACH Where TENSACH like N'%" + str + "%'";
                cmd.Connection = connect.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvSach.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    lv.SubItems.Add(reader.GetString(3));
                    lv.SubItems.Add(reader.GetString(4));
                    lv.SubItems.Add(reader.GetString(5));
                    lv.SubItems.Add(reader.GetDateTime(6).ToString());
                    lv.SubItems.Add(reader.GetInt32(7).ToString());
                    lvSach.Items.Add(lv);
                }
                reader.Close();
            }
            else if (cbbTK.SelectedIndex == 2)
            {
                string str = txtTimKiem.Text;
                connect.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from SACH Where TACGIA like N'%" + str + "%'";
                cmd.Connection = connect.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvSach.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    lv.SubItems.Add(reader.GetString(3));
                    lv.SubItems.Add(reader.GetString(4));
                    lv.SubItems.Add(reader.GetString(5));
                    lv.SubItems.Add(reader.GetDateTime(6).ToString());
                    lv.SubItems.Add(reader.GetInt32(7).ToString());
                    lvSach.Items.Add(lv);
                }
                reader.Close();
            }
            else if (cbbTK.SelectedIndex == 3)
            {
                string str = txtTimKiem.Text;
                connect.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from SACH Where THELOAI like N'%" + str + "%'";
                cmd.Connection = connect.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvSach.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    lv.SubItems.Add(reader.GetString(3));
                    lv.SubItems.Add(reader.GetString(4));
                    lv.SubItems.Add(reader.GetString(5));
                    lv.SubItems.Add(reader.GetDateTime(6).ToString());
                    lv.SubItems.Add(reader.GetInt32(7).ToString());
                    lvSach.Items.Add(lv);
                }
                reader.Close();
            }
            else if (cbbTK.SelectedIndex == 4)
            {
                string str = txtTimKiem.Text;
                connect.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from SACH Where NXB like N'%" + str + "%'";
                cmd.Connection = connect.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvSach.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    lv.SubItems.Add(reader.GetString(3));
                    lv.SubItems.Add(reader.GetString(4));
                    lv.SubItems.Add(reader.GetString(5));
                    lv.SubItems.Add(reader.GetDateTime(6).ToString());
                    lv.SubItems.Add(reader.GetInt32(7).ToString());
                    lvSach.Items.Add(lv);
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("Yêu cầu chọn trường tìm kiếm");
            }
        }

        private void cbbTK_Enter(object sender, EventArgs e)
        {
            if (cbbTK.Text == "Tìm kiếm theo")
            {
                cbbTK.Text = "";
                cbbTK.ForeColor = Color.Black;
            }
        }

        private void cbbTK_Leave(object sender, EventArgs e)
        {
            if (cbbTK.Text == "")
            {
                cbbTK.Text = "Tìm kiếm theo";
                cbbTK.ForeColor = Color.Gray;
            }
        }
        #endregion
    }
}
