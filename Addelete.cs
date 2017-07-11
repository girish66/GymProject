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
    public partial class Addelete : Form
    {
        string us;
        public Addelete(string id)
        {
            us = id;
            InitializeComponent();
           // pictureBox1.Visible = true;
            textBox2.Text = "";
        }

        private void Addelete_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
               
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
             Close();
            instructors I = new instructors("");
            I.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            instructors I2 = new instructors(us);
            I2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (!Worker.Exist(textBox2.Text))
            {
                Close();
                Add A = new Add();
                A.Show();
            }
            else
            {
                MessageBox.Show("User alredy exist");

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Worker.Exist(textBox2.Text))
            {
                SingelUser.Instance.get_user().removeUser(textBox2.Text);
                MessageBox.Show("המנוי נמחק בהצלחה מהמערכת");
            }
            else
                MessageBox.Show("המנוי לא קיים במערכת");
        }
    }
}
