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
    public partial class ViewReservations : Form
    {
        public ViewReservations()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        OleDbCommand cmd;

        private void btnBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminMenu AM = new AdminMenu();
            AM.Show();
        }

        private void ViewReservations_Load(object sender, EventArgs e)
        {
            OleDbConnection connectRqst = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=FRS_DB.mdb");
            cmd = new OleDbCommand(); //Commands such as, Execute reader and SQL statements can be used.
            connectRqst.Open();

            cmd.Connection = connectRqst;  //command object is being told which connection is being used
            cmd.CommandText = "SELECT * FROM ReservedTable";
            //OleDbDataReader read = cmd.ExecuteReader(); //executes commands that return rows

            OleDbDataAdapter dRAdapter = new OleDbDataAdapter(cmd);//to fill the DataGridView with the data
            DataTable dRTable = new DataTable();
            dRAdapter.Fill(dRTable);//fill the DataTable with the data in the database (using DataAdapter)
            dataGridView1.DataSource = dRTable; //display the DataTable in the DataGridView

            connectRqst.Close();

            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView1.Visible = false;
                label2.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
