using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Projekt.net
{
    public partial class RegisterForm : Form
    {
         string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Korisnik\source\repos\Projekt .net\Projekt .net\Database1.mdf"";Integrated Security = True";

        public RegisterForm()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUserName.Text == "" || textPassword.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (textPassword.Text != textConfPassword.Text)
                MessageBox.Show("pass do not match");
            else
            {
                using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlConn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", textFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", textLastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@UserName", textUserName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", textPassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Registration is successfull");
                        this.Hide();
                        Sign_in sg = new Sign_in();
                        sg.ShowDialog();
                    sqlConn.Close();
                    }
                
                }
            }
        }
       
    }

