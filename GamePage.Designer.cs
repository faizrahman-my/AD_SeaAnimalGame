﻿
namespace AD_SeaAnimalGame
{
    partial class GamePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePage));
            this.pboxSubmarine = new System.Windows.Forms.PictureBox();
            this.FishSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.NonFishSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.SubmarineMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnCloseGame = new System.Windows.Forms.Button();
            this.panelBackground1 = new System.Windows.Forms.Panel();
            this.lblGameScore = new System.Windows.Forms.Label();
            this.lblNotFishCatch = new System.Windows.Forms.Label();
            this.lblFishCatch = new System.Windows.Forms.Label();
            this.lblGameTImer = new System.Windows.Forms.Label();
            this.panelBackground2 = new System.Windows.Forms.Panel();
            this.submarineHP = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPointEarn = new System.Windows.Forms.Label();
            this.TurtleSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.OctopusSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.CountdownGameTimer = new System.Windows.Forms.Timer(this.components);
            this.FishSpawnTimer2 = new System.Windows.Forms.Timer(this.components);
            this.NotFishSpawnTimer2 = new System.Windows.Forms.Timer(this.components);
            this.panelBackground3 = new System.Windows.Forms.Panel();
            this.lblLevelDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSubmarine)).BeginInit();
            this.panelGameOver.SuspendLayout();
            this.panelBackground1.SuspendLayout();
            this.panelBackground2.SuspendLayout();
            this.panelBackground3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboxSubmarine
            // 
            this.pboxSubmarine.BackColor = System.Drawing.Color.Transparent;
            this.pboxSubmarine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxSubmarine.BackgroundImage")));
            this.pboxSubmarine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxSubmarine.Location = new System.Drawing.Point(750, 507);
            this.pboxSubmarine.Name = "pboxSubmarine";
            this.pboxSubmarine.Size = new System.Drawing.Size(108, 78);
            this.pboxSubmarine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxSubmarine.TabIndex = 9;
            this.pboxSubmarine.TabStop = false;
            // 
            // FishSpawnTimer
            // 
            this.FishSpawnTimer.Enabled = true;
            this.FishSpawnTimer.Interval = 4000;
            this.FishSpawnTimer.Tick += new System.EventHandler(this.FishSpawnTimer_Tick);
            // 
            // NonFishSpawnTimer
            // 
            this.NonFishSpawnTimer.Enabled = true;
            this.NonFishSpawnTimer.Interval = 7500;
            this.NonFishSpawnTimer.Tick += new System.EventHandler(this.NonFishSpawnTimer_Tick);
            // 
            // SubmarineMoveTimer
            // 
            this.SubmarineMoveTimer.Enabled = true;
            this.SubmarineMoveTimer.Interval = 20;
            this.SubmarineMoveTimer.Tick += new System.EventHandler(this.SubmarineMoveTimer_Tick);
            // 
            // panelGameOver
            // 
            this.panelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.panelGameOver.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.bgGameOver;
            this.panelGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGameOver.Controls.Add(this.btnExitGame);
            this.panelGameOver.Controls.Add(this.btnCloseGame);
            this.panelGameOver.Location = new System.Drawing.Point(338, 170);
            this.panelGameOver.Name = "panelGameOver";
            this.panelGameOver.Size = new System.Drawing.Size(337, 220);
            this.panelGameOver.TabIndex = 14;
            this.panelGameOver.Visible = false;
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.Transparent;
            this.btnExitGame.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.buttonbg2;
            this.btnExitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitGame.FlatAppearance.BorderSize = 0;
            this.btnExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGame.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnExitGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExitGame.Location = new System.Drawing.Point(36, 156);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(100, 50);
            this.btnExitGame.TabIndex = 20;
            this.btnExitGame.Text = "Home";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnCloseGame
            // 
            this.btnCloseGame.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseGame.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.buttonbg2;
            this.btnCloseGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseGame.FlatAppearance.BorderSize = 0;
            this.btnCloseGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseGame.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCloseGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCloseGame.Location = new System.Drawing.Point(206, 156);
            this.btnCloseGame.Name = "btnCloseGame";
            this.btnCloseGame.Size = new System.Drawing.Size(100, 50);
            this.btnCloseGame.TabIndex = 19;
            this.btnCloseGame.Text = "Quit";
            this.btnCloseGame.UseVisualStyleBackColor = false;
            this.btnCloseGame.Click += new System.EventHandler(this.btnCloseGame_Click);
            // 
            // panelBackground1
            // 
            this.panelBackground1.BackColor = System.Drawing.Color.Transparent;
            this.panelBackground1.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.bgtemplate;
            this.panelBackground1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackground1.Controls.Add(this.lblGameScore);
            this.panelBackground1.Location = new System.Drawing.Point(863, 9);
            this.panelBackground1.Name = "panelBackground1";
            this.panelBackground1.Size = new System.Drawing.Size(117, 64);
            this.panelBackground1.TabIndex = 15;
            // 
            // lblGameScore
            // 
            this.lblGameScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGameScore.AutoSize = true;
            this.lblGameScore.BackColor = System.Drawing.Color.Transparent;
            this.lblGameScore.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameScore.ForeColor = System.Drawing.Color.Black;
            this.lblGameScore.Location = new System.Drawing.Point(41, 11);
            this.lblGameScore.Name = "lblGameScore";
            this.lblGameScore.Size = new System.Drawing.Size(36, 40);
            this.lblGameScore.TabIndex = 10;
            this.lblGameScore.Text = "0";
            // 
            // lblNotFishCatch
            // 
            this.lblNotFishCatch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNotFishCatch.AutoSize = true;
            this.lblNotFishCatch.BackColor = System.Drawing.Color.Transparent;
            this.lblNotFishCatch.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotFishCatch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNotFishCatch.Location = new System.Drawing.Point(12, 617);
            this.lblNotFishCatch.Name = "lblNotFishCatch";
            this.lblNotFishCatch.Size = new System.Drawing.Size(122, 33);
            this.lblNotFishCatch.TabIndex = 16;
            this.lblNotFishCatch.Text = "NotFish : 0";
            this.lblNotFishCatch.Visible = false;
            // 
            // lblFishCatch
            // 
            this.lblFishCatch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFishCatch.AutoSize = true;
            this.lblFishCatch.BackColor = System.Drawing.Color.Transparent;
            this.lblFishCatch.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFishCatch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFishCatch.Location = new System.Drawing.Point(12, 658);
            this.lblFishCatch.Name = "lblFishCatch";
            this.lblFishCatch.Size = new System.Drawing.Size(87, 33);
            this.lblFishCatch.TabIndex = 17;
            this.lblFishCatch.Text = "Fish : 0";
            this.lblFishCatch.Visible = false;
            // 
            // lblGameTImer
            // 
            this.lblGameTImer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGameTImer.AutoSize = true;
            this.lblGameTImer.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTImer.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTImer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGameTImer.Location = new System.Drawing.Point(32, 14);
            this.lblGameTImer.Name = "lblGameTImer";
            this.lblGameTImer.Size = new System.Drawing.Size(73, 33);
            this.lblGameTImer.TabIndex = 18;
            this.lblGameTImer.Text = "120 s";
            // 
            // panelBackground2
            // 
            this.panelBackground2.BackColor = System.Drawing.Color.Transparent;
            this.panelBackground2.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.bgtemplate;
            this.panelBackground2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackground2.Controls.Add(this.lblGameTImer);
            this.panelBackground2.Location = new System.Drawing.Point(418, 9);
            this.panelBackground2.Name = "panelBackground2";
            this.panelBackground2.Size = new System.Drawing.Size(117, 64);
            this.panelBackground2.TabIndex = 19;
            // 
            // submarineHP
            // 
            this.submarineHP.Location = new System.Drawing.Point(383, 668);
            this.submarineHP.Name = "submarineHP";
            this.submarineHP.Size = new System.Drawing.Size(238, 23);
            this.submarineHP.TabIndex = 20;
            this.submarineHP.Value = 100;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(424, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Submarine  HP";
            // 
            // lblPointEarn
            // 
            this.lblPointEarn.AutoSize = true;
            this.lblPointEarn.BackColor = System.Drawing.Color.Transparent;
            this.lblPointEarn.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointEarn.ForeColor = System.Drawing.Color.Red;
            this.lblPointEarn.Location = new System.Drawing.Point(820, 25);
            this.lblPointEarn.Name = "lblPointEarn";
            this.lblPointEarn.Size = new System.Drawing.Size(27, 33);
            this.lblPointEarn.TabIndex = 22;
            this.lblPointEarn.Text = "-";
            // 
            // TurtleSpawnTimer
            // 
            this.TurtleSpawnTimer.Enabled = true;
            this.TurtleSpawnTimer.Interval = 15000;
            this.TurtleSpawnTimer.Tick += new System.EventHandler(this.TurtleSpawnTimer_Tick);
            // 
            // OctopusSpawnTimer
            // 
            this.OctopusSpawnTimer.Enabled = true;
            this.OctopusSpawnTimer.Interval = 11000;
            this.OctopusSpawnTimer.Tick += new System.EventHandler(this.OctopusSpawnTimer_Tick);
            // 
            // CountdownGameTimer
            // 
            this.CountdownGameTimer.Enabled = true;
            this.CountdownGameTimer.Interval = 1000;
            this.CountdownGameTimer.Tick += new System.EventHandler(this.CountdownGameTimer_Tick);
            // 
            // FishSpawnTimer2
            // 
            this.FishSpawnTimer2.Enabled = true;
            this.FishSpawnTimer2.Interval = 6000;
            this.FishSpawnTimer2.Tick += new System.EventHandler(this.FishSpawnTimer2_Tick);
            // 
            // NotFishSpawnTimer2
            // 
            this.NotFishSpawnTimer2.Enabled = true;
            this.NotFishSpawnTimer2.Interval = 6500;
            this.NotFishSpawnTimer2.Tick += new System.EventHandler(this.NotFishSpawnTimer2_Tick);
            // 
            // panelBackground3
            // 
            this.panelBackground3.BackColor = System.Drawing.Color.Transparent;
            this.panelBackground3.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.bgtemplate;
            this.panelBackground3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackground3.Controls.Add(this.lblLevelDisplay);
            this.panelBackground3.Location = new System.Drawing.Point(863, 91);
            this.panelBackground3.Name = "panelBackground3";
            this.panelBackground3.Size = new System.Drawing.Size(117, 64);
            this.panelBackground3.TabIndex = 23;
            // 
            // lblLevelDisplay
            // 
            this.lblLevelDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLevelDisplay.AutoSize = true;
            this.lblLevelDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelDisplay.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLevelDisplay.Location = new System.Drawing.Point(19, 14);
            this.lblLevelDisplay.Name = "lblLevelDisplay";
            this.lblLevelDisplay.Size = new System.Drawing.Size(84, 33);
            this.lblLevelDisplay.TabIndex = 18;
            this.lblLevelDisplay.Text = "Level 1";
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelBackground3);
            this.Controls.Add(this.lblPointEarn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submarineHP);
            this.Controls.Add(this.panelGameOver);
            this.Controls.Add(this.panelBackground1);
            this.Controls.Add(this.panelBackground2);
            this.Controls.Add(this.lblFishCatch);
            this.Controls.Add(this.pboxSubmarine);
            this.Controls.Add(this.lblNotFishCatch);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GamePage";
            this.Text = "Fish Legends";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePage_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GamePage_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSubmarine)).EndInit();
            this.panelGameOver.ResumeLayout(false);
            this.panelBackground1.ResumeLayout(false);
            this.panelBackground1.PerformLayout();
            this.panelBackground2.ResumeLayout(false);
            this.panelBackground2.PerformLayout();
            this.panelBackground3.ResumeLayout(false);
            this.panelBackground3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pboxSubmarine;
        private System.Windows.Forms.Timer FishSpawnTimer;
        private System.Windows.Forms.Timer NonFishSpawnTimer;
        private System.Windows.Forms.Timer SubmarineMoveTimer;
        private System.Windows.Forms.Panel panelGameOver;
        private System.Windows.Forms.Panel panelBackground1;
        private System.Windows.Forms.Label lblGameScore;
        private System.Windows.Forms.Label lblNotFishCatch;
        private System.Windows.Forms.Label lblFishCatch;
        private System.Windows.Forms.Label lblGameTImer;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnCloseGame;
        private System.Windows.Forms.Panel panelBackground2;
        private System.Windows.Forms.ProgressBar submarineHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPointEarn;
        private System.Windows.Forms.Timer TurtleSpawnTimer;
        private System.Windows.Forms.Timer OctopusSpawnTimer;
        private System.Windows.Forms.Timer CountdownGameTimer;
        private System.Windows.Forms.Timer FishSpawnTimer2;
        private System.Windows.Forms.Timer NotFishSpawnTimer2;
        private System.Windows.Forms.Panel panelBackground3;
        private System.Windows.Forms.Label lblLevelDisplay;
    }
}