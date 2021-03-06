﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TESTING_PROJECT
{
    public partial class frmHs : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=ASUS-AS;Initial Catalog=D:\studentmanagement\quanlyhocsinh.mdf;Integrated Security=True");

       
        private SqlCommand cmd;
        private SqlDataAdapter sda;
        private DataTable dt;
        private DataSet ds;
        public frmHs()
        {
            InitializeComponent();
        }
        public void laodCompo()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT HS1.MALOP from HS1", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read() == true)
                {
                    String nien = (string)(dr["MALOP"].ToString());
                    comboBoxLop.Items.Add(nien);

                }
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
          

        }

        private void frmHs_Load(object sender, EventArgs e)
        {
            loadDanhSach("SELECT *FROM HS1");
            laodCompo();
          
        }
        public void loadDanhSach(String selectHocSinh)
        {
            con.Open();
            sda = new SqlDataAdapter(selectHocSinh, con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewDanhSach.DataSource = dt;
            con.Close();
            this.dataGridViewDanhSach.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dataGridViewDanhSach.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }
        
        public Boolean checkMaHs(String ma)
        {
            foreach (Char i in ma)
            {
                if (!Char.IsNumber(i))
                {
                    return false;
                }

            }
            return true;

        }
        public Boolean checkTenHoHs(String ho)
        {
            foreach (Char i in ho)
            {
                if (!Char.IsNumber(i))
                {
                    return true;
                }

            }
            return false;

        }
        public Boolean checkTenHs(String ten)
        {
            foreach (Char i in ten)
            {
                if (!Char.IsNumber(i))
                {
                    return false;
                }

            }
            return true;

        }
        private void dataGridViewDanhSach_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaHS.Text = dataGridViewDanhSach.SelectedRows[0].Cells[0].Value.ToString();
            txtHoLot.Text = dataGridViewDanhSach.SelectedRows[0].Cells[1].Value.ToString();
            txtTen.Text = dataGridViewDanhSach.SelectedRows[0].Cells[2].Value.ToString();
            //dateTimePicker1.Text = dataGridViewDanhSach.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxLop.Text = dataGridViewDanhSach.SelectedRows[0].Cells[4].Value.ToString();

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
        public DataTable XemDL(string sql)
        {
            Ketnoi();

            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;

            //Ngatketnoi();
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            {
                
                try
                {
                    if (checkMaHs(txtMaHS.Text))
                    {
                        con.Open();
                        cmd = new SqlCommand("INSERT INTO HS1(IDHOCSINH, HOLOT, TENHS, MALOP) VALUES(@id, @ho, @ten, @malop)", con);

                        cmd.Parameters.Add(new SqlParameter("@id", Int32.Parse(txtMaHS.Text.ToString())));
                        cmd.Parameters.Add(new SqlParameter("@ho", txtHoLot.Text));
                        cmd.Parameters.Add(new SqlParameter("@ten", txtTen.Text));
                        cmd.Parameters.Add(new SqlParameter("@malop", comboBoxLop.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("OKE ", "Thông Báo", MessageBoxButtons.OK);
                        con.Close();
                        loadDanhSach("SELECT *FROM HS1");
                    }
                    else
                    {
                        MessageBox.Show("Đầu Vào K Hợp Lệ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);

                }
            }

            con.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
         
            {
                btnUpdate.Text = "Edit";
                try
                {
                    // if (checkMaHs(txtMaHS.Text) && checkTenHoHs(txtHoLot.Text) && checkTenHs(txtTen.Text))
                    //{
                    con.Open();
                    cmd = new SqlCommand(" Update HS1 Set HOLOT = @HO, TENHS = @TEN,MALOP=@MALOP Where IDHOCSINH =@maHS", con);
                    cmd.Parameters.Add(new SqlParameter("@id", txtMaHS.Text));

                    cmd.Parameters.Add(new SqlParameter("@HO", txtHoLot.Text));
                    cmd.Parameters.Add(new SqlParameter("@TEN", txtTen.Text));
                    cmd.Parameters.Add(new SqlParameter("@MALOP", comboBoxLop.Text));
                    cmd.Parameters.Add(new SqlParameter("@maHS", txtMaHS.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("update  Thành Công", "Thông Báo:", MessageBoxButtons.OK);
                    con.Close(); txtMaHS.Enabled = false;

                    loadDanhSach("SELECT *FROM HS1");
                    // }
                    //  else
                    //  {
                    //      MessageBox.Show("Invalid Values", "Notice:", MessageBoxButtons.OK);

                    // }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi update", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);
                    con.Close();

                }
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Không", "Chú ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                   
                    con.Open();
                    cmd = new SqlCommand("DELETE hs1 Where hs1.IDHOCSINH=@id", con);
                    cmd.Parameters.Add(new SqlParameter("@id", txtMaHS.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa  Thành Công", "Thông Báo:", MessageBoxButtons.OK);
                    con.Close();

                    loadDanhSach("SELECT *FROM HS1");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);

                }
                txtMaHS.Enabled = false;

            }
        }

        private void txtSearch1_OnValueChanged(object sender, EventArgs e)
        {
            
                dataGridViewDanhSach.DataSource = XemDL("SELECT * FROM HS1 WHERE TENHS LIKE N'%" + txtSearch1.Text.Trim() + "%' ");
        }
    }
}
