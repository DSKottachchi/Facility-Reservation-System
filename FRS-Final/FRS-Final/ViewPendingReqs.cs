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
    public partial class ViewPendingReqs : Form
    {
        public ViewPendingReqs()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=FRS_DB.mdb");  //Connection to the data source
        OleDbCommand cmd;
        private void ViewPendingReqs_Load(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * From RequestTable WHERE UserID= '" + Form1.currentuserID + "' AND ReqStatus= '"+"Pending"+"'";

            OleDbDataAdapter dRAdapter = new OleDbDataAdapter(cmd);//to fill the DataGridView with the data
            DataTable dRTable = new DataTable();
            dRAdapter.Fill(dRTable);//fill the DataTable with the data in the database (using DataAdapter)
            reqGrid.DataSource = dRTable; //display the DataTable in the DataGridView
            if (reqGrid.Rows.Count == 0)
            {
                reqGrid.Visible = false;
                lblMsg.Visible = true;
            }
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string requestID;
            if (this.reqGrid.SelectedRows.Count > 0)
            {
                con.Open();
                requestID = reqGrid.SelectedCells[0].Value.ToString();
                cmd.CommandText = "UPDATE RequestTable set ReqStatus = '" + "Cancelled' WHERE RequestID = '" + requestID + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Request Cancelled Successfully");
                
                //dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please Select A Request To Cancel");
            }
        }

        private void btnBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserMenu UM = new UserMenu();
            UM.Show();
        }
    }
}
