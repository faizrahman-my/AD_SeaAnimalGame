﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing;

namespace AD_SeaAnimalGame
{
    public partial class GamePage : Form
    {


        Random randomSpawn = new Random();
        List<PictureBox> fish = new List<PictureBox>();
        List<PictureBox> notfish = new List<PictureBox>();
        List<PictureBox> octopus = new List<PictureBox>();
        List<PictureBox> seaTurtle = new List<PictureBox>();

        public GamePage()
        {
            InitializeComponent();
        }



        private void FishSpawn()
        {
            //spawn new pic box for fish object
            PictureBox normalFish = new PictureBox();
            normalFish.Height = 50;
            normalFish.Width = 50;
            normalFish.Image = Properties.Resources.bluefish;
            normalFish.SizeMode = PictureBoxSizeMode.StretchImage;
            normalFish.BackColor = Color.Transparent;

            int x = randomSpawn.Next(10, this.ClientSize.Width - normalFish.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - normalFish.Height);
            normalFish.Location = new Point(x, y);

            fish.Add(normalFish);
            this.Controls.Add(normalFish);
            
        }


        private void NotFishSpawn()
        {
            //spawn new pic box for random object
            PictureBox notFish = new PictureBox();
            notFish.Height = 50;
            notFish.Width = 50;
            notFish.Image = Properties.Resources.trash;
            notFish.SizeMode = PictureBoxSizeMode.StretchImage;
            notFish.BackColor = Color.Transparent;

            int x = randomSpawn.Next(10, this.ClientSize.Width - notFish.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - notFish.Height);
            notFish.Location = new Point(x, y);

            notfish.Add(notFish);
            this.Controls.Add(notFish);
        }

        private void OctopusSpawn()
        {
            //spawn new pic box for octopus object
            PictureBox Octopus = new PictureBox();
            Octopus.Height = 50;
            Octopus.Width = 50;
            Octopus.Image = Properties.Resources.octopus;
            Octopus.SizeMode = PictureBoxSizeMode.StretchImage;
            Octopus.BackColor = Color.Transparent;

            int x = randomSpawn.Next(10, this.ClientSize.Width - Octopus.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - Octopus.Height);
            Octopus.Location = new Point(x, y);

            octopus.Add(Octopus);
            this.Controls.Add(Octopus);

        }

        private void SeaTurtleSpawn()
        {
            //spawn new pic box for sea turtle object
            PictureBox SeaTurtle = new PictureBox();
            SeaTurtle.Height = 50;
            SeaTurtle.Width = 50;
            SeaTurtle.Image = Properties.Resources.seaturtle;
            SeaTurtle.SizeMode = PictureBoxSizeMode.StretchImage;
            SeaTurtle.BackColor = Color.Transparent;

            int x = randomSpawn.Next(10, this.ClientSize.Width - SeaTurtle.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - SeaTurtle.Height);
            SeaTurtle.Location = new Point(x, y);

            seaTurtle.Add(SeaTurtle);
            this.Controls.Add(SeaTurtle);

        }

        //---------------Event-----------------\\


        //<<<<<<<<<<<<Game Movement>>>>>>>>>>>>>>>\\

        bool submarineUp, submarineDown, submarineLeft, submarineRight;

        int submarineSpeed = 12;

