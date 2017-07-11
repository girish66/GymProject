using System;
using System.Collections;
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
    public partial class purchase : Form
    {
        char []temp = new char[10];
        char []temp2 = new char[10];
        char []temp3 = new char[10];
        char [] A,B,C;
        int D;
        string id;
        public purchase(string X)
        {
            InitializeComponent();
            id = X;
            DataTable t = new DataTable();
            t = Access.Get("*", "members");
            Queue Q;
            string print = " ";
            for (int i = 0; i < t.Rows.Count; i++)
            {
                A = t.Rows[i][2].ToString().ToCharArray();
                B = t.Rows[i][3].ToString().ToCharArray();
                C = t.Rows[i][14].ToString().ToCharArray();
                D = Convert.ToInt32(t.Rows[i][14].ToString());

                Q = new Queue();
                for (int j = 0; j < A.Length; j++)
                    Q.Enqueue(A[j]);

                for (int j = 0; j < 20 - A.Length; j++)
                    Q.Enqueue(" ");

                for (int j = 0; j < B.Length; j++)
                    Q.Enqueue(B[j]);

                for (int j = 0; j < 10 - B.Length; j++)
                    Q.Enqueue(" ");

                //for (int j = 0; j < C.Length; j++)
                //    Q.Enqueue(C[j]);
               

                print = " ";
                for (int j = 0; j < Q.Count; j++)
                    print = print + Q.Dequeue().ToString();
                print = print + D.ToString();
                listBox1.Items.Add(print.ToString());
            
                //for (int j = 0; j < 10 - A; j++)
                //{
                //    temp[j] = ' ';
                //}
                //for (int j = 0; j < 10  - B; j++)
                //{
                //    temp2[j] = ' ';
                //}
                //string Temp = new string(temp);
                //string Temp2 = new string(temp2);
                //
               // listBox1.Items.Add(t.Rows[i][1].ToString() + Temp + t.Rows[i][2].ToString() + Temp2 + t.Rows[i][14].ToString());
            }
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
            instructors I=new instructors(id);
            I.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void purchase_Load(object sender, EventArgs e)
        {

        }
    }
}
