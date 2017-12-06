using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }


        public bool checkObject()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Wrong Username, Please try again!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUsername.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Wrong Password, please try again!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPassword.Focus();
                return false;
            }
            return true;
        }



        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();


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

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (checkObject())
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
                {
                    this.Hide();
              
                    Form_Loading ss = new Form_Loading();
                    ss.Show();

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password, please try again!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearTxt(this);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void Form_Login_MouseDown(object sender, MouseEventArgs e)
        {
            dr.Grab(this);
        }

        private void Form_Login_MouseUp(object sender, MouseEventArgs e)
        {
            dr.Release();
        }

        private void Form_Login_MouseMove(object sender, MouseEventArgs e)
        {
            dr.MoveObject();
        }
    }
}
