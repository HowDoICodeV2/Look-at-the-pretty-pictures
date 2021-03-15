using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowDoICodeV3
{
    public partial class Form1 : Form
    {
        List<string> pictures = new List<string>();
        Form2 imageScreen = new Form2();
        public Form1()
        {
            
            
            InitializeComponent();
        }

        private void fileSelect_Click(object sender, EventArgs e)
        {
            int splitter;
            string folderpath = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                folderpath = fbd.SelectedPath;



                //rip all files out of folder
                string[] files = Directory.GetFiles(folderpath);
                foreach (string file in files)
                {

                    string format = file;
                    //filter non image files
                    splitter = format.LastIndexOf('.');
                    format = format.Substring(splitter + 1);
                    if ((format.Contains("jpg") || format.Contains("gif") || format.Contains("bmp") || format.Contains("png")))
                    {
                        pictures.Add(file);
                        //for display purposes
                        splitter = file.LastIndexOf('\\');
                        imageList.Items.Add(file.Substring(splitter + 1));
                    }


                }
            }
        }

        private void popOutButton_Click(object sender, EventArgs e)
        {
            imageScreen.Show();
        }

        private void folderLocationText_Click(object sender, EventArgs e)
        {

        }

        private void imageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select = imageList.SelectedIndex;

            imageScreen.pictureBoxImageChange(pictures, select);
            ////Second form stuff
            //var oldimage =pictureBox1.Image;
            //if (oldimage != null)
            //{ oldimage.Dispose(); }
            //pictureBox1.Image = Image.FromFile(pictures[select]);
        }
    }
}
