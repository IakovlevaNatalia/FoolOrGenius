using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.Frog
{
    partial class FrogMainForm
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
            leftrPictureBox1 = new PictureBox();
            leftrPictureBox2 = new PictureBox();
            leftrPictureBox3 = new PictureBox();
            leftrPictureBox4 = new PictureBox();
            emptyPictureBox = new PictureBox();
            rightPictureBox1 = new PictureBox();
            rightPictureBox2 = new PictureBox();
            rightPictureBox3 = new PictureBox();
            rightPictureBox4 = new PictureBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            rulesToolStripMenuItem = new ToolStripMenuItem();
            scoreLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)leftrPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftrPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftrPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftrPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptyPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox4).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // leftrPictureBox1
            // 
            leftrPictureBox1.Image = Resources.leftFrog;
            leftrPictureBox1.Location = new System.Drawing.Point(0, 54);
            leftrPictureBox1.Name = "leftrPictureBox1";
            leftrPictureBox1.Size = new System.Drawing.Size(110, 110);
            leftrPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            leftrPictureBox1.TabIndex = 0;
            leftrPictureBox1.TabStop = false;
            leftrPictureBox1.Click += PictureBox_Click;
            // 
            // leftrPictureBox2
            // 
            leftrPictureBox2.Image = Resources.leftFrog;
            leftrPictureBox2.Location = new System.Drawing.Point(110, 54);
            leftrPictureBox2.Name = "leftrPictureBox2";
            leftrPictureBox2.Size = new System.Drawing.Size(110, 110);
            leftrPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            leftrPictureBox2.TabIndex = 1;
            leftrPictureBox2.TabStop = false;
            leftrPictureBox2.Click += PictureBox_Click;
            // 
            // leftrPictureBox3
            // 
            leftrPictureBox3.Image = Resources.leftFrog;
            leftrPictureBox3.Location = new System.Drawing.Point(220, 54);
            leftrPictureBox3.Name = "leftrPictureBox3";
            leftrPictureBox3.Size = new System.Drawing.Size(110, 110);
            leftrPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            leftrPictureBox3.TabIndex = 2;
            leftrPictureBox3.TabStop = false;
            leftrPictureBox3.Click += PictureBox_Click;
            // 
            // leftrPictureBox4
            // 
            leftrPictureBox4.Image = Resources.leftFrog;
            leftrPictureBox4.Location = new System.Drawing.Point(330, 54);
            leftrPictureBox4.Name = "leftrPictureBox4";
            leftrPictureBox4.Size = new System.Drawing.Size(110, 110);
            leftrPictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            leftrPictureBox4.TabIndex = 4;
            leftrPictureBox4.TabStop = false;
            leftrPictureBox4.Click += PictureBox_Click;
            // 
            // emptyPictureBox
            // 
            emptyPictureBox.Image = Resources.emptyWaterLily;
            emptyPictureBox.Location = new System.Drawing.Point(440, 54);
            emptyPictureBox.Name = "emptyPictureBox";
            emptyPictureBox.Size = new System.Drawing.Size(110, 110);
            emptyPictureBox.TabIndex = 5;
            emptyPictureBox.TabStop = false;
            emptyPictureBox.Click += pictureBox6_Click;
            // 
            // rightPictureBox1
            // 
            rightPictureBox1.Image = Resources.rightFrog;
            rightPictureBox1.Location = new System.Drawing.Point(550, 54);
            rightPictureBox1.Name = "rightPictureBox1";
            rightPictureBox1.Size = new System.Drawing.Size(110, 110);
            rightPictureBox1.TabIndex = 6;
            rightPictureBox1.TabStop = false;
            rightPictureBox1.Click += PictureBox_Click;
            // 
            // rightPictureBox2
            // 
            rightPictureBox2.Image = Resources.rightFrog;
            rightPictureBox2.Location = new System.Drawing.Point(660, 54);
            rightPictureBox2.Name = "rightPictureBox2";
            rightPictureBox2.Size = new System.Drawing.Size(110, 110);
            rightPictureBox2.TabIndex = 7;
            rightPictureBox2.TabStop = false;
            rightPictureBox2.Click += PictureBox_Click;
            // 
            // rightPictureBox3
            // 
            rightPictureBox3.Image = Resources.rightFrog;
            rightPictureBox3.Location = new System.Drawing.Point(770, 54);
            rightPictureBox3.Name = "rightPictureBox3";
            rightPictureBox3.Size = new System.Drawing.Size(110, 110);
            rightPictureBox3.TabIndex = 8;
            rightPictureBox3.TabStop = false;
            rightPictureBox3.Click += PictureBox_Click;
            // 
            // rightPictureBox4
            // 
            rightPictureBox4.Image = Resources.rightFrog;
            rightPictureBox4.Location = new System.Drawing.Point(880, 54);
            rightPictureBox4.Name = "rightPictureBox4";
            rightPictureBox4.Size = new System.Drawing.Size(110, 110);
            rightPictureBox4.TabIndex = 9;
            rightPictureBox4.TabStop = false;
            rightPictureBox4.Click += PictureBox_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, rulesToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(990, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // rulesToolStripMenuItem
            // 
            rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            rulesToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            rulesToolStripMenuItem.Text = "Rules";
            rulesToolStripMenuItem.Click += rulesToolStripMenuItem_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new System.Drawing.Point(403, 341);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(17, 20);
            scoreLabel.TabIndex = 11;
            scoreLabel.Text = "0";
            // 
            // FrogMainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(990, 448);
            Controls.Add(scoreLabel);
            Controls.Add(rightPictureBox4);
            Controls.Add(rightPictureBox3);
            Controls.Add(rightPictureBox2);
            Controls.Add(rightPictureBox1);
            Controls.Add(emptyPictureBox);
            Controls.Add(leftrPictureBox4);
            Controls.Add(leftrPictureBox3);
            Controls.Add(leftrPictureBox2);
            Controls.Add(leftrPictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrogMainForm";
            Text = "Frog";
            Load += FrogMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)leftrPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftrPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftrPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftrPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptyPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox4).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox leftrPictureBox1;
        private System.Windows.Forms.PictureBox leftrPictureBox2;
        private System.Windows.Forms.PictureBox leftrPictureBox3;
        private System.Windows.Forms.PictureBox leftrPictureBox4;
        private System.Windows.Forms.PictureBox emptyPictureBox;
        private System.Windows.Forms.PictureBox rightPictureBox1;
        private System.Windows.Forms.PictureBox rightPictureBox2;
        private System.Windows.Forms.PictureBox rightPictureBox3;
        private System.Windows.Forms.PictureBox rightPictureBox4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private Label scoreLabel;
    }
}