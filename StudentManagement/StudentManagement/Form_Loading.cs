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
    public partial class Form_Loading : Form
    {
        public Form_Loading()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Start();
            progressBar1.Increment(3);
            if (progressBar1.Value == 100) // can choose according whatever u need
            {
                timer1.Stop();
                this.Hide();
                Application.DoEvents();
                Form_Menu ss = new Form_Menu();
                ss.Show();

            }
        }
    }
}
