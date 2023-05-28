using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectOneMostafaArafa
{
    public partial class FormAbout : Form
    {
        int imageIndex = 1;
        public FormAbout()
        {
            InitializeComponent();
        }

        private void slider2(object sender, EventArgs e)
        {
            imageIndex++;
            if (imageIndex > 7)
                imageIndex = 1;
            pictureBox1.ImageLocation = string.Format(@"Images2\{0}.jpg", imageIndex);
        }

    }
}
