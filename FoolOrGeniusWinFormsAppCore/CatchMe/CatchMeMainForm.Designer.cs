namespace FoolOrGeniusWinFormsApp.CatchMe
{
    partial class CatchMeMainForm
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
            startButton = new System.Windows.Forms.Button();
            clearButton = new System.Windows.Forms.Button();
            ballsCountLabel = new System.Windows.Forms.Label();
            FinishGameButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new System.Drawing.Point(634, 27);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(126, 49);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new System.Drawing.Point(634, 98);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(126, 58);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // ballsCountLabel
            // 
            ballsCountLabel.AutoSize = true;
            ballsCountLabel.Location = new System.Drawing.Point(559, 27);
            ballsCountLabel.Name = "ballsCountLabel";
            ballsCountLabel.Size = new System.Drawing.Size(17, 20);
            ballsCountLabel.TabIndex = 2;
            ballsCountLabel.Text = "0";
            // 
            // FinishGameButton
            // 
            FinishGameButton.Location = new System.Drawing.Point(634, 176);
            FinishGameButton.Name = "FinishGameButton";
            FinishGameButton.Size = new System.Drawing.Size(126, 56);
            FinishGameButton.TabIndex = 3;
            FinishGameButton.Text = "Finish Game";
            FinishGameButton.UseVisualStyleBackColor = true;
            FinishGameButton.Click += FinishGameButton_Click;
            // 
            // CatchMeMainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(FinishGameButton);
            Controls.Add(ballsCountLabel);
            Controls.Add(clearButton);
            Controls.Add(startButton);
            Name = "CatchMeMainForm";
            Text = "CatchMeMainForm";
            Load += CatchMeMainForm_Load;
            MouseDown += CatchMeMainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label ballsCountLabel;
        private System.Windows.Forms.Button FinishGameButton;
    }
}