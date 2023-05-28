using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjectOneMostafaArafa
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(36, 42, 52);

            LbX.Text = "Home";
            this.pnlFormLoader.Controls.Clear();
            HomeForm HomeFormX = new HomeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HomeFormX.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(HomeFormX);
            HomeFormX.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(36, 42, 52);

            LbX.Text = "Home";
            this.pnlFormLoader.Controls.Clear();
            HomeForm HomeFormX = new HomeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HomeFormX.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(HomeFormX);
            HomeFormX.Show();
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDes.Height;
            pnlNav.Top = btnDes.Top;
            pnlNav.Left = btnDes.Left;
            btnDes.BackColor = Color.FromArgb(36, 42, 52);

            LbX.Text = "Routes";
            this.pnlFormLoader.Controls.Clear();
            FormDest FormDestX = new FormDest() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormDestX.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FormDestX);
            FormDestX.Show();
        }

        private void btnFleets_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFleets.Height;
            pnlNav.Top = btnFleets.Top;
            pnlNav.Left = btnFleets.Left;
            btnFleets.BackColor = Color.FromArgb(36, 42, 52);

            LbX.Text = "Fleets";
            this.pnlFormLoader.Controls.Clear();
            FormFleets FormFleetsX = new FormFleets() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormFleetsX.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FormFleetsX);
            FormFleetsX.Show();
        }

        private void btnOffers_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnOffers.Height;
            pnlNav.Top = btnOffers.Top;
            pnlNav.Left = btnOffers.Left;
            btnOffers.BackColor = Color.FromArgb(36, 42, 52);

            LbX.Text = "About Us";
            this.pnlFormLoader.Controls.Clear();
            FormAbout FormAboutX = new FormAbout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormAboutX.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FormAboutX);
            FormAboutX.Show();
        }

        private void btnUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnUs.Height;
            pnlNav.Top = btnUs.Top;
            pnlNav.Left = btnUs.Left;
            btnUs.BackColor = Color.FromArgb(36, 42, 52);


            LbX.Text = "Contact Us";
            this.pnlFormLoader.Controls.Clear();
            FormUs FormUsX = new FormUs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormUsX.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FormUsX);
            FormUsX.Show();
        }

         private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(34, 40, 49);
        }

        private void btnDes_Leave(object sender, EventArgs e)
        {
            btnDes.BackColor = Color.FromArgb(34, 40, 49);
        }

        private void btnFleets_Leave(object sender, EventArgs e)
        {
            btnFleets.BackColor = Color.FromArgb(34, 40, 49);
        }

        private void btnOffers_Leave(object sender, EventArgs e)
        {
            btnOffers.BackColor = Color.FromArgb(34, 40, 49);
        }

        private void btnUs_Leave(object sender, EventArgs e)
        {
            btnUs.BackColor = Color.FromArgb(34, 40, 49);
        }


        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnReg_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReg.Height;
            pnlNav.Top = btnReg.Top;
            pnlNav.Left = btnReg.Left;
            btnReg.BackColor = Color.FromArgb(36, 42, 52);

            LbX.Text = "Registration";
            this.pnlFormLoader.Controls.Clear();
            FormReg FormRegX = new FormReg() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormRegX.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FormRegX);
            FormRegX.Show();
        }
        private void btnReg_Leave(object sender, EventArgs e)
        {
            btnUs.BackColor = Color.FromArgb(34, 40, 49);
        }
    }
}
