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
    public partial class TimeTable : Form
    {
        DataTable data;
        string ID;
        public TimeTable(string id)
        {
            InitializeComponent();
            ID = id;
            data = Access.Get("*", "shifts WHERE id= '" + id + "'");
            dataGridView1.DataSource = data;
            DataTable t = new DataTable();
            t = Access.Get("*", "users");
            for(int i = 0; i < t.Rows.Count; i++)
            {
                comboBox2.Items.Add(t.Rows[i][0].ToString()+"   " +t.Rows[i][2].ToString());
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                data = Access.Get("*", "shifts WHERE id= '" + comboBox2.SelectedItem.ToString().Remove(9) + "'");
                dataGridView1.DataSource = data;
            }
            catch {
                Times T = new Times(ID);
                Close();
                T.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString()))
            {
                  DataTable dt;
                  dt = Access.Get("*", "shifts");
                  int key = dt.Rows.Count;
                  key++;
                  //int shifts=0;
                  //if (comboBox1.Text.ToString().Equals("Morning"))
                  //    shifts = 1;
                  //else if (comboBox1.Text.ToString().Equals("Noon"))
                  //    shifts = 2;
                  //else
                  //    shifts = 3;

                      SingelUser.Instance.get_user().timeTable(key.ToString(), ID, textBox1.Text + "/" + textBox2.Text + "/" + textBox3.Text, comboBox1.Text.ToString(), comboBox2.Text);
                  MessageBox.Show("the timetable update succeful");
            }
            else
                 MessageBox.Show("wrong date , try setting on 00/00/0000 format");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeTable_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Times T = new Times(ID);
            Close();
            T.Show();
        }
        private Boolean Validate(string day,string month,string year)
        {
            if (day.ToCharArray().Length == 2 && month.ToCharArray().Length == 2 && year.ToCharArray().Length == 4)
            {
                try
                {
                    Convert.ToInt32(day);
                    Convert.ToInt32(month);
                    Convert.ToInt32(year);

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
                return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeTable T = new TimeTable(ID);
            Close();
            T.Show();
        }
    }
}
