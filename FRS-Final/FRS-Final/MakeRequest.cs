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
    public partial class MakeRequest : Form
    {
        public MakeRequest()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=FRS_DB.mdb");  //Connection to the data source
        OleDbCommand cmd;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MakeRequest_Load(object sender, EventArgs e)
        {
            txtUserID.Text = Form1.currentuserID;
            cmd = new OleDbCommand(); //Commands such as, Execute reader and SQL statements can be use
            con.Open(); //Opens database connection
            cmd.Connection = con;//command object is being told which connection is being used
            cmd.CommandText = "SELECT ModuleID from ModuleTable";
            OleDbDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                txtModuleID.Items.Add(DR[0]);
            }
            con.Close();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT FacilityID from FacilityTable";
            OleDbDataReader DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                txtFacilityID.Items.Add(DR1[0]);
            }
            
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Text;
            string module = txtModuleID.Text;
            string facility = txtFacilityID.Text;
            string date = txtDate.Text;
            string time = cmbTime.Text;
            //string capacilty = txtCapacity.Text;
            //string comments = txtComments.Text;
          
            cmd = new OleDbCommand(); //Commands such as, Execute reader and SQL statements can be use
            con.Open(); //Opens database connection
            cmd.Connection = con;//command object is being told which connection is being used
            cmd.CommandText = "SELECT max(RequestID) from RequestTable";
            string autoGen = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
            string[] split = autoGen.Split('Q');
            int num =Convert.ToInt32( split[1]) +1;
            string newID = "REQ" + num;
            //string[] splitDate = date.Split(',');
            //string day = splitDate[0];
            //string finalDate = splitDate[1] + ", " +splitDate[2];
            //finalDate.Trim();
            lbltest.Text = Form1.currentuserID;
            con.Open();
            try
            {
                cmd.CommandText = "INSERT INTO RequestTable (RequestID, ReqStatus, FacilityID,ReqDate,ReqTime,UserID,ModuleID) VALUES ('" + newID + "','" + "Pending" +  "','" + facility + "','" + date + "','" + time + "','" + userID + "','" + module + "')";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Successfully Added");
                txtUserID.Text = " ";
                txtModuleID.Text = " ";
                txtFacilityID.Text = " ";
         
                cmbTime.Text = " ";
                //txtCapacity.Text = " ";
                //txtComments.Text = " ";
                //con.Open();

            }

            catch(System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Incorrect User ID. Please check again");
            }
            
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserMenu UM = new UserMenu();
            UM.Show();
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFacilityType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
