using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TheProject
{
    public partial class memlist : Form
    {
        string us;
        
        public memlist(string id)
        {
            us = id;
            InitializeComponent();
            
            OleDbConnection connect = new OleDbConnection();
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "SELECT * FROM members";
            OleDbConnection connect2 = new OleDbConnection();
            connect2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            connect2.Open();
            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = connect2;
            command2.CommandText = "SELECT firstName FROM members";
            OleDbDataReader reader = command.ExecuteReader();
            OleDbDataReader reader2 = command2.ExecuteReader();
            while (reader.Read())
            {
                reader2.Read();
                User.Items.Add(reader["user"].ToString() + "      " + reader2["firstName"]);
            }
            connect.Close();
            connect2.Close();
        }
        private void memlist_Load(object sender, EventArgs e)
        {

        }






        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {
            
          
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void label5_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
            instructors I = new instructors(us);
            I.Show();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection connect = new OleDbConnection();
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            OleDbDataAdapter ad = new OleDbDataAdapter();
            try
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM members", connect);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["user"].ToString().StartsWith(textBox1.Text.ToString()))
                    {


                        User.SelectedItem = (reader["user"].ToString() + "      " + reader["firstName"].ToString()).ToString();

                    }

                }
            }
            catch
            {
                MessageBox.Show("members not found");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            try
            {
                editmem E = new editmem("", User.SelectedItem.ToString().Remove(9),us);
                Close();
                E.Show();
            }
            catch {
                editmem E = new editmem("", "",us);
                Close();
                E.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
            String A = "";
            try
            {
                CheckId I = new CheckId(A, User.SelectedItem.ToString().Remove(9),us);
                Close();
                I.Show();
            }
            catch {
                CheckId I = new CheckId(A, " ",us);
                Close();
                I.Show();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string a = "remove";
            try
            {
                CheckId I2 = new CheckId(a, User.SelectedItem.ToString().Remove(9),us);
                Close();
                I2.Show();
            }
            catch {
                CheckId I2 = new CheckId(a, " ",us);
                Close();
                I2.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string a = "Show";
            try
            {
                
                CheckId E = new CheckId(a, User.SelectedItem.ToString().Remove(9),us);
                Close();
                E.Show();
            }
            catch {

                
                CheckId E = new CheckId(a, " ",us);
                Close();
                E.Show();
            }


        }
    }
}
