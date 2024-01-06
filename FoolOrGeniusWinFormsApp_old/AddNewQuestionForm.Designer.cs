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
            this.questionsTextLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.questionAnswerTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionsTextLabel
            // 
            this.questionsTextLabel.AutoSize = true;
            this.questionsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionsTextLabel.Location = new System.Drawing.Point(102, 59);
            this.questionsTextLabel.Name = "questionsTextLabel";
            this.questionsTextLabel.Size = new System.Drawing.Size(118, 29);
            this.questionsTextLabel.TabIndex = 0;
            this.questionsTextLabel.Text = "Question";
            this.questionsTextLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerLabel.Location = new System.Drawing.Point(105, 106);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(99, 29);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.Text = "Answer";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextBox.Location = new System.Drawing.Point(306, 65);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(604, 34);
            this.questionTextBox.TabIndex = 2;
            this.questionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // questionAnswerTextBox
            // 
            this.questionAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionAnswerTextBox.Location = new System.Drawing.Point(306, 112);
            this.questionAnswerTextBox.Name = "questionAnswerTextBox";
            this.questionAnswerTextBox.Size = new System.Drawing.Size(604, 34);
            this.questionAnswerTextBox.TabIndex = 3;
            this.questionAnswerTextBox.TextChanged += new System.EventHandler(this.answerTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(306, 240);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(419, 109);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add new questions";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddNewQuestionForm
            // 
            this.ClientSize = new System.Drawing.Size(1002, 537);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.questionAnswerTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionsTextLabel);
            this.Name = "AddNewQuestionForm";
            this.Load += new System.EventHandler(this.AddNewQuestionForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionsTextLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox questionAnswerTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}