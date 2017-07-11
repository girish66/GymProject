using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace TheProject
{
    public partial class Camera : Form
    {
        WebCam webcam;
        string ID;
        public Camera(string id)
        {
            InitializeComponent();
            ID = id;
            
        }
           
        private void Form1_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imgCapture.Image = imgVideo.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    SqlCeConnection cnn = new SqlCeConnection(Properties.Settings.Default.ImageDataBaseConnectionString);


        //    //byte[] imgData;

        //    SqlCeCommand cmd = new SqlCeCommand("INSERT INTO imagetbl (Pics) VALUES (@DATA)", cnn);
        //    cmd.Parameters.Add("@DATA",);
        //}
    }
}
