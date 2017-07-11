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
    public partial class PList : Form
    {
        string id;
        public PList(string A)
        {
            InitializeComponent();
            id = A;
            DataTable t = new DataTable();
            t = Access.Get("*", "users");
            for(int i=0;i<t.Rows.Count;i++)
                listBox1.Items.Add(t.Rows[i][0].ToString() +" "+ t.Rows[i][1].ToString() +" "+ t.Rows[i][2].ToString());
            DataTable t2 = new DataTable();
            t2 = Access.Get("*", "members");
            for (int i = 0; i < t2.Rows.Count; i++)
                listBox2.Items.Add(t2.Rows[i][0].ToString() + " " + t2.Rows[i][2].ToString() + " " + t2.Rows[i][3].ToString());
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hide();
            instructors i = new instructors(id);
            i.Show();

        }

        private void PList_Load(object sender, EventArgs e)
        {

        }
    }
}
