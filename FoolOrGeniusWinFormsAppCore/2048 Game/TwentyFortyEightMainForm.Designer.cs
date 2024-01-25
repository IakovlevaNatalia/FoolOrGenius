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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Score:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new System.Drawing.Point(92, 25);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(17, 20);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // TwentyFortyEightMainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(scoreLabel);
            Controls.Add(label1);
            Name = "TwentyFortyEightMainForm";
            Text = "2048";
            Load += TwentyFortyEightMainFormLoad;
            KeyDown += TwentyFortyEightMainForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label scoreLabel;
    }

}