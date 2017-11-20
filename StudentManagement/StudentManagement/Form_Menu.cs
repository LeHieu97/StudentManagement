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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult r;
            r = MessageBox.Show("Did you want to exit?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            { Application.Exit(); }
            else
            { }

        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmHs1.Visible = true;
            frmHs1.BringToFront();
        }

        //private void btnClass_Click(object sender, EventArgs e)
        //{
        //    uS_Class1.Visible = true;
        //    uS_Class1.BringToFront();
        //}

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 55)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 260;
                animatorPnl.ShowSync(sideMenu);
                animatorLogo.ShowSync(logo);
            }
            else

            {
                animatorLogo.HideSync(logo);
                sideMenu.Visible = false;
                sideMenu.Width = 55;
                animatorPnl.ShowSync(sideMenu);
            }
        }

        private void pnlName_MouseDown(object sender, MouseEventArgs e)
        {
            dr.Grab(this);
        }

        private void pnlName_MouseMove(object sender, MouseEventArgs e)
        {
            dr.MoveObject();
        }

        private void pnlName_MouseUp(object sender, MouseEventArgs e)
        {
            dr.Release();
        }

        //    private void btnScore_Click(object sender, EventArgs e)
        //    {
        //        uS_Score1.Visible = true;
        //        uS_Score1.BringToFront();
        //    }
    }
}
