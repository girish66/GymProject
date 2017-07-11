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
    public partial class follow : Form
    {
        string us;
        public follow(string id)
        {
            us=id;
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false; 
            pictureBox3.Visible = false; 
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            //pictureBox9.Visible = false;
            pictureBox8.Visible = false;
            comboBox2.Text = "choose a member";
            OleDbConnection connect = new OleDbConnection();
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "SELECT * FROM members";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["user"].ToString() + "    " + reader["firstName"].ToString() + " " + reader["lastName"].ToString());
            }
            connect.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            //pictureBox9.Visible = false;
            pictureBox8.Visible = false;
            OleDbConnection connect = new OleDbConnection();
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "SELECT * FROM members";
            OleDbDataReader reader = command.ExecuteReader();
            String temp="no workout chossen yet";
            while (reader.Read())// if (reader1["name"].ToString() == textBox2.Text)
            {
                if (reader["user"].ToString() + "    " + reader["firstName"].ToString() + " " + reader["lastName"].ToString() == comboBox2.Text.ToString())
                {
                    temp = reader["workout"].ToString();
                    string A = reader["classes"].ToString();
                    textBox1.Text = A;

                }
                
            }
            connect.Close();

            switch (temp)
            {
                case "BizzyW":
                    {
                        pictureBox4.Visible = true;
                        break;
                    }
                case "BizzyM":
                    {
                        pictureBox1.Visible = true;
                        break;
                    }
                case "Arnold":
                    {
                        pictureBox2.Visible = true;
                        break;
                    }
                case "LiveM":
                    {
                        pictureBox6.Visible = true;
                        break;
                    }
                case "LiveW":
                    {
                        pictureBox3.Visible = true;
                        break;
                    }
                case "Sexy":
                    {
                        pictureBox5.Visible = true;
                        break;
                    }
                case "GetSwole":
                    {
                        pictureBox8.Visible = true;
                        break;
                    }
            }
            
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void follow_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
            instructors I = new instructors(us);
            I.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