        private void GamePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                submarineLeft = true;
                pboxSubmarine.Image = Properties.Resources.submarineleft;
            }
            if (e.KeyCode == Keys.D)
            {
                submarineRight = true;
                pboxSubmarine.Image = Properties.Resources.submarineright;
            }
            if (e.KeyCode == Keys.W)
            {
                submarineUp = true;
                pboxSubmarine.Image = Properties.Resources.submarineup;
            }
            if (e.KeyCode == Keys.S)
            {
                submarineDown = true;
                pboxSubmarine.Image = Properties.Resources.submarinedown;
            }
        }

        private void GamePage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                submarineLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                submarineRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                submarineUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                submarineDown = false;
            }
        }



        //<<<<<<<<<<<<Timer for fish to spawn in a time set>>>>>>>>>>>>>>>\\

        private void FishSpawnTimer_Tick(object sender, EventArgs e)
        {
            FishSpawn();
            
            
        }

        //<<<<<<<<<<<<Timer for random object to spawn in a time set>>>>>>>>>>>>>>>\\

        private void NonFishSpawnTimer_Tick(object sender, EventArgs e)
        {
            NotFishSpawn();
        }



        int playerScore = 0;

        private static int TimeCounter = 60;

        
        

        //<<<<<<<<<<<<Timer for game countdown for game to end>>>>>>>>>>>>>>>\\
        private void timerCountdownGame_Tick(object sender, EventArgs e)
        {
            lblGameTImer.Text = String.Format("{0} s", TimeCounter);

            

            if(TimeCounter > 0)
            {
                timerCountdownGame.Start();

                
                TimeCounter--;
            }
            else if(TimeCounter == 0)
            {
                timerCountdownGame.Stop();
                FishSpawnTimer.Stop();
                NonFishSpawnTimer.Stop();
                SubmarineMoveTimer.Stop();
                panelGameOver.Visible = true;
            }
        }

        //<<<<<<<<<<<<Button for game to close>>>>>>>>>>>>>>>\\
        private void btnCloseGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
            TimeCounter = 60;
        }

        //<<<<<<<<<<<<Button to return to main menu page>>>>>>>>>>>>>>>\\
        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerMainPage pmainpage = new PlayerMainPage();
            pmainpage.Show();

            TimeCounter = 60;
        }

        int wrongCatch = 0;

        private void SeaTurtleTimer_Tick(object sender, EventArgs e)
        {
            SeaTurtleSpawn();
        }

        private void OctupusSpawnTimer_Tick(object sender, EventArgs e)
        {
            OctopusSpawn();
        }

        private void AnimalSpawnTime_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox fishpb in fish.ToList())
            {
                if (pboxSubmarine.Bounds.IntersectsWith(fishpb.Bounds) == false)
                {

                    fish.Remove(fishpb);
                    this.Controls.Remove(fishpb);


                }
            }
        }

        private void octopusDisappearTimer_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox octopuspb in octopus.ToList())
            {
                if (pboxSubmarine.Bounds.IntersectsWith(octopuspb.Bounds) == false)
                {

                    octopus.Remove(octopuspb);
                    this.Controls.Remove(octopuspb);


                }
            }
        }

        private void SeaTurtleDisappearTimer_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox seaturtlepb in seaTurtle.ToList())
            {
                if (pboxSubmarine.Bounds.IntersectsWith(seaturtlepb.Bounds) == false)
                {
                    seaTurtle.Remove(seaturtlepb);
                    this.Controls.Remove(seaturtlepb);


                }
            }
        }

        int correctCatch = 0;


        int playerHP = 100;
        
        //<<<<<<<<<<<<Timer for submarine movement and the function of submarine>>>>>>>>>>>>>>>\\
        private void SubmarineMoveTimer_Tick(object sender, EventArgs e)
        {
            if (submarineLeft == true && pboxSubmarine.Left > 0)
            {
                pboxSubmarine.Left -= submarineSpeed;
            }

            if (submarineRight == true && pboxSubmarine.Left < 892)
            {
                pboxSubmarine.Left += submarineSpeed;
            }

            if (submarineUp == true && pboxSubmarine.Top > 0)
            {
                pboxSubmarine.Top -= submarineSpeed;
            }

            if (submarineDown == true && pboxSubmarine.Top < 600)
            {
                pboxSubmarine.Top += submarineSpeed;
            }

            lblGameScore.Text = "" + playerScore;
            lblNotFishCatch.Text = "NotFish: " + wrongCatch;
            lblFishCatch.Text = "Fish: " + correctCatch;


            submarineHP.Value = Convert.ToInt32(playerHP);

            //remove fish when intersect  with submarine
            foreach (PictureBox fishpb in fish.ToList())
            {
                if (pboxSubmarine.Bounds.IntersectsWith(fishpb.Bounds))
                {
                    
                    fish.Remove(fishpb);
                    this.Controls.Remove(fishpb);

                    correctCatch++;
                    wrongCatch = 0;

                    playerScore = correctCatch + wrongCatch;
                    playerHP = 100;
                    pointLbl.Text = "+1";

                    SoundPlayer player = new SoundPlayer(Properties.Resources.correct);
                    player.Play();


                }

            }

            //remove octopus when intersect  with submarine
            foreach (PictureBox octopuspb in octopus.ToList())
            {
                if (pboxSubmarine.Bounds.IntersectsWith(octopuspb.Bounds))
                {

                    octopus.Remove(octopuspb);
                    this.Controls.Remove(octopuspb);

                    correctCatch+=2;
                    wrongCatch = 0;

                    playerScore = correctCatch + wrongCatch;
                    playerHP = 100;
                    pointLbl.Text = "+2";

                    SoundPlayer player = new SoundPlayer(Properties.Resources.correct);
                    player.Play();
                }

            }

            //remove sea turtle when intersect  with submarine
            foreach (PictureBox seaturtlepb in seaTurtle.ToList())
            {
                if (pboxSubmarine.Bounds.IntersectsWith(seaturtlepb.Bounds))
                {

                    seaTurtle.Remove(seaturtlepb);
                    this.Controls.Remove(seaturtlepb);

                    correctCatch += 3;
                    wrongCatch = 0;

                    playerScore = correctCatch + wrongCatch;
                    playerHP = 100;
                    pointLbl.Text = "+3";

                    SoundPlayer player = new SoundPlayer(Properties.Resources.correct);
                    player.Play();
                }

            }


            //remove random object when intersect  with submarine
            foreach (PictureBox notfishpb in notfish.ToList())
            {
                if (pboxSubmarine.Bounds.IntersectsWith(notfishpb.Bounds))
                {
                    
                    notfish.Remove(notfishpb);
                    this.Controls.Remove(notfishpb);

                    SoundPlayer player = new SoundPlayer(Properties.Resources.wrong);
                    player.Play();
                    pointLbl.Text = "-1";
                    playerHP -= 20;
                    wrongCatch++;
                    correctCatch--;
                    playerScore = correctCatch;

                    if (playerScore < 0)
                    {
                        playerScore = 0;
                    }

                    if (correctCatch < 0)
                    {
                        correctCatch = 0;
                    }

                    if (wrongCatch == 5)
                    {

                        timerCountdownGame.Stop();
                        FishSpawnTimer.Stop();
                        NonFishSpawnTimer.Stop();
                        SubmarineMoveTimer.Stop();
                        panelGameOver.Visible = true;

                    }
                }

            }
        }
    }
}
