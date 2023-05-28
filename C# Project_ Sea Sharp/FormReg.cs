using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectOneMostafaArafa
{
    public partial class FormReg : Form
    {
        int flag = 0;
        int FGender = 0;
        int FPlan = 0;
        int FRoute = 0;
        int FFleet = 0;
        public FormReg()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Teal, ButtonBorderStyle.Solid);
        }

        private void cbPlan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FPlan = 1;
            if(flag == 0 || flag == 1)
            {
                flag = 1;
                string v = cbPlan.Text;
                if (v == "3-Stars")
                {
                    cbFleet.Items.Clear();
                    cbFleet.Items.Add("Golden D 1");
                    cbFleet.SelectedItem = "Golden D 1";
                }
                else if (v == "4-Stars")
                {
                    cbFleet.Items.Clear();
                    cbFleet.Items.Add("Golden D 2");
                    cbFleet.Items.Add("C-Echo II");
                }
                else
                {
                    cbFleet.Items.Clear();
                    cbFleet.Items.Add("Sea Exo");
                    cbFleet.Items.Add("Blue");
                }
            }
        }

        private void cbFleet_SelectedIndexChanged(object sender, EventArgs e)
        {
            FFleet = 1;
            if(flag == 0 || flag == 2)
            {
                flag = 2;
                if (cbFleet.Text == "Sea Exo" || cbFleet.Text == "Blue")
                {
                    cbPlan.Items.Clear();
                    cbPlan.Items.Add("5-Stars");
                    cbPlan.SelectedItem = "5-Stars";
                }
                else if (cbFleet.Text == "C-Echo II" || cbFleet.Text == "Golden D 2")
                {
                    cbPlan.Items.Clear();
                    cbPlan.Items.Add("4-Stars");
                    cbPlan.SelectedItem = "4-Stars";
                }
                else
                {
                    cbPlan.Items.Clear();
                    cbPlan.Items.Add("3-Stars");
                    cbPlan.SelectedItem = "3-Stars";
                }
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            if (TxFirst.TextLength >= 1 &&
               TxNation.TextLength >= 5 &&
                txSc.TextLength >= 1 &&
                FFleet == 1 && FGender == 1  && FPlan == 1 && FRoute == 1
               )
            {
                lbThx.ForeColor = System.Drawing.Color.WhiteSmoke;
                lbThx.Text = string.Format("Thanks, {0}", TxFirst.Text);
                postData();
                getData();
            }
            else
            {
                lbThx.ForeColor = System.Drawing.Color.Red;
                lbThx.Text = "Fill all Boxes Properly";
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            FGender = 1;
        }

        private void cbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            FRoute = 1;
        }
        List<Tourist> tourists = new List<Tourist>();
        int c = 0;
        Fleet boatX;
        private void postData()
        {
            if(cbPlan.Text == "3-Stars")
            {
                boatX = new threeStars(cbFleet.Text);
            }
            else if (cbPlan.Text == "4-Stars")
            {
                boatX = new fourStars(cbFleet.Text);
            }
            else
            {
                boatX = new fiveStars(cbFleet.Text);
            }
            var cls = new Trip(TxFirst.Text, txSc.Text, cbGender.Text, dateTimePicker1.Value, cbRoute.Text, cbPlan.Text, cbFleet.Text, TxNation.Text);
            tourists.Add(cls);
            c = tourists.Count;
            TxFirst.ResetText();
            txSc.ResetText();
            TxNation.ResetText();
        }
        private void getData()
        {
            Tourist retrive = tourists[^1];
            lbPer.Text = string.Format("{0} {1}, {2}, {3} YRs", retrive.FirstName, retrive.LastName, retrive.Nation, retrive.Age);
            lbRoute.Text = ((Trip)retrive).Route;
            lbFleet.Text = ((Trip)retrive).Fleet;
            lbPlan.Text = ((Trip)retrive).Plan;
            lbCost.Text = boatX.getCost();
            if(lbFleet.Text == "C-Echo II")
                bkgBoat.ImageLocation = string.Format(@"Yacht\1.jpg");
            else if (lbFleet.Text == "Golden D 1")
                bkgBoat.ImageLocation = string.Format(@"Yacht\2.jpg");
            else if (lbFleet.Text == "Golden D 2")
                bkgBoat.ImageLocation = string.Format(@"Yacht\3.jpg");
            else if (lbFleet.Text == "Blue")
                bkgBoat.ImageLocation = string.Format(@"Yacht\4.jpg");
            else
                bkgBoat.ImageLocation = string.Format(@"Yacht\5.jpg");
        }
    }
}
