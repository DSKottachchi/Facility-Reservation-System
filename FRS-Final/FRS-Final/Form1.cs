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
    public partial class Form1 : Form
    {
        public static string currentuserID;
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }
        OleDbConnection con;
        OleDbCommand cmd;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usr = txtUsername.Text; //Text for input
            string psw = txtPassword.Text;
            string type = cmbType.Text;
            string status = " ";
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=FRS_DB.mdb");  //Connection to the data source
            cmd = new OleDbCommand(); //Commands such as, Execute reader and SQL statements can be used.

            con.Open(); //Opens database connection
            cmd.Connection = con;  //command object is being told which connection is being used
            cmd.CommandText = "SELECT * FROM UserTable where UserName='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "' AND UserType='" + cmbType.Text + "'";
            OleDbDataReader readdata = cmd.ExecuteReader(); //executes commands that return rows
            if (readdata.Read()) //Something like reading files (if data in the database = input)
            {
                MessageBox.Show("Successfully Logged in");
                if (cmbType.Text == "User")
                {
                    this.Hide();//hide the Form1(Login)
                    UserMenu UM = new UserMenu();//object for UserMenu
                    status = "Logged in";
                    UM.Show();//show UserMenu                  
                }
                else if (cmbType.Text == "Admin")
                {
                    this.Hide();//hide the Form1(Login)
                    AdminMenu AM = new AdminMenu();//object for AdminMenu
                    status = "Logged in";
                    AM.Show();//show AdminMenu                  
                }

            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
                txtUsername.Text = "";/*clear text boxes*/
                txtPassword.Text = "";
                cmbType.Text = "";
                status = "Login fail";
            }
            con.Close(); //closes database connection
            if (status == "Logged in")
            {
                con.Open(); //Opens database connection
                cmd.Connection = con;  //command object is being told which connection is being used
                cmd.CommandText = "SELECT UserID from UserTable WHERE Username='" + txtUsername.Text + "'";
                currentuserID = Convert.ToString(cmd.ExecuteScalar());
                con.Close();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
