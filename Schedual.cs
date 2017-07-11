using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheProject
{
    public partial class Schedual : Form
    {
        int gender;
        string name;
        string userr;
        public Schedual(string W,string user,int gend,string nam)
        {
            gender = gend;
            name = nam;
            userr = user;

            InitializeComponent();
            if (W == "BizzyM"){
                pictureBox8.Visible = true;
                pictureBox2.Visible = true;}
            else if (W == "BizzyW"){
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;}
            else if (W == "GetSwole")
            {
                pictureBox9.Visible = true;
                pictureBox4.Visible = true;
            }
            else if (W == "Sexy")
            {
                pictureBox10.Visible = true;
                pictureBox1.Visible = true;
            }
            else if (W == "Arnold")
            {
                pictureBox12.Visible = true;
                pictureBox3.Visible = true;
            }
            else if (W == "LiveM")
            {
                pictureBox11.Visible = true;
                pictureBox5.Visible = true;
            }
            else if (W == "LiveW")
            {
                pictureBox11.Visible = true;
                pictureBox7.Visible = true;
            }
        }

        private void Schedual_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Hide();
            if (gender == 2)
            {
                women F4 = new women(userr, name);
                F4.Show();
            }
            else
            {
                men F3 = new men(userr, name);
                F3.Show();
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
