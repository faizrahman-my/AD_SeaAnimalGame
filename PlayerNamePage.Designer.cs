﻿
namespace AD_SeaAnimalGame
{
    partial class PlayerNamePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerNamePage));
            this.panelPNamePage = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tboxPName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLoginPlayer = new System.Windows.Forms.Button();
            this.btnRegisterPlayer = new System.Windows.Forms.Button();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.lblPName = new System.Windows.Forms.Label();
            this.panelPNamePage.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPNamePage
            // 
            this.panelPNamePage.BackColor = System.Drawing.Color.Transparent;
            this.panelPNamePage.Controls.Add(this.btnClose);
            this.panelPNamePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPNamePage.Location = new System.Drawing.Point(0, 0);
            this.panelPNamePage.Name = "panelPNamePage";
            this.panelPNamePage.Size = new System.Drawing.Size(1000, 41);
            this.panelPNamePage.TabIndex = 3;
            this.panelPNamePage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPNamePage_MouseDown);
            this.panelPNamePage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPNamePage_MouseMove);
            // 
            // btnClose
            // 
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
            // tboxPName
            // 
            this.tboxPName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tboxPName.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tboxPName.Location = new System.Drawing.Point(516, 336);
            this.tboxPName.Multiline = true;
            this.tboxPName.Name = "tboxPName";
            this.tboxPName.Size = new System.Drawing.Size(275, 32);
            this.tboxPName.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 616);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 46);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLoginPlayer
            // 
            this.btnLoginPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoginPlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginPlayer.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.buttonbg;
            this.btnLoginPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginPlayer.FlatAppearance.BorderSize = 0;
            this.btnLoginPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginPlayer.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLoginPlayer.ForeColor = System.Drawing.Color.White;
            this.btnLoginPlayer.Location = new System.Drawing.Point(677, 404);
            this.btnLoginPlayer.Name = "btnLoginPlayer";
            this.btnLoginPlayer.Size = new System.Drawing.Size(114, 80);
            this.btnLoginPlayer.TabIndex = 10;
            this.btnLoginPlayer.Text = "Enter";
            this.btnLoginPlayer.UseVisualStyleBackColor = false;
            this.btnLoginPlayer.Click += new System.EventHandler(this.btnLoginPlayer_Click);
            // 
            // btnRegisterPlayer
            // 
            this.btnRegisterPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegisterPlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnRegisterPlayer.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.buttonbg;
            this.btnRegisterPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegisterPlayer.FlatAppearance.BorderSize = 0;
            this.btnRegisterPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterPlayer.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRegisterPlayer.ForeColor = System.Drawing.Color.White;
            this.btnRegisterPlayer.Location = new System.Drawing.Point(516, 404);
            this.btnRegisterPlayer.Name = "btnRegisterPlayer";
            this.btnRegisterPlayer.Size = new System.Drawing.Size(114, 80);
            this.btnRegisterPlayer.TabIndex = 11;
            this.btnRegisterPlayer.Text = "New Player";
            this.btnRegisterPlayer.UseVisualStyleBackColor = false;
            this.btnRegisterPlayer.Click += new System.EventHandler(this.btnRegisterPlayer_Click);
            // 
            // panelBackground
            // 
            this.panelBackground.AutoSize = true;
            this.panelBackground.BackColor = System.Drawing.Color.Transparent;
            this.panelBackground.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.bgtemplate;
            this.panelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackground.Controls.Add(this.lblPName);
            this.panelBackground.Location = new System.Drawing.Point(567, 221);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(200, 100);
            this.panelBackground.TabIndex = 12;
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.BackColor = System.Drawing.Color.Transparent;
            this.lblPName.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.ForeColor = System.Drawing.Color.Navy;
            this.lblPName.Location = new System.Drawing.Point(17, 35);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(170, 31);
            this.lblPName.TabIndex = 13;
            this.lblPName.Text = "Player Name";
            this.lblPName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerNamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.btnRegisterPlayer);
            this.Controls.Add(this.btnLoginPlayer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tboxPName);
            this.Controls.Add(this.panelPNamePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerNamePage";
            this.Text = "Fish Legends";
            this.panelPNamePage.ResumeLayout(false);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPNamePage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tboxPName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLoginPlayer;
        private System.Windows.Forms.Button btnRegisterPlayer;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label lblPName;
    }
}