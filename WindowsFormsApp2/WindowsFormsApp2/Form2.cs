using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
   
    public partial class Form2 : Form
    {
        private string ConnectionString;
        private MySqlConnection connection;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
            
            
            MySqlDataReader dataReader;
            
            
            try
            {
                var username = textBox1.Text;
                var password = textBox2.Text;

                var selectcommand= new MySqlCommand();
            
                selectcommand.CommandText = " select * from users where username=@username and password=@password";
              
                selectcommand.Parameters.AddWithValue("@username", textBox1.Text);
                selectcommand.Parameters.AddWithValue("@password", textBox2.Text);
                selectcommand.Connection = connection;

                selectcommand.ExecuteNonQuery();
                MySqlDataReader datareader = selectcommand.ExecuteReader();

                if (datareader.Read())
                {
                    MessageBox.Show("Login Successfull");
                }
                else
                {
                    MessageBox.Show("Please tell mehow you are");
                }
            }
            catch(Exception)
            {
              
            }
         
            }

        private void Form2_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Server=localhost database=hosteldb Uid=root Pwd=@madiba";
            connection = new MySqlConnection(ConnectionString);
            connection.Open();
            
        }
    }
          
        }
    
