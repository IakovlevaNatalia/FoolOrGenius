using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp._2048_Game
{
    partial class TwentyFortyEightMainForm:Form

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
            label1 = new Label();
            scoreLabel = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            rulesToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            showResultsToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            bestScoreLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Score:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new System.Drawing.Point(67, 50);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(17, 20);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, showResultsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rulesToolStripMenuItem, restartToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // rulesToolStripMenuItem
            // 
            rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            rulesToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            rulesToolStripMenuItem.Text = "Rules";
            rulesToolStripMenuItem.Click += rulesToolStripMenuItem_Click;
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            restartToolStripMenuItem.Text = "Restart";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // showResultsToolStripMenuItem
            // 
            showResultsToolStripMenuItem.Name = "showResultsToolStripMenuItem";
            showResultsToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            showResultsToolStripMenuItem.Text = "Show Results";
            showResultsToolStripMenuItem.Click += showResultsToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(131, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Best Score:";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Location = new System.Drawing.Point(218, 50);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new System.Drawing.Size(17, 20);
            bestScoreLabel.TabIndex = 4;
            bestScoreLabel.Text = "0";
            // 
            // TwentyFortyEightMainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(bestScoreLabel);
            Controls.Add(label2);
            Controls.Add(scoreLabel);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TwentyFortyEightMainForm";
            Text = "2048";
            Load += TwentyFortyEightMainFormLoad;
            KeyDown += TwentyFortyEightMainForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label scoreLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem showResultsToolStripMenuItem;
        private Label label2;
        private Label bestScoreLabel;
    }

}