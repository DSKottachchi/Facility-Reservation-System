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
    public partial class ViewPendingRequests : Form
    {
        public ViewPendingRequests()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }
        OleDbConnection connectRqst = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=FRS_DB.mdb");
        OleDbCommand commandRqst;
        public static string RID;
        public static string Date;
        public static string Time;
        public static string UID;
        public static string FID;
        public static string MID;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RID = dataGridView1.SelectedCells[0].Value.ToString();
            Date = dataGridView1.SelectedCells[1].Value.ToString();
            Time = dataGridView1.SelectedCells[2].Value.ToString();
            UID = dataGridView1.SelectedCells[3].Value.ToString();
            FID = dataGridView1.SelectedCells[4].Value.ToString();
            MID = dataGridView1.SelectedCells[5].Value.ToString();

        }

        private void ViewPendingRequests_Load(object sender, EventArgs e)
        {
            commandRqst = new OleDbCommand(); //Commands such as, Execute reader and SQL statements can be used.
            connectRqst.Open(); 

            commandRqst.Connection = connectRqst;  //command object is being told which connection is being used
            commandRqst.CommandText = "SELECT * FROM RequestTable where ReqStatus = 'Pending'";
            // OleDbDataReader read = command.ExecuteReader(); //executes commands that return rows

            OleDbDataAdapter dRAdapter = new OleDbDataAdapter(commandRqst);//to fill the DataGridView with the data
            DataTable dRTable = new DataTable();
            dRAdapter.Fill(dRTable);//fill the DataTable with the data in the database (using DataAdapter)
            dataGridView1.DataSource = dRTable; //display the DataTable in the DataGridView
            connectRqst.Close();

            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView1.Visible = false;
                lblMsg.Visible = true;
            }
        }

        private void btnBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminMenu AM = new AdminMenu();
            AM.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commandRqst = new OleDbCommand(); //Commands such as, Execute reader and SQL statements can be used.
            connectRqst.Open();
            try
            {
                commandRqst.Connection = connectRqst;  //command object is being told which connection is being used
                commandRqst.CommandText = "INSERT INTO ReservedTable(ResDate, ResTime, FacilityID, UserID, RequestID, ModuleID) VALUES ('" + Date + "', '" + Time + "', '" + FID + "', '" + UID + "', '" + RID + "', '" + MID + "')";
                commandRqst.ExecuteNonQuery();
                commandRqst.CommandText = "SELECT * FROM RequestTable where ReqStatus = 'Pending'";
                commandRqst.ExecuteNonQuery();
                OleDbDataAdapter dRAdapter = new OleDbDataAdapter(commandRqst);//to fill the DataGridView with the data
                DataTable dRTable = new DataTable();
                dRAdapter.Fill(dRTable);//fill the DataTable with the data in the database (using DataAdapter)
                dataGridView1.DataSource = dRTable; //display the DataTable in the DataGridView
                commandRqst.CommandText = "UPDATE RequestTable set ReqStatus = '" + "Confirmed' WHERE RequestID = '" + RID + "'";
                commandRqst.ExecuteNonQuery();
                MessageBox.Show("Class Reserved Successfully");
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("This class has already been reserved. Please try again");
                this.Hide();
                MakeReservation MR = new MakeReservation();
                MR.Show();
            }           
            connectRqst.Close();

        }
    }
}
