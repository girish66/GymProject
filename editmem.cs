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
    
    public partial class editmem : Form
    {
        //Person member;
        Member mem;
        String B;
        String ID;
        string US;
        public editmem(string A,string id,string us)
        {
            InitializeComponent();
            ID = id;
            US = us;
            B = A;
            mem = new Member();
            if (A.Equals("Edit"))
            {
                mem.fillPerson(id);
                comboBox1.Text = mem.Medical.ToString();
                string permit;
                if (mem.Permission.ToString().Equals("1"))
                    permit = "Silver";
                else if (mem.Permission.ToString().Equals("2"))
                    permit = "Gold";
                else
                    permit = "Platinum";

                comboBox2.Text = permit;
                comboBox3.Text = mem.Workout.ToString();
                comboBox4.Text = mem.Classes.ToString();
                textBox1.Text = mem.Id;
                textBox2.Text = mem.Password;
                textBox3.Text =mem.LastName;
                textBox4.Text = mem.FirstName;
                textBox5.Text = mem.Height;
                comboBox5.Text = mem.Gender;
                textBox7.Text = mem.Age;
                textBox8.Text = mem.Weight;
                textBox11.Text = mem.Bodyfat;// mem.Workout;
                textBox12.Text = mem.Email;

            }
            else if(A.Equals("Show"))
            {
                button1.Visible = false;
                mem.fillPerson(id);
                comboBox1.Text = mem.Medical.ToString();
                string permit;
                if (mem.Permission.ToString().Equals("1"))
                    permit = "Silver";
                else if (mem.Permission.ToString().Equals("2"))
                    permit = "Gold";
                else
                    permit = "Platinum";

                comboBox2.Text = permit;
                comboBox3.Text = mem.Workout.ToString();
                comboBox4.Text = mem.Classes.ToString();
                textBox1.Text = mem.Id;
                textBox2.Text = mem.Password;
                textBox3.Text = mem.LastName;
                textBox4.Text = mem.FirstName;
                textBox5.Text = mem.Height;
                comboBox5.Text = mem.Gender;
                textBox7.Text = mem.Age;
                textBox8.Text = mem.Weight;
                textBox11.Text = mem.Bodyfat;// mem.Workout;
                textBox12.Text = mem.Email;

            }

        }

        private void editmem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString().Length != 9)
                MessageBox.Show("תז הזהות חייבת להיות תקינה , נסה להזין תז בעלת 9 ספרות");
            else
            {
                if (B != "Edit")
                {
                    try
                    {
                        int number = 0;
                        if (number == 0)
                        {
                            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox5.Text == "" || textBox7.Text == "")
                                MessageBox.Show("לא מולאו כל הפרטים");
                            else
                            {
                                int permit;
                                if (comboBox2.Text.ToString().Equals("Silver"))
                                    permit = 1;
                                else if (comboBox2.Text.ToString().Equals("Gold"))
                                    permit = 2;
                                else
                                    permit = 3;
                                if (!Member.Exist(Convert.ToString(textBox1.Text)))
                                {
                                    SingelUser.Instance.get_user().addMember(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, textBox12.Text, permit, textBox4.Text.ToString().Remove(2) + textBox3.Text.ToString().Remove(2), textBox7.Text, textBox8.Text, comboBox5.Text, textBox5.Text, textBox11.Text, comboBox4.Text, comboBox3.Text, comboBox1.Text);
                                    MessageBox.Show("המנוי נוסף בהצלחה");
                                    memlist M = new memlist(B);
                                    this.Close();

                                    M.Show();
                                }
                                else

                                    MessageBox.Show("הסטודנט כבר קיים");
                            }
                        }
                        else
                        {
                            MessageBox.Show("בשדות טלפון ות.ז. יש למלא מספרים בלבד");
                        }

                    }


                    catch 
                    {
                        MessageBox.Show("אחד הפרטים שגויים, נסה להכניס פרטים אמיתיים תייתכן ואחד השדות קצרים מדיי");
                    }
                }
                else
                {//comboBox4
                    int permit;
                    if (comboBox2.Text.ToString().Equals("Silver"))
                        permit = 1;
                    else if (comboBox2.Text.ToString().Equals("Gold"))
                        permit = 2;
                    else
                        permit = 3;
                    SingelUser.Instance.get_user().editMember(mem.Id, textBox1.Text, textBox2.Text,textBox4.Text , textBox3.Text, textBox12.Text, permit, textBox4.Text.ToString().Remove(2) + textBox3.Text.ToString().Remove(2),textBox7.Text, textBox8.Text, comboBox5.Text, textBox5.Text,  textBox11.Text, comboBox4.Text,comboBox3.Text , comboBox1.Text);
                    MessageBox.Show("המנוי עודכן בהצלחה");
                    memlist M = new memlist(B);
                    this.Close();

                    M.Show();
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection connect2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;");
                connect2.Open();
                OleDbCommand command = new OleDbCommand("SELECT user FROM members", connect2);
                OleDbDataReader reader = command.ExecuteReader();
                Boolean A = false;
                while (reader.Read())
                {
                    
                    if (reader["user"].ToString() == textBox1.Text)
                    {
                        A = true;
                        MessageBox.Show("this ID is already Taken");

                    }

                }
                if (A == false)
                {
                    MessageBox.Show("ID O.K :)   plz fill in the required fields and presss save");
                }

                connect2.Close();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
            memlist M = new memlist(B);
            M.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                Form1 F = new Form1(ID);
                F.Show();
            }
            catch { }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        


    }
}
