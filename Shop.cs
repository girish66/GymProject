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
    public partial class Shop : Form
    {
        int x = 0;
        string A2,N2;
        int G2;
        PictureBox[] split;
        public Shop(string A,int G,string N)
        {
            A2 = A;
            G2 = G;
            N2 = N;
            InitializeComponent();
            textBox1.Text = "0";
            
        }
        private void VisVis(PictureBox a,PictureBox[] b)
        {
            if (!a.Visible)
                a.Visible = true;
            else
                a.Visible = false;
            for (int i = 0; i < 12; i++)
                if (b[i] != a)
                    b[i].Visible = false;
 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            var pBoxes = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox26 };
            for (int i = 0; i < 12; i++)
                pBoxes[i].Visible = false;
            split = pBoxes;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            VisVis(pictureBox6, split);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

            VisVis(pictureBox2, split);
         
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            VisVis(pictureBox3, split);
      
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            VisVis(pictureBox10, split);
        
            
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            VisVis(pictureBox8, split);
          
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            VisVis(pictureBox12, split);
     
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            VisVis(pictureBox4, split);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            VisVis(pictureBox9, split);
     
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            VisVis(pictureBox11, split);
   
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            VisVis(pictureBox7, split);
      
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            VisVis(pictureBox5, split);
   
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            VisVis(pictureBox26, split);
   
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            
            var arr = new int[10];
                for (int i=0;i<10;i++)
                    arr[i]=0;
            int pick=0;
   
            if (pictureBox2.Visible)
            {
                pick = 2;
                x = 30;
            }
            else if (pictureBox3.Visible)
            {
                pick = 3;
                x = 80;
            }
            else if (pictureBox4.Visible)
            {
                pick = 4;
                x = 45;
            }
            else if (pictureBox5.Visible)
            {
                pick = 5;
                x = 25;
            }
            else if (pictureBox6.Visible)
            {
                pick = 6;
                x = 100;
            }
            else if (pictureBox7.Visible)
            {
                pick = 7;
                x = 100;
            }
            else if (pictureBox8.Visible)
            {
                pick = 8;
                x = 45;
            }
            else if (pictureBox9.Visible)
            {
                pick = 9;
                x = 100;
            }
            else if (pictureBox10.Visible)
            {
                pick = 10;
                x = 15;
            }
            else if (pictureBox11.Visible)
            {
                pick = 11;
                x = 120;
            }
            else if (pictureBox12.Visible)
            {
                pick = 12;
                x = 100;
            }

            else if (pictureBox26.Visible)
            {
                pick = 26;
                x = 55;
            }
            DialogResult result2 = MessageBox.Show("Are you sure you want to make the purchase?",
            "Purchase Query",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            int y;
            int f;
            //Member mem;

            if (result2 == DialogResult.Yes)
            {
                //mem = new Member();

                
                y = Access.Add(A2, x);
               // string W = d.Rows[0][14].ToString();
                //mem.fillPerson(A2);

                f = int.Parse(textBox1.Text);
                x = x + f;
                
             
                textBox1.Text = x.ToString();
                for (int i = 0; i < 10; i++)
                    if (arr[i] == 0)
                    {
                        arr[i] = pick;
                        break;
                    }
            }
            }



        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            if (G2 == 1)
            {
                men M = new men(A2, N2);
                M.Show();
            }
            else
            {
                women W = new women(A2, N2);
                W.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
