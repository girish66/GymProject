using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;



namespace TheProject
{
    
    public partial class Form1: Form
    {
        string ID; 
        WebCam webcam;
        public Form1(string id)
        {try {
            InitializeComponent();
            bntVideoFormat.Visible = false;
            bntVideoSource.Visible = false;
            ID = id;
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
             webcam.Start(); }
            catch { MessageBox.Show("the camera could not start, plz advise the secretary or an instructor");
            Close();
            }

        }
       
        private void mainWinForm_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            
        }

        private void bntStop_Click(object sender, EventArgs e)
        {
            
        }

        private void bntContinue_Click(object sender, EventArgs e)
        {
            webcam.Continue();
        }

        private void bntCapture_Click(object sender, EventArgs e)
        {
            imgCapture.Image = imgVideo.Image;
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            Helper.SaveImageCapture(imgCapture.Image,ID);

        }

        private void bntVideoFormat_Click(object sender, EventArgs e)
        {
            webcam.ResolutionSetting();
        }

        private void bntVideoSource_Click(object sender, EventArgs e)
        {
            webcam.AdvanceSetting();
        }

        private void imgVideo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try { webcam.Stop();
            Close();
            }
            catch
            {
                try { webcam.Stop();
                Close();
                }
                catch
                {
                    try { webcam.Stop();
                    Close();
                    }
                    catch { MessageBox.Show("there has been a camera error plz turn it off manualy ");
                    Close();
                    }
                }
            }
            
        }

        
    }
}
