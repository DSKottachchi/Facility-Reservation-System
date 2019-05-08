using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRS_Final
{
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeRequest MR = new MakeRequest();
            MR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ViewYourReservations VR = new ViewYourReservations();
            VR.Show();
            //CB.Show();
            //if (CB.Visible == false)
            //{
            //    CB.Hide();
            //}
        }

        private void lblUserMenu_Click(object sender, EventArgs e)
        {

        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPendingReqs PR = new ViewPendingReqs();
            PR.Show();
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
