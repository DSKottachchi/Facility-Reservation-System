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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void btnViewRqst_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPendingRequests VP = new ViewPendingRequests();
            VP.Show();
        }

        private void btnViewRes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewReservations VR = new ViewReservations();
            VR.Show();
        }

        private void btnCRes_Click(object sender, EventArgs e)
        {
            this.Hide();
            CancelReservations CR = new CancelReservations();
            CR.Show();
        }
    }
}
