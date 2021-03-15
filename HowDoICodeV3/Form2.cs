using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HowDoICodeV3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void pictureBoxImageChange(List<string> pictures, int select)
        {
            var oldimage = pictureBox1.Image;
            if (oldimage != null)
            { oldimage.Dispose(); }
            pictureBox1.Image = Image.FromFile(pictures[select]);
        }

        private void zoomButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
