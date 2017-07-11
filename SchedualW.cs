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
    public partial class SchedualW : Form
    {
        int gent;
        string name;
        string user;
        public SchedualW(string A,int x,string nam)
        {
            InitializeComponent();
                    OleDbConnection connect3 = new OleDbConnection();
                    connect3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
                    connect3.Open();
                    OleDbCommand command3 = new OleDbCommand("SELECT gender FROM members where user = '"+A+"'", connect3);
                    OleDbDataReader reader3 = command3.ExecuteReader();
                    OleDbConnection connect4 = new OleDbConnection();
                    connect4.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
                    connect4.Open();
                    OleDbCommand command4 = new OleDbCommand("SELECT firstName FROM members where user = '"+A+"'", connect4);
                    OleDbDataReader reader4 = command4.ExecuteReader();
                    reader4.Read();
                    this.user = A;
                    this.name = reader4["firstName"].ToString();
                    reader3.Read();
                    if (reader3["gender"].ToString() == "F")
                        this.gent = 2;
                    else
                        this.gent = 1;
                    connect4.Close();
                    connect3.Close();
        }
        private void SchedualW_Load(object sender, EventArgs e)
        {
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string x = "LiveM";
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            conn.Open();
            OleDbCommand comm = new OleDbCommand("UPDATE members SET workout='" + x + "' WHERE user = '" + this.user + "'", conn);
            comm.ExecuteNonQuery();
            conn.Close();
            Hide();
            if (gent==2){
                women F4 = new women(user,name);
                F4.Show();}
                else{
                men F3 = new men(user,name);
                F3.Show();}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string x = "BizzyM";
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            conn.Open();
            OleDbCommand comm = new OleDbCommand("UPDATE members SET workout='" + x + "' WHERE user = '" + this.user + "'", conn);
            comm.ExecuteNonQuery();
            conn.Close();
            Hide();
            if (gent == 2)
            {
                women F4 = new women(user, name);
                F4.Show();
            }
            else
            {
                men F3 = new men(user, name);
                F3.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string x = "GetSwole";
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            conn.Open();
            OleDbCommand comm = new OleDbCommand("UPDATE members SET workout='" + x + "' WHERE user = '" + this.user + "'", conn);
            comm.ExecuteNonQuery();
            conn.Close();
            Hide();
            if (gent == 2)
            {
                women F4 = new women(user, name);
                F4.Show();
            }
            else
            {
                men F3 = new men(user, name);
                F3.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string x = "Arnold";
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            conn.Open();
            OleDbCommand comm = new OleDbCommand("UPDATE members SET workout='" + x + "' WHERE user = '" + this.user + "'", conn);
            comm.ExecuteNonQuery();
            conn.Close();
            Hide();
            if (gent == 2)
            {
                women F4 = new women(user, name);
                F4.Show();
            }
            else
            {
                men F3 = new men(user, name);
                F3.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string x = "LiveW";
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            conn.Open();
            OleDbCommand comm = new OleDbCommand("UPDATE members SET workout='" + x + "' WHERE user = '" + this.user + "'", conn);
            comm.ExecuteNonQuery();
            conn.Close();
            Hide();
            if (gent == 2)
            {
                women F4 = new women(user, name);
                F4.Show();
            }
            else
            {
                men F3 = new men(user, name);
                F3.Show();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string x = "BizzyW";
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            conn.Open();
            OleDbCommand comm = new OleDbCommand("UPDATE members SET workout='" + x + "' WHERE user = '" + this.user + "'", conn);
            comm.ExecuteNonQuery();
            conn.Close();
            Hide();
            if (gent == 2)
            {
                women F4 = new women(user, name);
                F4.Show();
            }
            else
            {
                men F3 = new men(user, name);
                F3.Show();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string x = "Sexy";
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            conn.Open();
            OleDbCommand comm = new OleDbCommand("UPDATE members SET workout='" + x + "' WHERE user = '" + this.user + "'", conn);
            comm.ExecuteNonQuery();
            conn.Close();
            Hide();
            if (gent == 2)
            {
                women F4 = new women(user, name);
                F4.Show();
            }
            else
            {
                men F3 = new men(user, name);
                F3.Show();
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Hide();
            if (gent == 2)
            {
                women F4 = new women(user, name);
                F4.Show();
            }
            else
            {
                men F3 = new men(user, name);
                F3.Show();
            }
        }
    }
}
