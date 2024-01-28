namespace FoolOrGeniusWinFormsApp
{
    partial class ChooseGameForm
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
            FoolOrGeniusLabel = new System.Windows.Forms.Label();
            TwentyFortyEightGameLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // FoolOrGeniusLabel
            // 
            FoolOrGeniusLabel.AutoSize = true;
            FoolOrGeniusLabel.Location = new System.Drawing.Point(70, 82);
            FoolOrGeniusLabel.Name = "FoolOrGeniusLabel";
            FoolOrGeniusLabel.Size = new System.Drawing.Size(106, 20);
            FoolOrGeniusLabel.TabIndex = 0;
            FoolOrGeniusLabel.Text = "Fool Or Genius";
            // 
            // TwentyFortyEightGameLabel
            // 
            TwentyFortyEightGameLabel.AutoSize = true;
            TwentyFortyEightGameLabel.Location = new System.Drawing.Point(402, 91);
            TwentyFortyEightGameLabel.Name = "TwentyFortyEightGameLabel";
            TwentyFortyEightGameLabel.Size = new System.Drawing.Size(41, 20);
            TwentyFortyEightGameLabel.TabIndex = 1;
            TwentyFortyEightGameLabel.Text = "2048";
            TwentyFortyEightGameLabel.Click += TwentyFortyEightGameLabel_Click;
            // 
            // ChooseGameForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(TwentyFortyEightGameLabel);
            Controls.Add(FoolOrGeniusLabel);
            Name = "ChooseGameForm";
            Text = "ChooseGameForm";
            Load += ChooseGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label FoolOrGeniusLabel;
        private System.Windows.Forms.Label TwentyFortyEightGameLabel;
    }
}