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
    public partial class identify : Form
    {
        public identify()
        {
            InitializeComponent();
            label2.Text = "Password";
            label1.Text="Username";
            button2.Text = "Accept";
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string A;
            OleDbConnection connect = new OleDbConnection();
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "SELECT user FROM members";
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

                //listBox1.Items.Add(reader["user"].ToString());
                reader2.Read();
                A = reader2["firstName"].ToString();
                if (reader["user"].ToString() == textBox2.Text)
                {
                    String B = reader["user"].ToString();
                    OleDbConnection connect1 = new OleDbConnection();
                    connect1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
                    connect1.Open();
                    OleDbCommand command1 = new OleDbCommand();
                    command1.Connection = connect1;
                    command1.CommandText = "SELECT pass FROM members where user = '" + textBox2.Text + "'";
                    OleDbConnection connect3 = new OleDbConnection();
                    connect3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
                    connect3.Open();
                    OleDbCommand command3 = new OleDbCommand("SELECT gender FROM members where user = '" + textBox2.Text + "'", connect3);
                    OleDbDataReader reader3 = command3.ExecuteReader();
                    OleDbDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        if (reader1["pass"].ToString() == textBox1.Text)
                        {
                            reader3.Read();
                            if (reader3["gender"].ToString() == "F")
                            {
                                Hide();
                                women F4 = new women(B, A);
                                F4.Show();
                            }
                            else
                            {
                                Hide();
                                men F3 = new men(B, A);
                                F3.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("The id or password invalid");
                        }
                    }
                }

            }
            connect.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
            mainmenu F1 = new mainmenu();
            F1.Show();
        }

       
    }
}
