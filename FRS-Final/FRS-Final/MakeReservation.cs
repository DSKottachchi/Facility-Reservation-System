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
    public partial class MakeReservation : Form
    {
        public MakeReservation()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=FRS_DB.mdb");
        OleDbCommand cmd;

        private void MakeReservation_Load(object sender, EventArgs e)
        {
            txtDate.Text = ViewPendingRequests.Date;
            txtTime.Text = ViewPendingRequests.Time;
            txtUserID.Text = ViewPendingRequests.UID;
            txtReqID.Text = ViewPendingRequests.RID;
            txtModuleID.Text = ViewPendingRequests.MID;

            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT FacilityID from FacilityTable";
            OleDbDataReader DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                txtFacility.Items.Add(DR1[0]);
            }
            con.Close();

            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * From ReservedTable WHERE ResDate= '" + ViewPendingRequests.Date + "' AND ResTime= '" + ViewPendingRequests.Time + "'";

            OleDbDataAdapter dRAdapter = new OleDbDataAdapter(cmd);//to fill the DataGridView with the data
            DataTable dRTable = new DataTable();
            dRAdapter.Fill(dRTable);//fill the DataTable with the data in the database (using DataAdapter)
            classGrid.DataSource = dRTable; //display the DataTable in the DataGridView
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand(); //Commands such as, Execute reader and SQL statements can be used.
            con.Open();
            try
            {
                cmd.Connection = con;  //command object is being told which connection is being used
                cmd.CommandText = "INSERT INTO ReservedTable(ResDate, ResTime, FacilityID, UserID, RequestID, ModuleID) VALUES ('" + ViewPendingRequests.Date + "', '" + ViewPendingRequests.Time + "', '" + txtFacility + "', '" + ViewPendingRequests.UID + "', '" + ViewPendingRequests.RID + "', '" + ViewPendingRequests.MID + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT * FROM RequestTable where ReqStatus = 'Pending'";
                cmd.ExecuteNonQuery();
                OleDbDataAdapter dRAdapter = new OleDbDataAdapter(cmd);//to fill the DataGridView with the data
                DataTable dRTable = new DataTable();
                dRAdapter.Fill(dRTable);//fill the DataTable with the data in the database (using DataAdapter)
                classGrid.DataSource = dRTable; //display the DataTable in the DataGridView
                cmd.CommandText = "UPDATE RequestTable set ReqStatus = '" + "Confirmed' WHERE RequestID = '" + ViewPendingRequests.RID + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Class Reserved Successfully");
                this.Hide();
                AdminMenu AM = new AdminMenu();
                AM.Show();
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("This class has already been reserved. Please try again");
                this.Hide();
                MakeReservation MR = new MakeReservation();
                MR.Show();
            }
            con.Close();
        }

        private void classGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}
