using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectOneMostafaArafa
{
    public partial class HomeForm : Form
    {
        int imageIndex = 1;
        public HomeForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            imageIndex++;
            if (imageIndex > 7)
                imageIndex = 1;
            pictureBox.ImageLocation = string.Format(@"Images\{0}.jpg", imageIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imageIndex--;
            if (imageIndex < 1)
                imageIndex = 7;
            pictureBox.ImageLocation = string.Format(@"Images\{0}.jpg", imageIndex);
        }

    }
}
