using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectOneMostafaArafa
{
    public partial class FormFleets : Form
    {
        int imageIndex = 1;
        public FormFleets()
        {
            InitializeComponent();
        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            imageIndex++;
            if (imageIndex >= 6)
                imageIndex = 1;
            pictureBox2.ImageLocation = string.Format(@"Yacht\{0}.jpg", imageIndex);
            checkBoat();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            imageIndex--;
            if (imageIndex <= 0)
                imageIndex = 5;
            pictureBox2.ImageLocation = string.Format(@"Yacht\{0}.jpg", imageIndex);
            checkBoat();
        }
        public void checkBoat()
        {
            if (imageIndex == 1)
            {
                lbName.Text = "M/Y: C-Echo II";
                lbStar.Text = "4-Stars";
            }
            else if (imageIndex == 2)
            {
                lbName.Text = "M/Y: Golden D 1";
                lbStar.Text = "3-Stars";
            }
            else if (imageIndex == 3)
            {
                lbName.Text = "M/Y: Golden D 2";
                lbStar.Text = "4-Stars";
            }
            else if (imageIndex == 4)
            {
                lbName.Text = "M/Y: Blue";
                lbStar.Text = "5-Stars";
            }
            else if (imageIndex == 5)
            {
                lbName.Text = "M/Y: Sea Exo";
                lbStar.Text = "5-Stars";
            }
        }
    }
}
