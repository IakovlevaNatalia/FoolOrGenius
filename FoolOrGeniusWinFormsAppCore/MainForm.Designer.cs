namespace FoolOrGeniusWinFormsApp
{
    partial class mainForm
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
            nextbutton = new System.Windows.Forms.Button();
            questionNumberLabel = new System.Windows.Forms.Label();
            questionTextLabel = new System.Windows.Forms.Label();
            UserAnswerTextBox = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            closeButton = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nextbutton
            // 
            nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            nextbutton.Location = new System.Drawing.Point(238, 440);
            nextbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nextbutton.Name = "nextbutton";
            nextbutton.Size = new System.Drawing.Size(222, 78);
            nextbutton.TabIndex = 4;
            nextbutton.Text = "Next";
            nextbutton.Click += nextbutton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new System.Drawing.Font("Times New Roman", 31.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            questionNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            questionNumberLabel.Location = new System.Drawing.Point(258, 76);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new System.Drawing.Size(326, 62);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Question №1";
            questionNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            questionNumberLabel.Click += questionNumberLabel_Click;
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            questionTextLabel.Location = new System.Drawing.Point(137, 231);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new System.Drawing.Size(176, 29);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Question Text";
            questionTextLabel.Click += QuestionTextLabel_Click;
            // 
            // UserAnswerTextBox
            // 
            UserAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            UserAnswerTextBox.Location = new System.Drawing.Point(160, 340);
            UserAnswerTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            UserAnswerTextBox.Name = "UserAnswerTextBox";
            UserAnswerTextBox.Size = new System.Drawing.Size(317, 34);
            UserAnswerTextBox.TabIndex = 3;
            UserAnswerTextBox.TextChanged += UserAnswerTextBox_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(8, 24, 70);
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(questionNumberLabel);
            panel1.Location = new System.Drawing.Point(-3, -3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(855, 212);
            panel1.TabIndex = 5;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            closeButton.Location = new System.Drawing.Point(662, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(37, 36);
            closeButton.TabIndex = 14;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(70, 8, 24);
            ClientSize = new System.Drawing.Size(708, 706);
            Controls.Add(panel1);
            Controls.Add(UserAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(nextbutton);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "mainForm";
            Text = "Fool or Genius";
            Load += mainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.TextBox UserAnswerTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label closeButton;
    }
}

