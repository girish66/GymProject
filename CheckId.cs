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
    public partial class CheckId : Form
    {
        string us;
        string remove;
        
        public CheckId(string r,string id,string per)
        {
            us=per;
            InitializeComponent();
            textBox2.Text = id;
            remove = r;
            button2.Text = "Accept";
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Member mem;
            int number;
            bool result = Int32.TryParse(textBox2.Text, out number);
            if (remove != "remove" && remove != "Show")
            {
                if (result)
                {
                    if (Member.Exist(textBox2.Text))
                    {
                        //
                        string A = "Edit";
                        string B = textBox2.Text;
                        editmem I = new editmem(A,B,us);
                        Close();
                        I.Show();
                    }
                }
                else
                {
                    MessageBox.Show("הסטודנט לא קיים במערכת");
                }


            }
            else if (remove == "remove")
            {
                if (Member.Exist(textBox2.Text))
                {
                    SingelUser.Instance.get_user().remove(textBox2.Text);
                    MessageBox.Show("המנוי נמחק בהצלחה מהמערכת");
                    memlist I2 = new memlist(us);
                    Close();
                    I2.Show();
                }
                else
                    MessageBox.Show("המנוי לא קיים במערכת");

            }
            else
            {
                if (Member.Exist(textBox2.Text))
                {
                    string A = remove;
                    
                    editmem I2 = new editmem(A, textBox2.Text.ToString(),us);
                    Close();
                    I2.Show();
                } 
                else
                    MessageBox.Show("The member not exist in the ststem");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
            mainmenu F1 = new mainmenu();
            F1.Show();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Close();
            memlist F3 = new memlist(us);
            F3.Show();
        }

       
    }
}
