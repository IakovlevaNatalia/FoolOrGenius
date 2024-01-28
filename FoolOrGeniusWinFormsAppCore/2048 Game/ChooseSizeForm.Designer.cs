namespace FoolOrGeniusWinFormsApp._2048_Game
{
    partial class ChooseSizeForm
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
            label1 = new System.Windows.Forms.Label();
            FourByFourRadioButton = new System.Windows.Forms.RadioButton();
            FiveByFiveRadioButton = new System.Windows.Forms.RadioButton();
            SixBySixRadioButton = new System.Windows.Forms.RadioButton();
            SevenBySevenRadioButton = new System.Windows.Forms.RadioButton();
            StartButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(273, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Choose The Fild Size";
            // 
            // FourByFourRadioButton
            // 
            FourByFourRadioButton.AutoSize = true;
            FourByFourRadioButton.Location = new System.Drawing.Point(116, 99);
            FourByFourRadioButton.Name = "FourByFourRadioButton";
            FourByFourRadioButton.Size = new System.Drawing.Size(53, 24);
            FourByFourRadioButton.TabIndex = 1;
            FourByFourRadioButton.TabStop = true;
            FourByFourRadioButton.Text = "4x4";
            FourByFourRadioButton.UseVisualStyleBackColor = true;
            // 
            // FiveByFiveRadioButton
            // 
            FiveByFiveRadioButton.AutoSize = true;
            FiveByFiveRadioButton.Location = new System.Drawing.Point(116, 155);
            FiveByFiveRadioButton.Name = "FiveByFiveRadioButton";
            FiveByFiveRadioButton.Size = new System.Drawing.Size(53, 24);
            FiveByFiveRadioButton.TabIndex = 2;
            FiveByFiveRadioButton.TabStop = true;
            FiveByFiveRadioButton.Text = "5x5";
            FiveByFiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // SixBySixRadioButton
            // 
            SixBySixRadioButton.AutoSize = true;
            SixBySixRadioButton.Location = new System.Drawing.Point(351, 99);
            SixBySixRadioButton.Name = "SixBySixRadioButton";
            SixBySixRadioButton.Size = new System.Drawing.Size(53, 24);
            SixBySixRadioButton.TabIndex = 3;
            SixBySixRadioButton.TabStop = true;
            SixBySixRadioButton.Text = "6x6";
            SixBySixRadioButton.UseVisualStyleBackColor = true;
            // 
            // SevenBySevenRadioButton
            // 
            SevenBySevenRadioButton.AutoSize = true;
            SevenBySevenRadioButton.Location = new System.Drawing.Point(351, 155);
            SevenBySevenRadioButton.Name = "SevenBySevenRadioButton";
            SevenBySevenRadioButton.Size = new System.Drawing.Size(53, 24);
            SevenBySevenRadioButton.TabIndex = 4;
            SevenBySevenRadioButton.TabStop = true;
            SevenBySevenRadioButton.Text = "7x7";
            SevenBySevenRadioButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            StartButton.Location = new System.Drawing.Point(218, 241);
            StartButton.Name = "StartButton";
            StartButton.Size = new System.Drawing.Size(165, 82);
            StartButton.TabIndex = 5;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // ChooseSizeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(StartButton);
            Controls.Add(SevenBySevenRadioButton);
            Controls.Add(SixBySixRadioButton);
            Controls.Add(FiveByFiveRadioButton);
            Controls.Add(FourByFourRadioButton);
            Controls.Add(label1);
            Name = "ChooseSizeForm";
            Text = "ChooseSizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton FourByFourRadioButton;
        private System.Windows.Forms.RadioButton FiveByFiveRadioButton;
        private System.Windows.Forms.RadioButton SixBySixRadioButton;
        private System.Windows.Forms.RadioButton SevenBySevenRadioButton;
        private System.Windows.Forms.Button StartButton;
    }
}