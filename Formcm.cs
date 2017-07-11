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
    public partial class Formcm : Form
    {
        //private Graphics GFX;
        
        public Formcm(string F)
        {
            InitializeComponent();
            this.Location = new Point(820, 250);
           
            OpenFileDialog open = new OpenFileDialog();
            
                pictureBox1.ImageLocation = F+".jpg";
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();

        }

    }
}
