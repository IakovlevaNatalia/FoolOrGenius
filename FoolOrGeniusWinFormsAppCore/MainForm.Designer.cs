using System.Drawing;

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
            questionPictureBox = new System.Windows.Forms.PictureBox();
            solutionPictureBox = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)questionPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)solutionPictureBox).BeginInit();
            SuspendLayout();
            // 
            // nextbutton
            // 
            nextbutton.BackColor = Color.FromArgb(8, 24, 70);
            nextbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            nextbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            nextbutton.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextbutton.ForeColor = SystemColors.ButtonFace;
            nextbutton.Location = new Point(226, 479);
            nextbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nextbutton.Name = "nextbutton";
            nextbutton.Size = new Size(222, 78);
            nextbutton.TabIndex = 4;
            nextbutton.Text = "Next";
            nextbutton.UseVisualStyleBackColor = false;
            nextbutton.Click += nextbutton_Click;
            nextbutton.MouseEnter += nextbutton_MouseEnter;
            nextbutton.MouseLeave += nextbutton_MouseLeave;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Times New Roman", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionNumberLabel.ForeColor = SystemColors.ButtonFace;
            questionNumberLabel.ImageAlign = ContentAlignment.TopCenter;
            questionNumberLabel.Location = new Point(191, 59);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(326, 62);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Question №1";
            questionNumberLabel.Click += questionNumberLabel_Click;
            // 
            // questionTextLabel
            // 
            questionTextLabel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionTextLabel.ForeColor = SystemColors.ButtonFace;
            questionTextLabel.Location = new Point(188, 250);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(457, 105);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Question Text";
            questionTextLabel.Click += QuestionTextLabel_Click;
            // 
            // UserAnswerTextBox
            // 
            UserAnswerTextBox.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            UserAnswerTextBox.Location = new Point(188, 377);
            UserAnswerTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            UserAnswerTextBox.Name = "UserAnswerTextBox";
            UserAnswerTextBox.Size = new Size(111, 34);
            UserAnswerTextBox.TabIndex = 3;
            UserAnswerTextBox.TextChanged += UserAnswerTextBox_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(8, 24, 70);
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(questionNumberLabel);
            panel1.Location = new Point(-3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 212);
            panel1.TabIndex = 5;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            closeButton.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeButton.ForeColor = SystemColors.ButtonHighlight;
            closeButton.Location = new Point(662, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(37, 36);
            closeButton.TabIndex = 14;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // questionPictureBox
            // 
            questionPictureBox.Image = Resources.question;
            questionPictureBox.Location = new Point(100, 250);
            questionPictureBox.Name = "questionPictureBox";
            questionPictureBox.Size = new Size(64, 64);
            questionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            questionPictureBox.TabIndex = 6;
            questionPictureBox.TabStop = false;
            // 
            // solutionPictureBox
            // 
            solutionPictureBox.Image = Resources.solutions;
            solutionPictureBox.Location = new Point(100, 347);
            solutionPictureBox.Name = "solutionPictureBox";
            solutionPictureBox.Size = new Size(64, 64);
            solutionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            solutionPictureBox.TabIndex = 7;
            solutionPictureBox.TabStop = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 8, 24);
            ClientSize = new Size(708, 706);
            Controls.Add(solutionPictureBox);
            Controls.Add(questionPictureBox);
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
            ((System.ComponentModel.ISupportInitialize)questionPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)solutionPictureBox).EndInit();
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
        private System.Windows.Forms.PictureBox questionPictureBox;
        private System.Windows.Forms.PictureBox solutionPictureBox;
    }
}

