namespace FoolOrGeniusWinFormsApp
{
    partial class WelcomeForm
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
            userLoginField = new System.Windows.Forms.TextBox();
            startButton = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showPreviousResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            questionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addNewQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listOfAllQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            closeButton = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            authorizationLabel = new System.Windows.Forms.Label();
            userPasswordField = new System.Windows.Forms.TextBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            RegisterLabel = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userLoginField
            // 
            userLoginField.BackColor = System.Drawing.Color.White;
            userLoginField.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            userLoginField.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            userLoginField.Location = new System.Drawing.Point(235, 299);
            userLoginField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            userLoginField.Name = "userLoginField";
            userLoginField.Size = new System.Drawing.Size(303, 39);
            userLoginField.TabIndex = 2;
            userLoginField.TextChanged += userNameTextBox_TextChanged;
            userLoginField.Enter += userLogin_Enter;
            userLoginField.Leave += userLogin_Leave;
            // 
            // startButton
            // 
            startButton.BackColor = System.Drawing.Color.FromArgb(8, 24, 70);
            startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            startButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            startButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            startButton.ForeColor = System.Drawing.Color.White;
            startButton.Location = new System.Drawing.Point(269, 514);
            startButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(222, 78);
            startButton.TabIndex = 3;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            startButton.MouseEnter += startButton_MouseEnter;
            startButton.MouseLeave += startButton_MouseLeave;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, questionsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(726, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { showPreviousResultsToolStripMenuItem, restartToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // showPreviousResultsToolStripMenuItem
            // 
            showPreviousResultsToolStripMenuItem.Name = "showPreviousResultsToolStripMenuItem";
            showPreviousResultsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            showPreviousResultsToolStripMenuItem.Text = "Show previous results";
            showPreviousResultsToolStripMenuItem.Click += showPreviousResultsToolStripMenuItem_Click;
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            restartToolStripMenuItem.Text = "Restart";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // questionsToolStripMenuItem
            // 
            questionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { addNewQuestionsToolStripMenuItem, listOfAllQuestionsToolStripMenuItem });
            questionsToolStripMenuItem.Name = "questionsToolStripMenuItem";
            questionsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            questionsToolStripMenuItem.Text = "Questions";
            // 
            // addNewQuestionsToolStripMenuItem
            // 
            addNewQuestionsToolStripMenuItem.Name = "addNewQuestionsToolStripMenuItem";
            addNewQuestionsToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            addNewQuestionsToolStripMenuItem.Text = "Add new questions";
            addNewQuestionsToolStripMenuItem.Click += addNewQuestionsToolStripMenuItem_Click;
            // 
            // listOfAllQuestionsToolStripMenuItem
            // 
            listOfAllQuestionsToolStripMenuItem.Name = "listOfAllQuestionsToolStripMenuItem";
            listOfAllQuestionsToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            listOfAllQuestionsToolStripMenuItem.Text = "List of all questions";
            listOfAllQuestionsToolStripMenuItem.Click += listOfAllQuestionsToolStripMenuItem_Click;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            closeButton.Location = new System.Drawing.Point(677, 16);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(37, 36);
            closeButton.TabIndex = 5;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(8, 24, 70);
            panel1.Controls.Add(authorizationLabel);
            panel1.Controls.Add(closeButton);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 28);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(726, 204);
            panel1.TabIndex = 7;
            // 
            // authorizationLabel
            // 
            authorizationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            authorizationLabel.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            authorizationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            authorizationLabel.Location = new System.Drawing.Point(0, 0);
            authorizationLabel.Name = "authorizationLabel";
            authorizationLabel.Size = new System.Drawing.Size(667, 204);
            authorizationLabel.TabIndex = 6;
            authorizationLabel.Text = "Authorization";
            authorizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            authorizationLabel.Click += authorizationLabel_Click;
            authorizationLabel.MouseDown += authorizationLabel_MouseDown;
            authorizationLabel.MouseMove += authorizationLabel_MouseMove;
            // 
            // userPasswordField
            // 
            userPasswordField.BackColor = System.Drawing.Color.White;
            userPasswordField.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            userPasswordField.Location = new System.Drawing.Point(235, 410);
            userPasswordField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            userPasswordField.Name = "userPasswordField";
            userPasswordField.Size = new System.Drawing.Size(303, 39);
            userPasswordField.TabIndex = 9;
            userPasswordField.UseSystemPasswordChar = true;
            userPasswordField.TextChanged += passwordFieldTextBox_TextChanged;
            userPasswordField.Enter += passwordField_Enter;
            userPasswordField.Leave += passwordField_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new System.Drawing.Point(143, 410);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(64, 64);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new System.Drawing.Point(143, 299);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(64, 64);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            RegisterLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            RegisterLabel.Location = new System.Drawing.Point(287, 641);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new System.Drawing.Size(187, 20);
            RegisterLabel.TabIndex = 10;
            RegisterLabel.Text = "Don't have an account yet?";
            RegisterLabel.Click += RegisterLabel_Click;
            RegisterLabel.MouseEnter += RegisterLabel_MouseEnter;
            RegisterLabel.MouseLeave += RegisterLabel_MouseLeave;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(70, 8, 24);
            ClientSize = new System.Drawing.Size(726, 748);
            Controls.Add(RegisterLabel);
            Controls.Add(userPasswordField);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(startButton);
            Controls.Add(userLoginField);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            Load += WelcomeForm_Load;
            MouseDown += WelcomeForm_MouseDown;
            MouseMove += WelcomeForm_MouseMove;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public System.Windows.Forms.TextBox userLoginField;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPreviousResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfAllQuestionsToolStripMenuItem;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label authorizationLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox userPasswordField;
        private System.Windows.Forms.Label RegisterLabel;
    }
}