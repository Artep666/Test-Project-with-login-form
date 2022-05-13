using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Users : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
       
           
            public Users()
        {
            InitializeComponent(); 
            con = new SqlConnection("server=USER-PC\\SQLEXPRESS; Initial Catalog=SchoolData;Integrated Security=SSPI");
        }

        //Username :Admin
        //Password:admin123
       
       
        
     
        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Login_new where username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                new MenuForm().Show();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void Users_Load(object sender, EventArgs e)
        {

        }

       private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

          
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
