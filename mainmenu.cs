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
    public partial class mainmenu : Form
    {
        
            
        public mainmenu()
        {
            InitializeComponent();
            button1.Text = "Members";
            button2.Text = "Instructors";

           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text=DateTime.Now.Hour+":"+DateTime.Now.Minute+":"+DateTime.Now.Second;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
            identify F2 = new identify();
            F2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            identify2 F4 = new identify2();
            F4.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
