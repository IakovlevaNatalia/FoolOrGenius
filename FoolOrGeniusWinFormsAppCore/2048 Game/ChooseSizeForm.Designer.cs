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
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            closeButton = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(161, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(374, 45);
            label1.TabIndex = 0;
            label1.Text = "Choose The Fild Size";
            // 
            // FourByFourRadioButton
            // 
            FourByFourRadioButton.AutoSize = true;
            FourByFourRadioButton.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FourByFourRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            FourByFourRadioButton.Location = new System.Drawing.Point(172, 266);
            FourByFourRadioButton.Name = "FourByFourRadioButton";
            FourByFourRadioButton.Size = new System.Drawing.Size(100, 50);
            FourByFourRadioButton.TabIndex = 1;
            FourByFourRadioButton.TabStop = true;
            FourByFourRadioButton.Text = "4x4";
            FourByFourRadioButton.UseVisualStyleBackColor = true;
            // 
            // FiveByFiveRadioButton
            // 
            FiveByFiveRadioButton.AutoSize = true;
            FiveByFiveRadioButton.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FiveByFiveRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            FiveByFiveRadioButton.Location = new System.Drawing.Point(172, 355);
            FiveByFiveRadioButton.Name = "FiveByFiveRadioButton";
            FiveByFiveRadioButton.Size = new System.Drawing.Size(100, 50);
            FiveByFiveRadioButton.TabIndex = 2;
            FiveByFiveRadioButton.TabStop = true;
            FiveByFiveRadioButton.Text = "5x5";
            FiveByFiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // SixBySixRadioButton
            // 
            SixBySixRadioButton.AutoSize = true;
            SixBySixRadioButton.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            SixBySixRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            SixBySixRadioButton.Location = new System.Drawing.Point(408, 266);
            SixBySixRadioButton.Name = "SixBySixRadioButton";
            SixBySixRadioButton.Size = new System.Drawing.Size(100, 50);
            SixBySixRadioButton.TabIndex = 3;
            SixBySixRadioButton.TabStop = true;
            SixBySixRadioButton.Text = "6x6";
            SixBySixRadioButton.UseVisualStyleBackColor = true;
            // 
            // SevenBySevenRadioButton
            // 
            SevenBySevenRadioButton.AutoSize = true;
            SevenBySevenRadioButton.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            SevenBySevenRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            SevenBySevenRadioButton.Location = new System.Drawing.Point(408, 355);
            SevenBySevenRadioButton.Name = "SevenBySevenRadioButton";
            SevenBySevenRadioButton.Size = new System.Drawing.Size(100, 50);
            SevenBySevenRadioButton.TabIndex = 4;
            SevenBySevenRadioButton.TabStop = true;
            SevenBySevenRadioButton.Text = "7x7";
            SevenBySevenRadioButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            StartButton.BackColor = System.Drawing.Color.FromArgb(1, 26, 39);
            StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StartButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            StartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            StartButton.Location = new System.Drawing.Point(256, 473);
            StartButton.Name = "StartButton";
            StartButton.Size = new System.Drawing.Size(222, 78);
            StartButton.TabIndex = 5;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            StartButton.MouseEnter += StartButton_MouseEnter_1;
            StartButton.MouseLeave += StartButton_MouseLeave_1;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(6, 56, 82);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(StartButton);
            panel1.Controls.Add(FourByFourRadioButton);
            panel1.Controls.Add(FiveByFiveRadioButton);
            panel1.Controls.Add(SixBySixRadioButton);
            panel1.Controls.Add(SevenBySevenRadioButton);
            panel1.Location = new System.Drawing.Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(726, 748);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(1, 26, 39);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(726, 204);
            panel2.TabIndex = 7;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            closeButton.Location = new System.Drawing.Point(677, 9);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(39, 38);
            closeButton.TabIndex = 6;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter_1;
            closeButton.MouseLeave += closeButton_MouseLeave_1;
            // 
            // ChooseSizeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(722, 738);
            Controls.Add(panel1);
            Name = "ChooseSizeForm";
            Text = "ChooseSizeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton FourByFourRadioButton;
        private System.Windows.Forms.RadioButton FiveByFiveRadioButton;
        private System.Windows.Forms.RadioButton SixBySixRadioButton;
        private System.Windows.Forms.RadioButton SevenBySevenRadioButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Panel panel2;
    }
}