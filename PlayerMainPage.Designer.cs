﻿
namespace AD_SeaAnimalGame
{
    partial class PlayerMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerMainPage));
            this.panelPMainPage = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPlayNow = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnSkin = new System.Windows.Forms.Button();
            this.panelLogoBackground = new System.Windows.Forms.Panel();
            this.pboxGameLogo = new System.Windows.Forms.PictureBox();
            this.panelLogoBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGameLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPMainPage
            // 
            this.panelPMainPage.BackColor = System.Drawing.Color.Transparent;
            this.panelPMainPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPMainPage.Location = new System.Drawing.Point(0, 0);
            this.panelPMainPage.Name = "panelPMainPage";
            this.panelPMainPage.Size = new System.Drawing.Size(1000, 41);
            this.panelPMainPage.TabIndex = 7;
            this.panelPMainPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPMainPage_MouseDown);
            this.panelPMainPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPMainPage_MouseMove);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.BackgroundImage")));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuit.Location = new System.Drawing.Point(22, 568);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(86, 67);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPlayNow
            // 
            this.btnPlayNow.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayNow.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.buttonbg;
            this.btnPlayNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayNow.FlatAppearance.BorderSize = 0;
            this.btnPlayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayNow.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPlayNow.ForeColor = System.Drawing.Color.White;
            this.btnPlayNow.Location = new System.Drawing.Point(587, 354);
            this.btnPlayNow.Name = "btnPlayNow";
            this.btnPlayNow.Size = new System.Drawing.Size(140, 70);
            this.btnPlayNow.TabIndex = 9;
            this.btnPlayNow.Text = "PLAY NOW";
            this.btnPlayNow.UseVisualStyleBackColor = false;
            this.btnPlayNow.Click += new System.EventHandler(this.btnPlayNow_Click);
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.Transparent;
            this.btnScore.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.buttonbg;
            this.btnScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScore.FlatAppearance.BorderSize = 0;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnScore.ForeColor = System.Drawing.Color.White;
            this.btnScore.Location = new System.Drawing.Point(587, 457);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(140, 70);
            this.btnScore.TabIndex = 10;
            this.btnScore.Text = "SCORE";
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnSkin
            // 
            this.btnSkin.BackColor = System.Drawing.Color.Transparent;
            this.btnSkin.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.buttonbg;
            this.btnSkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkin.FlatAppearance.BorderSize = 0;
            this.btnSkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkin.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSkin.ForeColor = System.Drawing.Color.White;
            this.btnSkin.Location = new System.Drawing.Point(587, 562);
            this.btnSkin.Name = "btnSkin";
            this.btnSkin.Size = new System.Drawing.Size(140, 70);
            this.btnSkin.TabIndex = 11;
            this.btnSkin.Text = "SKIN";
            this.btnSkin.UseVisualStyleBackColor = false;
            this.btnSkin.Click += new System.EventHandler(this.btnSkin_Click);
            // 
            // panelLogoBackground
            // 
            this.panelLogoBackground.BackColor = System.Drawing.Color.Transparent;
            this.panelLogoBackground.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.bluegradient;
            this.panelLogoBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogoBackground.Controls.Add(this.pboxGameLogo);
            this.panelLogoBackground.Location = new System.Drawing.Point(132, 79);
            this.panelLogoBackground.Name = "panelLogoBackground";
            this.panelLogoBackground.Size = new System.Drawing.Size(279, 246);
            this.panelLogoBackground.TabIndex = 13;
            // 
            // pboxGameLogo
            // 
            this.pboxGameLogo.BackColor = System.Drawing.Color.Transparent;
            this.pboxGameLogo.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.FishLegends;
            this.pboxGameLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxGameLogo.Location = new System.Drawing.Point(19, 24);
            this.pboxGameLogo.Name = "pboxGameLogo";
            this.pboxGameLogo.Size = new System.Drawing.Size(235, 205);
            this.pboxGameLogo.TabIndex = 5;
            this.pboxGameLogo.TabStop = false;
            // 
            // PlayerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.boy_fishing;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelLogoBackground);
            this.Controls.Add(this.btnSkin);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnPlayNow);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.panelPMainPage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fish Legends";
            this.panelLogoBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxGameLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPMainPage;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPlayNow;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnSkin;
        private System.Windows.Forms.Panel panelLogoBackground;
        private System.Windows.Forms.PictureBox pboxGameLogo;
    }
}