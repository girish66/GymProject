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
    public partial class Course : Form
    {
        int lvl;
        int chk;
        int sex;
        CheckBox[] arr = new CheckBox[14];
        string name;
        string user;
        string cour;
        string sub;
        public Course(string A, int gend, string nam)
        {
            InitializeComponent();
            this.name = nam;
            this.user = A;
            this.sex = gend;
            OleDbConnection connect3 = new OleDbConnection();
            connect3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
            connect3.Open();
            OleDbCommand command3 = new OleDbCommand("SELECT premission FROM members where user = '" + A + "'", connect3);
            OleDbDataReader reader3 = command3.ExecuteReader();
            reader3.Read();
            if (reader3["premission"].ToString() == "1")
            {
                lvl = 1;
                sub = State1.getSubscription();
            }
            else if (reader3["premission"].ToString() == "2")
            {
                lvl = 2;
                sub = State2.getSubscription();
            }
            else
            {
                lvl = 3;
                sub = State3.getSubscription();
            }

            arr[0] = checkBox1; arr[1] = checkBox2; arr[2] = checkBox3; arr[3] = checkBox4; arr[4] = checkBox5; arr[5] = checkBox6; arr[6] = checkBox7;
            arr[7] = checkBox8; arr[8] = checkBox9; arr[9] = checkBox10; arr[10] = checkBox11; arr[11] = checkBox12; arr[12] = checkBox13; arr[13] = checkBox14;
            connect3.Close();

        }

        private void Course_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            chk = 0;
                for (int i = 0; i < 14; i++)
                    if (arr[i].Checked == true)
                        chk++;
                if (chk > lvl)
                    if (lvl == 3)
                        MessageBox.Show("You have a "+sub+" Subscription you can only pick 3 Courses.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    else if (lvl == 2)
                        MessageBox.Show("You have a " + sub + " Subscription you can only pick 2 Courses.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    else
                        MessageBox.Show("You have a " + sub + " Subscription you can only pick one Course.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else if (chk <= lvl)
                {
                    cour = "";
                    if (arr[0].Checked) 
                        cour = cour + "Cardiovescular ";
                    if (arr[1].Checked) 
                        cour = cour + "Strengh ";
                    if (arr[2].Checked) 
                        cour = cour + "Crossfit ";
                    if (arr[3].Checked) 
                        cour = cour + "Water Aerobics ";
                    if (arr[4].Checked) 
                        cour = cour + "Kickboxing ";
                    if (arr[5].Checked) 
                        cour = cour + "Boxing ";
                    if (arr[6].Checked) 
                        cour = cour + "Meditation ";
                    if (arr[7].Checked) 
                        cour = cour + "Spinning ";
                    if (arr[8].Checked) 
                        cour = cour + "Power Yoga ";
                    if (arr[9].Checked) 
                        cour = cour + "Gymnastic ";
                    if (arr[10].Checked) 
                        cour = cour + "Zumba ";
                    if (arr[11].Checked) 
                        cour = cour + "Yoga ";
                    if (arr[12].Checked) 
                        cour = cour + "Abs ";
                    if (arr[13].Checked) 
                        cour = cour + "P.T. ";
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
                    conn.Open();
                    OleDbCommand comm = new OleDbCommand("UPDATE members SET classes='" + cour + "' WHERE user = '" + this.user + "'", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    Hide();
                    if (sex == 1)
                    {
                        men M = new men(user, name);
                        M.Show();
                    }
                    else
                    {
                        women W = new women(user, name);
                        W.Show();
                    }
                }
            }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hide();
            if (sex == 1)
            {
                men M = new men(user, name);
                M.Show();
            }
            else
            {
                women W = new women(user, name);
                W.Show();
            }
        }

        }
    }

