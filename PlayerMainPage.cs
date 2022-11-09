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
    public partial class PlayerMainPage : Form
    {
        private Point windowLocation;
        public PlayerMainPage()
        {
            InitializeComponent();
        }

        private void panelPMainPage_MouseDown(object sender, MouseEventArgs e)
        {
            this.windowLocation = e.Location;
        }

        private void panelPMainPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Refers to the Form location (or whatever you trigger the event on)
                this.Location = new Point(
                    (this.Location.X - windowLocation.X) + e.X,
                    (this.Location.Y - windowLocation.Y) + e.Y
                );

                this.Update();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            

            DialogResult logoutConfirmation = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.OKCancel);

            if (logoutConfirmation == DialogResult.OK)
            {
                this.Hide();
                MainPage mainpage = new MainPage();
                mainpage.Show();
                Application.Restart();
            }
        }

        private void btnPlayNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamePage gamepage = new GamePage();
            gamepage.Show();
        }

        private void btnSkin_Click(object sender, EventArgs e)
        {
            this.Hide();
            SkinOptionPage skinoptionpage = new SkinOptionPage();
            skinoptionpage.Show();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScorePage scorepage = new ScorePage();
            scorepage.Show();
        }
    }
}
