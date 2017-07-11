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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
           // System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\wishgoods\Desktop\פרוייקט סי שארפ\TheProject\project.wav");
           // player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                           Hide();
                           mainmenu F3 = new mainmenu();
                           F3.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            about Ab = new about();
            Ab.Show();
        }
    }
}
