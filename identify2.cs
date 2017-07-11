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
    public partial class identify2 : Form
    {
        Person person;

        public identify2()
        {
            InitializeComponent();
            label2.Text = "Password";
            label1.Text = "Username";
            button2.Text = "Accept";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string A = "gur";

            if (Worker.Validate_user_password(textBox2.Text, textBox1.Text))
            {
                person = AddPerson.FactoryMethod("Instractor");
                SingelUser.Instance.set_user(person);
                
                instructors F3 = new instructors(textBox2.Text);

                Close();
                F3.Show();
            }
            else
            {
                MessageBox.Show("Name or Password invalid");
            }
        }

        private void identify2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
            mainmenu M = new mainmenu();
            M.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}