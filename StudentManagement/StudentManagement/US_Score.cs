using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagement
{
    public partial class US_Score : UserControl
    {
        public US_Score()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ASUS-AS;Initial Catalog=D:\studentmanagement\quanlyhocsinh.mdf;Integrated Security=True");

        // bắt đầu viết hàm kết nối tới csdl
        private void KetNoiCSDL()
        {
            try
            {
                //mở kết nối trước:
                conn.Open();
                //tạo chuỗi kết nối:
                string sql = "SELECT *FROM DiemThi";//lấy hết dữ liệu trong bảng hocsinh
                SqlCommand cmd = new SqlCommand(sql, conn);// bắt đầu truy vấn bằng câu lệnh
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                // tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt); //đổ dữ liệu vào kho
                             //đóng kết nối
                conn.Close();
                //ta đổ dữ liệu vào trong gridDataView
                dataQLD.DataSource = dt;
                this.dataQLD.RowsDefaultCellStyle.BackColor = Color.Bisque;
                this.dataQLD.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối, vui lòng kiểm tra lại");
            }

            finally
            {
                SqlConnection conn = new SqlConnection(@"Data Source=ASUS-AS;Initial Catalog=D:\studentmanagement\quanlyhocsinh.mdf;Integrated Security=True");
                conn.Close(); //đóng kết nối lại

            }
        }


        public void HienThi()
        {
            string sqlSELECT = "SELECT *FROM DiemThi";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataQLD.DataSource = dt;

        }

        public SqlConnection cn = new SqlConnection();
        public void Ketnoi()
        {
            try
            {
                if (cn.State == 0)
                {
                    cn.ConnectionString = @"Data Source=ASUS-AS;Initial Catalog=D:\studentmanagement\quanlyhocsinh.mdf;Integrated Security=True";
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Ngatketnoi()
        {
            if (cn.State != 0)
            {
                cn.Close();
            }
        }

        public DataTable XemDL(string sql)
        {
            Ketnoi();

            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;

            //Ngatketnoi();
        }


        private void US_Score_Load(object sender, EventArgs e)
        {
            cbbSearch.Text = "Mã học sinh";
            KetNoiCSDL();
            loadData();
            loadTenMon();
            loadHocKy();
            loadNamHoc();
      
        }



        public void loadTenMon()
        {
            KetnoiDatabase kn = new KetnoiDatabase();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = kn.kn;
            mysqlcommand.CommandText = "select monhoc from DiemThi";
            kn.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbbMonHoc.DataSource = table_MK;
            cbbMonHoc.DisplayMember = table_MK.Columns["monhoc"].ToString();



            kn.kn.Close();

        }

    
        public void loadHocKy()
        {
            KetnoiDatabase kn = new KetnoiDatabase();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = kn.kn;
            mysqlcommand.CommandText = "select hocky from DiemThi";
            kn.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbbHocKy.DataSource = table_MK;
            cbbHocKy.DisplayMember = table_MK.Columns["hocky"].ToString();
            kn.kn.Close();

        }

        public void loadNamHoc()
        {
            KetnoiDatabase kn = new KetnoiDatabase();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = kn.kn;
            mysqlcommand.CommandText = "select namhoc from DiemThi";
            kn.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbbNamHoc.DataSource = table_MK;
            cbbNamHoc.DisplayMember = table_MK.Columns["namhoc"].ToString();
            kn.kn.Close();

        }

        public static void clearTxt(Control ctrl)
        {
            if (ctrl is TextBox)
            {
                ctrl.Text = string.Empty;
            }
            foreach (Control i in ctrl.Controls)
            {
                clearTxt(i);
            }
        }
        private void loadData()
        {
            txtMaHS.DataBindings.Clear();//xóa dữ liệu trong textbox
            txtMaHS.DataBindings.Add("Text", dataQLD.DataSource, "mahocsinh");
            txtTenHS.DataBindings.Clear();//xóa dữ liệu trong textbox
            txtTenHS.DataBindings.Add("Text", dataQLD.DataSource, "ten");
            cbbMonHoc.DataBindings.Clear();//xóa dữ liệu trong textbox
            cbbMonHoc.DataBindings.Add("Text", dataQLD.DataSource, "monhoc");
            cbbHocKy.DataBindings.Clear();
            cbbHocKy.DataBindings.Add("Text", dataQLD.DataSource, "hocky");
            cbbNamHoc.DataBindings.Clear();
            cbbNamHoc.DataBindings.Add("Text", dataQLD.DataSource, "namhoc");
            txtDiemSo.DataBindings.Clear();//xóa dữ liệu trong textbox
            txtDiemSo.DataBindings.Add("Text", dataQLD.DataSource, "diem");

        }

        private void dataQLD_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataQLD.CurrentRow.Selected = true; // dữ liệu đc chọn cả dòng
            }

            catch
            {
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult thongBao;
            thongBao = MessageBox.Show("Are You Sure?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (thongBao == DialogResult.Yes)
            {
                try
                {
                    string sqlEdit = "UPDATE DiemThi SET diem = @diem WHERE mahocsinh = @mahocsinh";
                    SqlCommand cmd = new SqlCommand(sqlEdit, conn);
                    cmd.Parameters.AddWithValue("mahocsinh", txtMaHS.Text);
                    cmd.Parameters.AddWithValue("diem", txtDiemSo.Text);
                  
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    HienThi();
                    conn.Close();
                    loadData();

                    MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch
                {
                    MessageBox.Show("Nothing changed, cant save!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
            


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbbSearch.Text == "Mã học sinh")
            {
                
                dataQLD.DataSource = XemDL("SELECT * FROM DiemThi WHERE mahocsinh LIKE '%" + txtSearch.Text.Trim() + "%' ");
                loadData();
            }

            if (cbbSearch.Text == "Tên học sinh")
            {
                dataQLD.DataSource = XemDL("SELECT * FROM DiemThi WHERE ten LIKE N'%" + txtSearch.Text.Trim() + "%' ");
                loadData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbbSearch.Text == "Mã học sinh")
            {

                dataQLD.DataSource = XemDL("SELECT * FROM DiemThi WHERE mahocsinh LIKE '%" + txtSearch.Text.Trim() + "%' ");
                loadData();
            }

            if (cbbSearch.Text == "Tên học sinh")
            {
                dataQLD.DataSource = XemDL("SELECT * FROM DiemThi WHERE ten LIKE N'%" + txtSearch.Text.Trim() + "%' ");
                loadData();
            }
        }
    }
}
