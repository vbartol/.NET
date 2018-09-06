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
    public partial class Sign_in : Form
    {
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Korisnik\source\repos\Projekt .net\Projekt .net\Database1.mdf"";Integrated Security = True";
        public Sign_in()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select count (*) as cnt from Table2 where username=@usr and password=@pwd", conn);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usr", textBox1.Text);
            cmd.Parameters.AddWithValue("@pwd", textBox2.Text);
            conn.Open();
   
            if (cmd.ExecuteScalar().ToString()=="1")
            {
                MessageBox.Show("Login Successfull");
                this.Hide();
                app3dio app = new app3dio();
                app.ShowDialog();
            }
            else
            {
                MessageBox.Show("User name or password are not correct");
                textBox1.Clear();
                textBox2.Clear();
            }
            conn.Close();
        }
    }
}
