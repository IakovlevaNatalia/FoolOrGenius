namespace FoolOrGeniusWinFormsApp.BallGames
{
    partial class MainFormBallGameWinFormsApp
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
            components = new System.ComponentModel.Container();
            stopButton = new System.Windows.Forms.Button();
            timer = new System.Windows.Forms.Timer(components);
            startButton = new System.Windows.Forms.Button();
            clearButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // stopButton
            // 
            stopButton.Location = new System.Drawing.Point(606, 93);
            stopButton.Name = "stopButton";
            stopButton.Size = new System.Drawing.Size(182, 49);
            stopButton.TabIndex = 2;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += button3_Click;
            // 
            // timer
            // 
            timer.Interval = 15;
            // 
            // startButton
            // 
            startButton.Location = new System.Drawing.Point(606, 21);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(182, 50);
            startButton.TabIndex = 3;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
           // startButton.Click += ballsButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new System.Drawing.Point(606, 170);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(182, 46);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // MainFormBallGameWinFormsApp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(startButton);
            Controls.Add(stopButton);
            Name = "MainFormBallGameWinFormsApp";
            Text = "MainFormBallGame";
            Load += MainFormBallGameWinFormsApp_Load;
            MouseDown += MainFormBallGameWinFormsApp_MouseDown;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button clearButton;
    }
}