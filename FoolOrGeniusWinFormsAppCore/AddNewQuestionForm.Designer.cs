namespace FoolOrGeniusWinFormsApp
{
    partial class AddNewQuestionForm
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
            questionsTextLabel = new System.Windows.Forms.Label();
            answerLabel = new System.Windows.Forms.Label();
            questionTextBox = new System.Windows.Forms.TextBox();
            questionAnswerTextBox = new System.Windows.Forms.TextBox();
            AddButton = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            closeButton = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // questionsTextLabel
            // 
            questionsTextLabel.AutoSize = true;
            questionsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            questionsTextLabel.Location = new System.Drawing.Point(29, 244);
            questionsTextLabel.Name = "questionsTextLabel";
            questionsTextLabel.Size = new System.Drawing.Size(118, 29);
            questionsTextLabel.TabIndex = 0;
            questionsTextLabel.Text = "Question";
            questionsTextLabel.Click += label1_Click;
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            answerLabel.Location = new System.Drawing.Point(29, 312);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new System.Drawing.Size(99, 29);
            answerLabel.TabIndex = 1;
            answerLabel.Text = "Answer";
            // 
            // questionTextBox
            // 
            questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            questionTextBox.Location = new System.Drawing.Point(174, 244);
            questionTextBox.Name = "questionTextBox";
            questionTextBox.Size = new System.Drawing.Size(425, 34);
            questionTextBox.TabIndex = 2;
            questionTextBox.TextChanged += textBox1_TextChanged;
            // 
            // questionAnswerTextBox
            // 
            questionAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            questionAnswerTextBox.Location = new System.Drawing.Point(174, 312);
            questionAnswerTextBox.Name = "questionAnswerTextBox";
            questionAnswerTextBox.Size = new System.Drawing.Size(425, 34);
            questionAnswerTextBox.TabIndex = 3;
            questionAnswerTextBox.TextChanged += answerTextBox_TextChanged;
            // 
            // AddButton
            // 
            AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            AddButton.Location = new System.Drawing.Point(174, 402);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(419, 109);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add new questions";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(8, 24, 70);
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(closeButton);
            panel1.Location = new System.Drawing.Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(711, 207);
            panel1.TabIndex = 5;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.BackColor = System.Drawing.Color.FromArgb(8, 24, 70);
            closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeButton.Font = new System.Drawing.Font("Sans Serif Collection", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            closeButton.Location = new System.Drawing.Point(617, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(77, 84);
            closeButton.TabIndex = 0;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // AddNewQuestionForm
            // 
            BackColor = System.Drawing.Color.FromArgb(70, 8, 24);
            ClientSize = new System.Drawing.Size(708, 701);
            Controls.Add(panel1);
            Controls.Add(AddButton);
            Controls.Add(questionAnswerTextBox);
            Controls.Add(questionTextBox);
            Controls.Add(answerLabel);
            Controls.Add(questionsTextLabel);
            Name = "AddNewQuestionForm";
            Load += AddNewQuestionForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label questionsTextLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox questionAnswerTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
    }
}