using System;

namespace _2048_v0._1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activerDésactiverTesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valeura = new System.Windows.Forms.TextBox();
            this.valeurb = new System.Windows.Forms.TextBox();
            this.valeurc = new System.Windows.Forms.TextBox();
            this.valeurd = new System.Windows.Forms.TextBox();
            this.Rtasse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelcompteur = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGame,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // NewGame
            // 
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(98, 22);
            this.NewGame.Text = "New";
            this.NewGame.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activerDésactiverTesterToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // activerDésactiverTesterToolStripMenuItem
            // 
            this.activerDésactiverTesterToolStripMenuItem.Name = "activerDésactiverTesterToolStripMenuItem";
            this.activerDésactiverTesterToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.activerDésactiverTesterToolStripMenuItem.Text = "Activer/Désactiver tester";
            this.activerDésactiverTesterToolStripMenuItem.Click += new System.EventHandler(this.activerDésactiverTesterToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.versionToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // valeura
            // 
            this.valeura.Location = new System.Drawing.Point(105, 44);
            this.valeura.Name = "valeura";
            this.valeura.Size = new System.Drawing.Size(57, 20);
            this.valeura.TabIndex = 1;
            // 
            // valeurb
            // 
            this.valeurb.Location = new System.Drawing.Point(168, 44);
            this.valeurb.Name = "valeurb";
            this.valeurb.Size = new System.Drawing.Size(52, 20);
            this.valeurb.TabIndex = 2;
            // 
            // valeurc
            // 
            this.valeurc.Location = new System.Drawing.Point(226, 44);
            this.valeurc.Name = "valeurc";
            this.valeurc.Size = new System.Drawing.Size(48, 20);
            this.valeurc.TabIndex = 3;
            // 
            // valeurd
            // 
            this.valeurd.Location = new System.Drawing.Point(280, 44);
            this.valeurd.Name = "valeurd";
            this.valeurd.Size = new System.Drawing.Size(48, 20);
            this.valeurd.TabIndex = 4;
            // 
            // Rtasse
            // 
            this.Rtasse.Location = new System.Drawing.Point(344, 44);
            this.Rtasse.Name = "Rtasse";
            this.Rtasse.Size = new System.Drawing.Size(100, 20);
            this.Rtasse.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelcompteur
            // 
            this.labelcompteur.AutoSize = true;
            this.labelcompteur.Location = new System.Drawing.Point(13, 81);
            this.labelcompteur.Name = "labelcompteur";
            this.labelcompteur.Size = new System.Drawing.Size(0, 13);
            this.labelcompteur.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 627);
            this.Controls.Add(this.labelcompteur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rtasse);
            this.Controls.Add(this.valeurd);
            this.Controls.Add(this.valeurc);
            this.Controls.Add(this.valeurb);
            this.Controls.Add(this.valeura);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "2048 THE GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGame;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.TextBox valeura;
        private System.Windows.Forms.TextBox valeurb;
        private System.Windows.Forms.TextBox valeurc;
        private System.Windows.Forms.TextBox valeurd;
        private System.Windows.Forms.TextBox Rtasse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem activerDésactiverTesterToolStripMenuItem;
        private System.Windows.Forms.Label labelcompteur;
        //private EventHandler restartToolStripMenuItem_Click;
    }
}

