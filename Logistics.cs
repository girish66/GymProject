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
    public partial class Logistics : Form
    {
        string us;
        public Logistics(string id)
        {
            us = id;
            InitializeComponent();
            button1.Text = "Members";
            button2.Text = "Staff";
            button3.Text = "Courses";
            button4.Text = "Club";
            pictureBox5.BorderStyle = BorderStyle.None;
            var pos = this.PointToScreen(label1.Location);
            pos = pictureBox4.PointToClient(pos);
            label1.Parent = pictureBox4;
            label1.Location = pos;
            var pos2 = this.PointToScreen(label2.Location);
            pos2 = pictureBox4.PointToClient(pos2);
            label2.Parent = pictureBox4;
            label2.Location = pos2;
            var pos3 = this.PointToScreen(label3.Location);
            pos3 = pictureBox4.PointToClient(pos3);
            label3.Parent = pictureBox4;
            label3.Location = pos3;
            var pos4 = this.PointToScreen(label4.Location);
            pos4 = pictureBox4.PointToClient(pos4);
            label4.Parent = pictureBox4;
            label4.Location = pos4;
            var pos5 = this.PointToScreen(label5.Location);
            pos5 = pictureBox4.PointToClient(pos5);
            label5.Parent = pictureBox4;
            label5.Location = pos5;
            var pos6 = this.PointToScreen(label6.Location);
            pos6 = pictureBox4.PointToClient(pos6);
            label6.Parent = pictureBox4;
            label6.Location = pos6;
            var pos7 = this.PointToScreen(label7.Location);
            pos7 = pictureBox3.PointToClient(pos7);
            label7.Parent = pictureBox3;
            label7.Location = pos7;
            var pos8 = this.PointToScreen(label8.Location);
            pos8 = pictureBox2.PointToClient(pos8);
            label8.Parent = pictureBox2;
            label8.Location = pos8;
            var pos9 = this.PointToScreen(label9.Location);
            pos9 = pictureBox2.PointToClient(pos9);
            label9.Parent = pictureBox2;
            label9.Location = pos9;
            var pos10 = this.PointToScreen(label10.Location);
            pos10 = pictureBox2.PointToClient(pos10);
            label10.Parent = pictureBox2;
            label10.Location = pos10;
            var pos11 = this.PointToScreen(label11.Location);
            pos11 = pictureBox2.PointToClient(pos11);
            label11.Parent = pictureBox2;
            label11.Location = pos11;
            var pos12 = this.PointToScreen(label12.Location);
            pos12 = pictureBox2.PointToClient(pos12);
            label12.Parent = pictureBox2;
            label12.Location = pos12;


            var pos13 = this.PointToScreen(label13.Location);
            pos13 = pictureBox1.PointToClient(pos13);
            label13.Parent = pictureBox1;
            label13.Location = pos13;

            var pos14 = this.PointToScreen(label14.Location);
            pos14 = pictureBox1.PointToClient(pos14);
            label14.Parent = pictureBox1;
            label14.Location = pos14;

            var pos15 = this.PointToScreen(label15.Location);
            pos15 = pictureBox1.PointToClient(pos15);
            label15.Parent = pictureBox1;
            label15.Location = pos15;

            var pos16 = this.PointToScreen(label16.Location);
            pos16 = pictureBox1.PointToClient(pos16);
            label16.Parent = pictureBox1;
            label16.Location = pos16;

            var pos17 = this.PointToScreen(label17.Location);
            pos17 = pictureBox1.PointToClient(pos17);
            label17.Parent = pictureBox1;
            label17.Location = pos17;

            var pos18 = this.PointToScreen(label18.Location);
            pos18 = pictureBox1.PointToClient(pos18);
            label18.Parent = pictureBox1;
            label18.Location = pos18;

            var pos19 = this.PointToScreen(label19.Location);
            pos19 = pictureBox1.PointToClient(pos19);
            label19.Parent = pictureBox1;
            label19.Location = pos19;

            var pos20 = this.PointToScreen(label20.Location);
            pos20 = pictureBox1.PointToClient(pos20);
            label20.Parent = pictureBox1;
            label20.Location = pos20;

            var pos21 = this.PointToScreen(label21.Location);
            pos21 = pictureBox1.PointToClient(pos21);
            label21.Parent = pictureBox1;
            label21.Location = pos21;

            var pos22 = this.PointToScreen(label22.Location);
            pos22 = pictureBox1.PointToClient(pos22);
            label22.Parent = pictureBox1;
            label22.Location = pos22;

            var pos23 = this.PointToScreen(label23.Location);
            pos23 = pictureBox1.PointToClient(pos23);
            label23.Parent = pictureBox1;
            label23.Location = pos23;
        }

        private void Logistics_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0, silver = 0, gold = 0, platinum = 0, aveage = 0, agemin = 120, agemax = 0,extra= 0,female= 0,male=0;
            DataTable mems= Access.Get("*","members");
            total = mems.Rows.Count;

            for (int i = 0; i < mems.Rows.Count; i++)
            {
                aveage += Convert.ToInt32(mems.Rows[i][7].ToString());
                if (Convert.ToInt32(mems.Rows[i][7].ToString()) > agemax)
                    agemax = Convert.ToInt32(mems.Rows[i][7].ToString());
                if (Convert.ToInt32(mems.Rows[i][7].ToString()) < agemin)
                    agemin = Convert.ToInt32(mems.Rows[i][7].ToString());
                if (mems.Rows[i][12].ToString() != " ")
                    extra++;
                if (mems.Rows[i][9].ToString() == "F" || mems.Rows[i][9].ToString() == "f")
                    female++;
                else
                    male++;
                if (Convert.ToInt32(mems.Rows[i][5]) == 1)
                    silver++;
                else if (Convert.ToInt32(mems.Rows[i][5]) == 2)
                    gold++;
                else if (Convert.ToInt32(mems.Rows[i][5]) == 3)
                    platinum++;
            }
            aveage = aveage / mems.Rows.Count;
            label13.Text = total.ToString();
            label14.Text = silver.ToString();
            label15.Text = gold.ToString();
            label16.Text = platinum.ToString();

            label17.Text = aveage.ToString();
            label18.Text = agemin.ToString();
            label19.Text = agemax.ToString();
            label20.Text = extra.ToString();
            
            label21.Text = total.ToString();
            label22.Text = male.ToString();
            label23.Text = female.ToString();
            
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;");
            OleDbCommand cmd=new OleDbCommand("SELECT type FROM instructors",con);
            con.Open();
            try { 
            OleDbDataReader rd = cmd.ExecuteReader(); 
            int P=0, F=0, I=0;
            while (rd.Read())
            {
                I++;
                if (rd["type"].ToString() == "f")
                    F++;
                else
                    P++;
 
            }
           
            label10.Text = I.ToString();
            label11.Text = P.ToString();
            label12.Text = F.ToString();

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
            instructors L = new instructors(us);
            L.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            label1.Parent = pictureBox4;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
