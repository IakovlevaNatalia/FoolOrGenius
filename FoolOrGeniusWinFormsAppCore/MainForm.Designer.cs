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
            this.nextbutton = new System.Windows.Forms.Button();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.UserAnswerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nextbutton
            // 
            this.nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextbutton.Location = new System.Drawing.Point(217, 378);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(201, 151);
            this.nextbutton.TabIndex = 4;
            this.nextbutton.Text = "Next";
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNumberLabel.Location = new System.Drawing.Point(22, 55);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(163, 29);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Question №1";
            this.questionNumberLabel.Click += new System.EventHandler(this.questionNumberLabel_Click);
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextLabel.Location = new System.Drawing.Point(22, 167);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(176, 29);
            this.questionTextLabel.TabIndex = 2;
            this.questionTextLabel.Text = "Question Text";
            this.questionTextLabel.Click += new System.EventHandler(this.QuestionTextLabel_Click);
            // 
            // UserAnswerTextBox
            // 
            this.UserAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserAnswerTextBox.Location = new System.Drawing.Point(27, 248);
            this.UserAnswerTextBox.Name = "UserAnswerTextBox";
            this.UserAnswerTextBox.Size = new System.Drawing.Size(235, 34);
            this.UserAnswerTextBox.TabIndex = 3;
            this.UserAnswerTextBox.TextChanged += new System.EventHandler(this.UserAnswerTextBox_TextChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 654);
            this.Controls.Add(this.UserAnswerTextBox);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.nextbutton);
            this.Name = "mainForm";
            this.Text = "Fool or Genius";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.TextBox UserAnswerTextBox;
    }
}

