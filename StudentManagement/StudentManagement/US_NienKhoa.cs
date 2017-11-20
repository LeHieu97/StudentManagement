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
    public partial class US_NienKhoa : UserControl
    {

        public US_NienKhoa()
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
                string sql = "SELECT *FROM nienkhoa";//lấy hết dữ liệu trong bảng hocsinh
                SqlCommand cmd = new SqlCommand(sql, conn);// bắt đầu truy vấn bằng câu lệnh
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                // tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt); //đổ dữ liệu vào kho
                             //đóng kết nối
                conn.Close();
                //ta đổ dữ liệu vào trong gridDataView
                dataterm.DataSource = dt;
                this.dataterm.RowsDefaultCellStyle.BackColor = Color.Bisque;
                this.dataterm.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
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
            string sqlSELECT = "SELECT *FROM nienkhoa";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataterm.DataSource = dt;

        }
        private void US_NienKhoa_Load(object sender, EventArgs e)
        {
            //show data
            KetNoiCSDL();
            //item
            DomainUpDown.DomainUpDownItemCollection items = this.UpDownNienKhoa.Items;
            items.Add("2021");
            items.Add("2022");
            items.Add("2023");

            //set text
            this.UpDownNienKhoa.Text = "2081";
        }

        private void UpDownNienKhoa_SelectedItemChanged(object sender, EventArgs e)
        {
            this.Text = UpDownNienKhoa.Text;
        }
    }

}
