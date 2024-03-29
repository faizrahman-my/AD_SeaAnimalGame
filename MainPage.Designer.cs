﻿
namespace AD_SeaAnimalGame
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panelMainPage = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.pboxGameLogo = new System.Windows.Forms.PictureBox();
            this.panelLogoBackground = new System.Windows.Forms.Panel();
            this.panelMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGameLogo)).BeginInit();
            this.panelLogoBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainPage
            // 
            this.panelMainPage.BackColor = System.Drawing.Color.Transparent;
            this.panelMainPage.Controls.Add(this.btnClose);
            this.panelMainPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainPage.Location = new System.Drawing.Point(0, 0);
            this.panelMainPage.Name = "panelMainPage";
            this.panelMainPage.Size = new System.Drawing.Size(1000, 41);
            this.panelMainPage.TabIndex = 2;
            this.panelMainPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMainPage_MouseDown);
            this.panelMainPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMainPage_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(958, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.buttonbg;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(587, 354);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 70);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.Transparent;
            this.btnControl.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.buttonbg;
            this.btnControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnControl.FlatAppearance.BorderSize = 0;
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControl.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnControl.ForeColor = System.Drawing.Color.White;
            this.btnControl.Location = new System.Drawing.Point(587, 457);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(140, 70);
            this.btnControl.TabIndex = 4;
            this.btnControl.Text = "CONTROL";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
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
            // panelLogoBackground
            // 
            this.panelLogoBackground.BackColor = System.Drawing.Color.Transparent;
            this.panelLogoBackground.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.bluegradient;
            this.panelLogoBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogoBackground.Controls.Add(this.pboxGameLogo);
            this.panelLogoBackground.Location = new System.Drawing.Point(132, 79);
            this.panelLogoBackground.Name = "panelLogoBackground";
            this.panelLogoBackground.Size = new System.Drawing.Size(279, 246);
            this.panelLogoBackground.TabIndex = 6;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.boy_fishing;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelLogoBackground);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelMainPage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fish Legends";
            this.panelMainPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxGameLogo)).EndInit();
            this.panelLogoBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainPage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.PictureBox pboxGameLogo;
        private System.Windows.Forms.Panel panelLogoBackground;
    }
}

