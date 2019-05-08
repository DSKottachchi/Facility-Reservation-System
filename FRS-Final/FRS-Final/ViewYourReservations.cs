using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//API FOR CONNECTION

namespace FRS_Final
{
    public partial class ViewYourReservations : Form
    {
        public ViewYourReservations()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }
        string dateNow;
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=FRS_DB.mdb");  //Connection to the data source
        OleDbCommand cmd;
        private void ViewYourReservations_Load(object sender, EventArgs e)
        {
            timer1.Start();
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * From ReservedTable WHERE UserID= '" + Form1.currentuserID + "' AND ResDate= '"+dateNow+"'";

            OleDbDataAdapter dRAdapter = new OleDbDataAdapter(cmd);//to fill the DataGridView with the data
            DataTable dRTable = new DataTable();
            dRAdapter.Fill(dRTable);//fill the DataTable with the data in the database (using DataAdapter)
            resGrid.DataSource = dRTable; //display the DataTable in the DataGridView
            if (resGrid.Rows.Count == 0)
            {
                resGrid.Visible = false;
                lblMsg.Visible = true;
            }
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateNow = DateTime.Now.ToShortDateString();
            //label2.Text = dateNow;
        }

        private void btnBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserMenu UM = new UserMenu();
            UM.Show();
        }
    }
}
