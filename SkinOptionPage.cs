﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_SeaAnimalGame
{
    public partial class SkinOptionPage : Form
    {

        public static SkinOptionPage SkinOptionInstance;
        public string skin;
        public SkinOptionPage()
        {
            InitializeComponent();
            SkinOptionInstance = this;
        }

        private Point FormPosition;
        private void panelSkinOptionPage_MouseDown(object sender, MouseEventArgs e)
        {
            this.FormPosition = e.Location;
        }

        private void panelSkinOptionPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Refers to the Form location (or whatever you trigger the event on)
                this.Location = new Point(
                    (this.Location.X - FormPosition.X) + e.X,
                    (this.Location.Y - FormPosition.Y) + e.Y
                );

                this.Update();
            }
        }

        private void btnUse1_Click(object sender, EventArgs e)
        {
            lblPlayerChoice.Text = "Spekter";
            skin = lblPlayerChoice.Text;
        }

        private void btnUse2_Click(object sender, EventArgs e)
        {
            lblPlayerChoice.Text = "Fantom";
            skin = lblPlayerChoice.Text;
        }

        private void btnUse3_Click(object sender, EventArgs e)
        {
            lblPlayerChoice.Text = "Veindal";
            skin = lblPlayerChoice.Text;
        }

        private void SkinOptionPage_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerMainPage pmainpage = new PlayerMainPage();
            pmainpage.Show();
        }
    }
}
