using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace TheProject
{
    
    class Helper
    {

        public static void SaveImageCapture(System.Drawing.Image image,string id)
        {

                // Save Image 
                string filename = id+".jpg";
                FileStream fstream = new FileStream(filename, FileMode.Create);
                image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();

        }
    }
}
