
namespace ProjectOneMostafaArafa
{
    partial class FormReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFleet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxNation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxFirst = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txSc = new System.Windows.Forms.TextBox();
            this.cbRoute = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbThx = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bkgBoat = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbPlan = new System.Windows.Forms.Label();
            this.lbFleet = new System.Windows.Forms.Label();
            this.lbRoute = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbPer = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bkgBoat)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(39, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(432, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Route";
            // 
            // cbPlan
            // 
            this.cbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Items.AddRange(new object[] {
            "3-Stars",
            "4-Stars",
            "5-Stars"});
            this.cbPlan.Location = new System.Drawing.Point(23, 389);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(151, 28);
            this.cbPlan.TabIndex = 11;
            this.cbPlan.SelectedIndexChanged += new System.EventHandler(this.cbPlan_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(821, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Boat (fleet)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(33, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthday;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nationality:";
            // 
            // cbFleet
            // 
            this.cbFleet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFleet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFleet.FormattingEnabled = true;
            this.cbFleet.Items.AddRange(new object[] {
            "C-Echo II",
            "Golden D 1",
            "Golden D 2",
            "Blue",
            "Sea Exo"});
            this.cbFleet.Location = new System.Drawing.Point(805, 389);
            this.cbFleet.Name = "cbFleet";
            this.cbFleet.Size = new System.Drawing.Size(151, 28);
            this.cbFleet.TabIndex = 13;
            this.cbFleet.SelectedIndexChanged += new System.EventHandler(this.cbFleet_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(47, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // btnSub
            // 
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnSub.Location = new System.Drawing.Point(798, 510);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(164, 86);
            this.btnSub.TabIndex = 20;
            this.btnSub.Text = "Submit";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(12, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 50);
            this.label9.TabIndex = 17;
            this.label9.Text = "Trip Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-25, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 10);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TxNation
            // 
            this.TxNation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxNation.Location = new System.Drawing.Point(156, 132);
            this.TxNation.Name = "TxNation";
            this.TxNation.PlaceholderText = "Ex: Egyptian, Spanish and etc";
            this.TxNation.Size = new System.Drawing.Size(402, 27);
            this.TxNation.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(23, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ticket";
            // 
            // TxFirst
            // 
            this.TxFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxFirst.Location = new System.Drawing.Point(156, 88);
            this.TxFirst.Name = "TxFirst";
            this.TxFirst.PlaceholderText = "First name";
            this.TxFirst.Size = new System.Drawing.Size(176, 24);
            this.TxFirst.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(65, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Plan";
            // 
            // txSc
            // 
            this.txSc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txSc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txSc.Location = new System.Drawing.Point(381, 88);
            this.txSc.Name = "txSc";
            this.txSc.PlaceholderText = "Second name";
            this.txSc.Size = new System.Drawing.Size(177, 24);
            this.txSc.TabIndex = 22;
            // 
            // cbRoute
            // 
            this.cbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoute.FormattingEnabled = true;
            this.cbRoute.Items.AddRange(new object[] {
            "RedSea North",
            "St. John Island",
            "Great Island",
            "Daedalus",
            "Satayh",
            "Abu Fandera"});
            this.cbRoute.Location = new System.Drawing.Point(391, 389);
            this.cbRoute.Name = "cbRoute";
            this.cbRoute.Size = new System.Drawing.Size(151, 28);
            this.cbRoute.TabIndex = 12;
            this.cbRoute.SelectedIndexChanged += new System.EventHandler(this.cbRoute_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 181);
            this.dateTimePicker1.MaxDate = new System.DateTime(2004, 1, 20, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2004, 1, 20, 0, 0, 0, 0);
            // 
            // lbThx
            // 
            this.lbThx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbThx.Location = new System.Drawing.Point(798, 599);
            this.lbThx.Name = "lbThx";
            this.lbThx.Size = new System.Drawing.Size(164, 45);
            this.lbThx.TabIndex = 21;
            this.lbThx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Engineer"});
            this.cbGender.Location = new System.Drawing.Point(156, 227);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(151, 28);
            this.cbGender.TabIndex = 23;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.bkgBoat);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lbCost);
            this.panel2.Controls.Add(this.lbPlan);
            this.panel2.Controls.Add(this.lbFleet);
            this.panel2.Controls.Add(this.lbRoute);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lbPer);
            this.panel2.Location = new System.Drawing.Point(1, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 193);
            this.panel2.TabIndex = 24;
            // 
            // bkgBoat
            // 
            this.bkgBoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.bkgBoat.Location = new System.Drawing.Point(431, 0);
            this.bkgBoat.Name = "bkgBoat";
            this.bkgBoat.Size = new System.Drawing.Size(345, 193);
            this.bkgBoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bkgBoat.TabIndex = 30;
            this.bkgBoat.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(22, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 30);
            this.label12.TabIndex = 28;
            this.label12.Text = "Route:";
            // 
            // lbPlan
            // 
            this.lbPlan.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.lbPlan.Location = new System.Drawing.Point(114, 123);
            this.lbPlan.Name = "lbPlan";
            this.lbPlan.Size = new System.Drawing.Size(102, 30);
            this.lbPlan.TabIndex = 27;
            this.lbPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFleet
            // 
            this.lbFleet.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFleet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.lbFleet.Location = new System.Drawing.Point(76, 93);
            this.lbFleet.Name = "lbFleet";
            this.lbFleet.Size = new System.Drawing.Size(178, 30);
            this.lbFleet.TabIndex = 27;
            this.lbFleet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRoute
            // 
            this.lbRoute.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.lbRoute.Location = new System.Drawing.Point(64, 63);
            this.lbRoute.Name = "lbRoute";
            this.lbRoute.Size = new System.Drawing.Size(203, 30);
            this.lbRoute.TabIndex = 27;
            this.lbRoute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(29, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 30);
            this.label14.TabIndex = 26;
            this.label14.Text = "Plan:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(26, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 30);
            this.label13.TabIndex = 26;
            this.label13.Text = "Fleet:";
            // 
            // lbPer
            // 
            this.lbPer.AutoSize = true;
            this.lbPer.Font = new System.Drawing.Font("Poppins Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbPer.Location = new System.Drawing.Point(22, 11);
            this.lbPer.Name = "lbPer";
            this.lbPer.Size = new System.Drawing.Size(0, 42);
            this.lbPer.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(26, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 30);
            this.label11.TabIndex = 26;
            this.label11.Text = "Price:";
            // 
            // lbCost
            // 
            this.lbCost.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.lbCost.Location = new System.Drawing.Point(114, 153);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(102, 30);
            this.lbCost.TabIndex = 27;
            this.lbCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1009, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txSc);
            this.Controls.Add(this.lbThx);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbFleet);
            this.Controls.Add(this.cbRoute);
            this.Controls.Add(this.cbPlan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxNation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxFirst);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReg";
            this.Text = "FormReg";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bkgBoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFleet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxNation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxFirst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txSc;
        private System.Windows.Forms.ComboBox cbRoute;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbThx;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbPlan;
        private System.Windows.Forms.Label lbFleet;
        private System.Windows.Forms.Label lbRoute;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbPer;
        private System.Windows.Forms.PictureBox bkgBoat;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label label11;
    }
}