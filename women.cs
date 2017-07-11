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
    public partial class women : Form
    {
        string F;
        int gend;
        string name;
        public women(string A,string B)
        {
            InitializeComponent();
            gend = 2;
            this.F = A;
            OleDbConnection connect2 = new OleDbConnection();
            connect2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            connect2.Open();
            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = connect2;
            command2.CommandText = "SELECT workout FROM members where user= '" + A + "'";
            OleDbDataReader reader2 = command2.ExecuteReader();
            reader2.Read();
            OleDbConnection connect3 = new OleDbConnection();
            connect3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            connect3.Open();
            OleDbCommand command3 = new OleDbCommand();
            command3.Connection = connect3;
            command3.CommandText = "SELECT classes FROM members where user= '" + A + "'";
            OleDbDataReader reader3 = command3.ExecuteReader();
            name = B;
            label2.Text = " Welcome back " + B;
            label3.Text = "Current Workout: " + reader2["workout"].ToString();
            label4.Text = "Current Courses: ";
            while (reader3.Read())
            {
                string C = reader3["classes"].ToString();
                label4.Text = label4.Text + "\n"+C;
            }
            OleDbConnection connect = new OleDbConnection();
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "SELECT premission FROM members where user= '" + A + "'";
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader["premission"].ToString() == "1")
                pictureBox2.Visible = true;
            else if (reader["premission"].ToString() == "2")
                pictureBox3.Visible = true;
            else if (reader["premission"].ToString() == "3")
                pictureBox4.Visible = true;
           
            connect3.Close();
            connect2.Close();
            connect.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            SchedualW s = new SchedualW(this.F,gend,name);
            s.Show();
        }

        private void women_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.members' table. You can move, or remove it, as needed.
            //this.membersTableAdapter.Fill(this.database1DataSet.members);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection connect2 = new OleDbConnection();
            connect2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            connect2.Open();
            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = connect2;
            command2.CommandText = "SELECT workout FROM members where user= '" + this.F + "'";
            OleDbDataReader reader2 = command2.ExecuteReader();
            reader2.Read();
            string W = reader2["workout"].ToString();
            Schedual S1 = new Schedual(W, this.F, gend, name);
            Hide();
            S1.Show();
            connect2.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Close();
            identify F2 = new identify();
            F2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Course s = new Course(this.F, gend, name);
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Shop s = new Shop(this.F, gend, name);
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formcm C = new Formcm(F);
            C.Show();
        }

    }
}
