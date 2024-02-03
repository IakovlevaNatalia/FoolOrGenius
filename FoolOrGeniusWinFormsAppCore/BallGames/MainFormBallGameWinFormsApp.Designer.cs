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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            timer = new System.Windows.Forms.Timer(components);
            ballsButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(580, 44);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(182, 46);
            button1.TabIndex = 0;
            button1.Text = "MoveBall";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(580, 115);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(182, 57);
            button2.TabIndex = 1;
            button2.Text = "Draw Random Ball";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(580, 200);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(182, 49);
            button3.TabIndex = 2;
            button3.Text = "Stop all balls";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timer
            // 
            timer.Interval = 15;
            // 
            // ballsButton
            // 
            ballsButton.Location = new System.Drawing.Point(580, 275);
            ballsButton.Name = "ballsButton";
            ballsButton.Size = new System.Drawing.Size(182, 50);
            ballsButton.TabIndex = 3;
            ballsButton.Text = "Draw many balls";
            ballsButton.UseVisualStyleBackColor = true;
            ballsButton.Click += ballsButton_Click;
            // 
            // MainFormBallGameWinFormsApp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(ballsButton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainFormBallGameWinFormsApp";
            Text = "MainFormBallGame";
            MouseDown += MainFormBallGameWinFormsApp_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button ballsButton;
    }
}