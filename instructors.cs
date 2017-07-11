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
    public partial class instructors : Form
    {
        string id;

        public instructors(String A)
        {
            InitializeComponent();
            id = A;

            DataTable T = Access.Get("userName,permission", "users");
            for (int i = 0; i < T.Rows.Count; i++)
            {
                if (T.Rows[i][0].ToString().Equals(id))
                {
                    if (T.Rows[i][1].ToString().Equals("1"))
                    {
                        button4.Visible = false;
                        button6.Visible = false;
                    }
                    if (T.Rows[i][1].ToString().Equals("2"))
                    {
                        button4.Visible = false;
                        button5.Visible = false;
                        button6.Visible = false;
                    }


                }
            }
            
        }

        private void instructors_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //person = AddPerson.FactoryMethod("Instractor");
            //SingelUser.Instance.set_user(person);
            Hide();
            memlist M = new memlist(id);
            M.Show();
        }

        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hide();
            mainmenu M = new mainmenu();
            M.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Logistics L = new Logistics(id);
            Close();
            L.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            follow F = new follow(id);
            F.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            Addelete a = new Addelete(id);
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            PList P = new PList(id);
            P.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            purchase k = new purchase(id);
            k.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Times t1 = new Times(id);
            Close();
            
            t1.Show();
        }
    }
}
