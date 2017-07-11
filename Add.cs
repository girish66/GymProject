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
    public partial class Add : Form
    {
        public Add()
        {


            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.ToString().Length != 9)
                MessageBox.Show(" תז חייבת להכיל 9 ספרות בלבד , נסה שוב");
            else
            {
                try
                {
                    if (!Worker.Exist(textBox9.Text))
                    {
                        SingelUser.Instance.get_user().addUser(textBox9.Text, textBox5.Text, textBox1.Text, textBox2.Text, 1, textBox4.Text, textBox3.Text, comboBox1.Text, textBox7.Text, textBox6.Text);
                        MessageBox.Show("Successfully added");
                    }
                    else
                        MessageBox.Show("The user is allready exist");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + "Not added");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.ToString().Length != 9)
                MessageBox.Show(" תז חייבת להכיל 9 ספרות בלבד , נסה שוב");
            else
            {
                try
                {
                    if (!Worker.Exist(textBox9.Text))
                    {
                        SingelUser.Instance.get_user().addUser(textBox9.Text, textBox5.Text, textBox1.Text, textBox2.Text, 3, textBox4.Text, textBox3.Text, comboBox1.Text, textBox7.Text, textBox6.Text);
                        MessageBox.Show("Successfully added");
                    }
                    else
                        MessageBox.Show("The user is allready exist");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + "Not added");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox9.Text.ToString().Length != 9)
                MessageBox.Show(" תז חייבת להכיל 9 ספרות בלבד , נסה שוב");
            else
            {
                try
                {
                    if (!Worker.Exist(textBox9.Text))
                    {
                        SingelUser.Instance.get_user().addUser(textBox9.Text, textBox5.Text, textBox1.Text, textBox2.Text, 2, textBox4.Text, textBox3.Text, comboBox1.Text, textBox7.Text, textBox6.Text);
                        MessageBox.Show("Successfully added");
                    }
                    else
                        MessageBox.Show("The user is allready exist");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + "Not added");
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string a = "";
            Close();
            instructors A = new instructors(a);
            A.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
