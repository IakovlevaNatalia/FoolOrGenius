using FoolOrGeniusWinFormsApp.Controls;

namespace FoolOrGeniusWinFormsApp.AngryBirds
{
    partial class AngryBirdsMainForm
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
            ScoreLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Location = new System.Drawing.Point(55, 26);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new System.Drawing.Size(0, 20);
            ScoreLabel.TabIndex = 0;
            // 
            // AngryBirdsMainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(ScoreLabel);
            Name = "AngryBirdsMainForm";
            Text = "AngryBirdsMainForm";
            Shown += AngryBirdsMainForm_Shown;
            MouseDown += AngryBirdsMainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
    }
}