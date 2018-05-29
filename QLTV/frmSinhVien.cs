using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTV
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
            btnTimKiemSV.ForeColor = Color.LightGray;
            btnTimKiemSV.Text = "Tìm kiếm";
            this.btnTimKiemSV.Leave += new System.EventHandler(this.btnTimKiemSV_Leave);
            this.btnTimKiemSV.Enter += new System.EventHandler(this.btnTimKiemSV_Enter);

            cbbtk.ForeColor = Color.LightGray;
            cbbtk.Text = "Tìm kiếm theo";
            this.cbbtk.Leave += new System.EventHandler(this.cbbTK_Leave);
            this.cbbtk.Enter += new System.EventHandler(this.cbbTK_Enter);
        }
        DataConnections dt = new DataConnections();
        bool check = true;
        List<string> LstMaSV = new List<string>();
        //Sinhvien
        #region ShowDataSV
        public void ShowDataSV()
        {
            btnThemSV.Enabled = true;
            btnRs.Enabled = true;
            btnSuaSV.Enabled = false;
            btnXoaSV.Enabled = false;
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SINHVIEN";
            cmd.Connection = dt.conn;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string MaSV = reader.GetString(0);
                ListViewItem Liv = new ListViewItem(reader.GetString(0));
                Liv.SubItems.Add(reader.GetString(1));
                Liv.SubItems.Add(reader.GetString(2));
                Liv.SubItems.Add(reader.GetDateTime(3).ToString());
                Liv.SubItems.Add(reader.GetString(4));
                Liv.SubItems.Add(reader.GetString(5));

                LstMaSV.Add(MaSV);
                lvSV.Items.Add(Liv);
            }
            reader.Close();
        }
        #endregion

        #region Controler

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if (txbMaSV.Text != "")
            {
                bool check = true;
                foreach (string us in LstMaSV)
                {
                    if (us.Contains(txbMaSV.Text))
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại");
                        check = false;
                        break;
                    }
                    check = true;
                }
                if (check == true)
                {
                    ListViewItem liv = new ListViewItem(txbMaSV.Text);
                    liv.SubItems.Add(txbhoten.Text);
                    if (rdbnam.Checked == true)
                    {
                        liv.SubItems.Add(rdbnam.Text);
                    }
                    else
                    {
                        liv.SubItems.Add(rdbnu.Text);
                    }
                    liv.SubItems.Add(dtngaysinh.Text);
                    liv.SubItems.Add(txbdienthoai.Text);
                    liv.SubItems.Add(txblop.Text);

                    lvSV.Items.Add(liv);

                    AddSVToDatabase();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã sinh viên", "Thông báo");
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            btnThemSV.Enabled = false;
            if (lvSV.SelectedItems.Count == 0) return;
            ListViewItem liv = lvSV.SelectedItems[0];
            liv.SubItems[0].Text = txbMaSV.Text;
            liv.SubItems[1].Text = txbhoten.Text;
            if (rdbnam.Checked == true)
            {
                liv.SubItems[2].Text = rdbnam.Text;
            }
            else
            {
                liv.SubItems[2].Text = rdbnu.Text;
            }
            liv.SubItems[4].Text = txbdienthoai.Text;
            liv.SubItems[5].Text = txblop.Text;

            EditSVToDatabase();
            MessageBox.Show("Sửa thành công");
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (lvSV.SelectedItems != null)
            {
                for (int i = 0; i < lvSV.Items.Count; i++)
                {
                    if (lvSV.Items[i].Selected)
                    {
                        lvSV.Items[i].Remove();
                        i--;
                    }
                }
            }
            DeleteSV_Database();
            MessageBox.Show("Đã xóa sinh viên");
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            btnThemSV.Enabled = true;
            btnSuaSV.Enabled = false;
            btnXoaSV.Enabled = false;
            txbMaSV.Enabled = true;
            rdbnam.Checked = false;
            rdbnu.Checked = false;
            txbMaSV.ResetText();
            txbhoten.ResetText();
            dtngaysinh.ResetText();
            txbdienthoai.ResetText();
            txblop.ResetText();
            btnTimKiemSV.ResetText();
        }
        #endregion
        #region Database
        public void AddSVToDatabase()
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn thêm sinh viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    dt.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ThemSV";
                    cmd.Connection = dt.conn;

                    cmd.Parameters.Add("@MASV", SqlDbType.VarChar).Value = txbMaSV.Text;
                    cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = txbhoten.Text;
                    if (rdbnam.Checked == true)
                    {
                        cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = rdbnam.Text;
                    }
                    else
                    {
                        cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = rdbnu.Text;
                    }
                    cmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = Convert.ToDateTime(dtngaysinh.Value);
                    cmd.Parameters.Add("@DIENTHOAI", SqlDbType.VarChar).Value = txbdienthoai.Text;
                    cmd.Parameters.Add("@LOP", SqlDbType.NVarChar).Value = txblop.Text;


                    int ret = cmd.ExecuteNonQuery();
                    lvSV.Items.Clear();
                    if (ret > 0)
                        ShowDataSV();
                    MessageBox.Show("Đã thêm sinh viên thành công", "Thêm");
                    rdbnam.Checked = false;
                    rdbnu.Checked = false;
                    txbMaSV.ResetText();
                    txbhoten.ResetText();
                    txbdienthoai.ResetText();
                    dtngaysinh.ResetText();
                }
                else
                {
                    lvSV.Items.Clear();
                    ShowDataSV();
                }
            }
            catch { }
        }
        public void EditSVToDatabase()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn sửa sinh viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaSV";
                cmd.Connection = dt.conn;

                cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = txbMaSV.Text;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = txbhoten.Text;
                if (rdbnam.Checked == true)
                {
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = rdbnam.Text;
                }
                else
                {
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = rdbnu.Text;
                }
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtngaysinh.Value;
                cmd.Parameters.Add("@DIENTHOAI", SqlDbType.NVarChar).Value = txbdienthoai.Text;
                cmd.Parameters.Add("@Lop", SqlDbType.NVarChar).Value = txblop.Text;
                int ret = cmd.ExecuteNonQuery();
                lvSV.Items.Clear();
                if (ret > 0)
                    ShowDataSV();
                MessageBox.Show("Đã sửa thành công", "Sửa");
                txbMaSV.Enabled = true;
                rdbnam.Checked = false;
                rdbnu.Checked = false;
                txbMaSV.ResetText();
                txbhoten.ResetText();
                txbdienthoai.ResetText();
                dtngaysinh.ResetText();
            }
            else
            {
                lvSV.Items.Clear();
                ShowDataSV();
            }
        }
        public void DeleteSV_Database()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa sinh viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaSV";
                cmd.Connection = dt.conn;

                cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = txbMaSV.Text;

                int ret = cmd.ExecuteNonQuery();
                lvSV.Items.Clear();
                if (ret > 0)
                    ShowDataSV();
                MessageBox.Show("Đã xóa thành công !", "Xóa");
                btnThemSV.Enabled = true;
                txbMaSV.Enabled = true;
                rdbnam.Checked = false;
                rdbnu.Checked = false;
                txbMaSV.ResetText();
                txbhoten.ResetText();
                txbdienthoai.ResetText();
                dtngaysinh.ResetText();
            }
            else
            {
                btnThemSV.Enabled = true;
                txbMaSV.Enabled = true;
                rdbnam.Checked = false;
                rdbnu.Checked = false;
                txbMaSV.ResetText();
                txbhoten.ResetText();
                txbdienthoai.ResetText();
                dtngaysinh.ResetText();
                lvSV.Items.Clear();
                ShowDataSV();
            }
        }
        #endregion
        #region Tim_kiem
        private void btnTimKiemSV_Leave(object sender, EventArgs e)
        {
            if (btnTimKiemSV.Text == "")
            {
                btnTimKiemSV.Text = "Tìm kiếm";
                btnTimKiemSV.ForeColor = Color.Gray;
            }
        }

        private void btnTimKiemSV_Enter(object sender, EventArgs e)
        {
            if (btnTimKiemSV.Text == "Tìm kiếm")
            {
                btnTimKiemSV.Text = "";
                btnTimKiemSV.ForeColor = Color.Black;
            }
        }

        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            if (cbbtk.SelectedIndex == 0)
            {
                string str = btnTimKiemSV.Text;
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from SINHVIEN Where MASV like '%" + str + "%'";
                cmd.Connection = dt.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvSV.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    lv.SubItems.Add(reader.GetString(3));
                    lv.SubItems.Add(reader.GetString(4));
                    lv.SubItems.Add(reader.GetDateTime(5).ToString());
                    lvSV.Items.Add(lv);
                }
                reader.Close();
            }
            else if (cbbtk.SelectedIndex == 1)
            {
                string str = btnTimKiemSV.Text;
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from SINHVIEN Where HOTEN like N'%" + str + "%'";
                cmd.Connection = dt.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvSV.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    lv.SubItems.Add(reader.GetString(3));
                    lv.SubItems.Add(reader.GetString(4));
                    lv.SubItems.Add(reader.GetDateTime(5).ToString());
                    lvSV.Items.Add(lv);
                }
                reader.Close();
            }
            else if (cbbtk.SelectedIndex == 2)
            {
                string str = btnTimKiemSV.Text;
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from SINHVIEN Where NGAYSINH like N'%" + str + "%'";
                cmd.Connection = dt.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvSV.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    lv.SubItems.Add(reader.GetString(3));
                    lv.SubItems.Add(reader.GetString(4));
                    lv.SubItems.Add(reader.GetDateTime(5).ToString());
                    lvSV.Items.Add(lv);
                }
                reader.Close();
            }
            else if (cbbtk.SelectedIndex == 3)
            {
                string str = btnTimKiemSV.Text;
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from SIENVIEN Where DIENTHOAI like N'%" + str + "%'";
                cmd.Connection = dt.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvSV.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    lv.SubItems.Add(reader.GetString(3));
                    lv.SubItems.Add(reader.GetString(4));
                    lv.SubItems.Add(reader.GetDateTime(5).ToString());
                    lvSV.Items.Add(lv);
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
            if (cbbtk.Text == "Tìm kiếm theo")
            {
                cbbtk.Text = "";
                cbbtk.ForeColor = Color.Black;
            }
        }

        private void cbbTK_Leave(object sender, EventArgs e)
        {
            if (cbbtk.Text == "")
            {
                cbbtk.Text = "Tìm kiếm theo";
                cbbtk.ForeColor = Color.Gray;
            }
        }
        #endregion

        private void lvSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbMaSV.Enabled = false;
            btnThemSV.Enabled = false;
            btnSuaSV.Enabled = true;
            btnXoaSV.Enabled = true;
            if (lvSV.SelectedItems.Count == 0) return;
            ListViewItem listview = lvSV.SelectedItems[0];
            txbMaSV.Text = listview.SubItems[0].Text;
            txbhoten.Text = listview.SubItems[1].Text;
            if (rdbnam.Text.ToLower() == listview.SubItems[2].Text.ToLower())
            {
                rdbnam.Checked = true;
                rdbnu.Checked = false;
            }
            else
            {
                rdbnu.Checked = true;
                rdbnam.Checked = false;
            }
            dtngaysinh.Text = listview.SubItems[3].Text;
            txbdienthoai.Text = listview.SubItems[4].Text;
            txblop.Text = listview.SubItems[5].Text;
        }
        private void frmSV_Load(object sender, EventArgs e)
        {
            ShowDataSV();
        }
    }
}
