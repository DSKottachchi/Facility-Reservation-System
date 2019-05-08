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
    public partial class CancelReservations : Form
    {
        public CancelReservations()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=FRS_DB.mdb");  //Connection to the data source
        OleDbCommand cmd;

        private void CancelReservations_Load(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM ReservedTable";

            OleDbDataAdapter dRAdapter = new OleDbDataAdapter(cmd);//to fill the DataGridView with the data
            DataTable dRTable = new DataTable();
            dRAdapter.Fill(dRTable);//fill the DataTable with the data in the database (using DataAdapter)
            dataGridView1.DataSource = dRTable; //display the DataTable in the DataGridView
            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView1.Visible = false;
            }
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string requestID;
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                con.Open();
                requestID = dataGridView1.SelectedCells[5].Value.ToString();
                cmd.CommandText = "DELETE FROM ReservedTable WHERE RequestID = '" + requestID + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Reserved Cancelled Successfully");

                //dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please Select A Reservation To Cancel");
            }
        }

        private void btnBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminMenu AM = new AdminMenu();
            AM.Show();
        }
    }
}
