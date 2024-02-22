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
            userPasswordField = new System.Windows.Forms.TextBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            RegisterLabel = new System.Windows.Forms.Label();
            startButton = new System.Windows.Forms.Button();
            closeButton = new System.Windows.Forms.Label();
            authorizationLabel = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            pictureBox2.Image = Resources._lock;
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
            pictureBox1.Image = Resources.user;
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
            // startButton
            // 
            startButton.BackColor = System.Drawing.Color.FromArgb(1, 26, 39);
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
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            closeButton.Location = new System.Drawing.Point(677, 18);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(37, 36);
            closeButton.TabIndex = 5;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // authorizationLabel
            // 
            authorizationLabel.BackColor = System.Drawing.Color.FromArgb(1, 26, 39);
            authorizationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            authorizationLabel.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            authorizationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            authorizationLabel.Location = new System.Drawing.Point(0, 0);
            authorizationLabel.Name = "authorizationLabel";
            authorizationLabel.Size = new System.Drawing.Size(665, 204);
            authorizationLabel.TabIndex = 6;
            authorizationLabel.Text = "Authorization";
            authorizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            authorizationLabel.MouseDown += authorizationLabel_MouseDown;
            authorizationLabel.MouseMove += authorizationLabel_MouseMove;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(1, 26, 39);
            panel1.Controls.Add(authorizationLabel);
            panel1.Controls.Add(closeButton);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(726, 204);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(606, 602);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 20);
            label1.TabIndex = 11;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(6, 56, 82);
            ClientSize = new System.Drawing.Size(726, 748);
            Controls.Add(label1);
            Controls.Add(RegisterLabel);
            Controls.Add(userPasswordField);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(startButton);
            Controls.Add(userLoginField);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            MouseDown += WelcomeForm_MouseDown;
            MouseMove += WelcomeForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public System.Windows.Forms.TextBox userLoginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox userPasswordField;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label authorizationLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}