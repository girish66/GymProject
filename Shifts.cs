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
    public partial class Shifts : Form
    {
        DataTable Table;
        DateTime date;
        string ID;
        int X;
        
        public Shifts(string id)
        {
            this.Enabled = true;
            InitializeComponent();
            ID = id;
            date=DateTime.Now.Date;
            
            Table = Access.Get("*", "shifts");
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                if(ID.Equals(Table.Rows[i][1].ToString())){
                    label4.Text="Welcome "+Table.Rows[i][4].ToString();
                if (Convert.ToDateTime(Table.Rows[i][2]).Month - date.Month == 1)
                    X = (date.Day + 7) - (Convert.ToDateTime(Table.Rows[i][2]).Day+30);
                else
                    X = date.Day + 7 - Convert.ToDateTime(Table.Rows[i][2]).Day;
                 
                if (X >= 0 && X < 7)
                    switch (Convert.ToDateTime(Table.Rows[i][2]).DayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            {
                                if (Table.Rows[i][3].ToString() == "Morning")
                                    Sunday1.Checked = true;
                                if (Table.Rows[i][3].ToString() == "Noon")
                                    Sunday2.Checked = true;
                                if (Table.Rows[i][3].ToString() == "Evening")
                                    Sunday3.Checked = true;
                               
                                
                                break;
                            }
                        case DayOfWeek.Monday:
                            {
                                if (Table.Rows[i][3].ToString() == "Morning")
                                    Monday1.Checked = true;
                                if (Table.Rows[i][3].ToString() == "Noon")
                                    Monday2.Checked = true;
                                if (Table.Rows[i][3].ToString() == "Evening")
                                    Monday3.Checked = true;
                                break;
                            }
                        case DayOfWeek.Tuesday:
                            {
                                if (Table.Rows[i][3].ToString() == "Morning")
                                    Tuesday1.Checked = true;
                                if (Table.Rows[i][3].ToString() == "Noon")
                                    Tuesday2.Checked = true;
                                if (Table.Rows[i][3].ToString() == "Evening")
                                    Tuesday3.Checked = true;
                                break;
                            }
                        case DayOfWeek.Wednesday:
                            {
                                if (Table.Rows[i][3].ToString() == "Morning")
                                    Wednesday1.Checked = true;
                                if (Table.Rows[i][3].ToString() == "Noon")
                                    Wednesday2.Checked = true;
                                if (Table.Rows[i][3].ToString() == "Evening")
                                    Wednesday3.Checked = true;
                                break;
                            }
                        case DayOfWeek.Thursday:
                            {
                                if (Table.Rows[i][3].ToString() == "Morning")
                                    Thursday1.Checked = true;
                                if (Table.Rows[i][3].ToString() == "Noon")
                                    Thursday2.Checked = true;
                                if (Table.Rows[i][3].ToString() == "Evening")
                                    Thursday3.Checked = true;
                                break;
                            }
                        case DayOfWeek.Friday:
                            {
                                if (Table.Rows[i][3].ToString() == "Morning")
                                    Friday1.Checked = true;
                                if (Table.Rows[i][3].ToString() == "Noon")
                                    Friday2.Checked = true;
                                break;
                            }
                        case DayOfWeek.Saturday:
                            {
                                Saturday3.Checked = true;
                                break;
                            }
                             

                       }
                   }
                   Sunday1.Enabled=false;
                   Sunday2.Enabled=false;
                   Sunday3.Enabled = false;

                   Monday1.Enabled = false;
                   Monday2.Enabled = false;
                   Monday3.Enabled = false;

                   Tuesday1.Enabled = false;
                   Tuesday2.Enabled = false;
                   Tuesday3.Enabled = false;

                   Wednesday1.Enabled = false;
                   Wednesday2.Enabled = false;
                   Wednesday3.Enabled = false;

                   Thursday1.Enabled = false;
                   Thursday2.Enabled = false;
                   Thursday3.Enabled = false;

                   Friday1.Enabled = false;
                   Friday2.Enabled = false;
                   Friday3.Enabled = false;

                   Saturday1.Enabled = false;
                   Saturday2.Enabled = false;
                   Saturday3.Enabled = false;

                
                   
                    
            }
               

        
        }
        
        private void Shifts_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Sunday1_CheckedChanged(object sender, EventArgs e)
        {
            //for(int i=0;i<Table.Rows.Count;i++)
            //    if(Table.Rows[i][1].ToString().Equals(id)&&
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SearchDate.Day = Convert.ToInt32(textBox1.Text.ToString());
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            
            Close();
            Times I = new Times(ID);
            I.Show();
        }
    }
}
