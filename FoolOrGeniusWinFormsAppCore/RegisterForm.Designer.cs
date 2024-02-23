namespace FoolOrGeniusWinFormsApp
{
    partial class RegisterForm
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            Registration = new System.Windows.Forms.Panel();
            authorizationLabel = new System.Windows.Forms.Label();
            closeButton = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            authorizathionLabel = new System.Windows.Forms.Label();
            userEmailField = new System.Windows.Forms.TextBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            userLoginField = new System.Windows.Forms.TextBox();
            userFirstNameField = new System.Windows.Forms.TextBox();
            signUpButton = new System.Windows.Forms.Button();
            userPasswordField = new System.Windows.Forms.TextBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            userLastNameField = new System.Windows.Forms.TextBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            FirstNameErrorProvider = new System.Windows.Forms.ErrorProvider(components);
            LastNameErrorProvider = new System.Windows.Forms.ErrorProvider(components);
            loginErrorProvider = new System.Windows.Forms.ErrorProvider(components);
            emailErrorProvider = new System.Windows.Forms.ErrorProvider(components);
            passwordErrorProvider = new System.Windows.Forms.ErrorProvider(components);
            Registration.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FirstNameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LastNameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emailErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(726, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // Registration
            // 
            Registration.BackColor = System.Drawing.Color.FromArgb(8, 24, 70);
            Registration.Controls.Add(authorizationLabel);
            Registration.Font = new System.Drawing.Font("Times New Roman", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            Registration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            Registration.Location = new System.Drawing.Point(0, 0);
            Registration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Registration.Name = "Registration";
            Registration.Size = new System.Drawing.Size(667, 204);
            Registration.TabIndex = 12;
            Registration.TabStop = true;
            // 
            // authorizationLabel
            // 
            authorizationLabel.BackColor = System.Drawing.Color.FromArgb(1, 26, 39);
            authorizationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            authorizationLabel.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            authorizationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            authorizationLabel.Location = new System.Drawing.Point(0, 0);
            authorizationLabel.Name = "authorizationLabel";
            authorizationLabel.Size = new System.Drawing.Size(723, 204);
            authorizationLabel.TabIndex = 7;
            authorizationLabel.Text = "Registration";
            authorizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            authorizationLabel.MouseDown += authorizationLabel_MouseDown_1;
            authorizationLabel.MouseMove += authorizationLabel_MouseMove_1;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            closeButton.Location = new System.Drawing.Point(13, 11);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(37, 36);
            closeButton.TabIndex = 13;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(6, 56, 82);
            panel1.Controls.Add(authorizathionLabel);
            panel1.Controls.Add(userEmailField);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(userLoginField);
            panel1.Controls.Add(userFirstNameField);
            panel1.Controls.Add(signUpButton);
            panel1.Controls.Add(userPasswordField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(userLastNameField);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new System.Drawing.Point(0, 196);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(726, 555);
            panel1.TabIndex = 13;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // authorizathionLabel
            // 
            authorizathionLabel.AutoSize = true;
            authorizathionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            authorizathionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            authorizathionLabel.Location = new System.Drawing.Point(340, 498);
            authorizathionLabel.Name = "authorizathionLabel";
            authorizathionLabel.Size = new System.Drawing.Size(99, 20);
            authorizathionLabel.TabIndex = 18;
            authorizathionLabel.Text = "Authorization";
            authorizathionLabel.Click += authorizathionLabel_Click;
            authorizathionLabel.MouseEnter += authorizathionLabel_MouseEnter;
            authorizathionLabel.MouseLeave += authorizathionLabel_MouseLeave;
            // 
            // userEmailField
            // 
            userEmailField.BackColor = System.Drawing.Color.White;
            userEmailField.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            userEmailField.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            userEmailField.Location = new System.Drawing.Point(255, 256);
            userEmailField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            userEmailField.Name = "userEmailField";
            userEmailField.Size = new System.Drawing.Size(303, 39);
            userEmailField.TabIndex = 17;
            userEmailField.Enter += userEmailField_Enter;
            userEmailField.Leave += userEmailField_Leave;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Resources.e_mail;
            pictureBox5.Location = new System.Drawing.Point(160, 231);
            pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(64, 64);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Resources.icognito;
            pictureBox4.Location = new System.Drawing.Point(160, 159);
            pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(64, 64);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.user;
            pictureBox1.Location = new System.Drawing.Point(160, 87);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(64, 64);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // userLoginField
            // 
            userLoginField.BackColor = System.Drawing.Color.White;
            userLoginField.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            userLoginField.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            userLoginField.Location = new System.Drawing.Point(255, 184);
            userLoginField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            userLoginField.Name = "userLoginField";
            userLoginField.Size = new System.Drawing.Size(303, 39);
            userLoginField.TabIndex = 13;
            userLoginField.Enter += userLoginField_Enter;
            userLoginField.Leave += userLoginField_Leave;
            // 
            // userFirstNameField
            // 
            userFirstNameField.BackColor = System.Drawing.Color.White;
            userFirstNameField.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            userFirstNameField.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            userFirstNameField.Location = new System.Drawing.Point(255, 40);
            userFirstNameField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            userFirstNameField.Name = "userFirstNameField";
            userFirstNameField.Size = new System.Drawing.Size(303, 39);
            userFirstNameField.TabIndex = 12;
            userFirstNameField.Enter += userFirstNameField_Enter;
            userFirstNameField.Leave += userFirstNameField_Leave;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = System.Drawing.Color.FromArgb(1, 26, 39);
            signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            signUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            signUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            signUpButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            signUpButton.ForeColor = System.Drawing.Color.White;
            signUpButton.Location = new System.Drawing.Point(291, 392);
            signUpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new System.Drawing.Size(222, 78);
            signUpButton.TabIndex = 11;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // userPasswordField
            // 
            userPasswordField.BackColor = System.Drawing.Color.White;
            userPasswordField.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            userPasswordField.Location = new System.Drawing.Point(255, 328);
            userPasswordField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            userPasswordField.Name = "userPasswordField";
            userPasswordField.Size = new System.Drawing.Size(303, 39);
            userPasswordField.TabIndex = 10;
            userPasswordField.UseSystemPasswordChar = true;
            userPasswordField.Enter += userPasswordField_Enter;
            userPasswordField.Leave += userPasswordField_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources._lock;
            pictureBox2.Location = new System.Drawing.Point(160, 303);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(64, 64);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // userLastNameField
            // 
            userLastNameField.BackColor = System.Drawing.Color.White;
            userLastNameField.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            userLastNameField.ForeColor = System.Drawing.Color.FromArgb(64, 64, 0);
            userLastNameField.Location = new System.Drawing.Point(255, 112);
            userLastNameField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            userLastNameField.Name = "userLastNameField";
            userLastNameField.Size = new System.Drawing.Size(303, 39);
            userLastNameField.TabIndex = 8;
            userLastNameField.Enter += userLastNameField_Enter;
            userLastNameField.Leave += userLastNameField_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.user;
            pictureBox3.Location = new System.Drawing.Point(160, 15);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(64, 64);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(1, 26, 39);
            panel2.Controls.Add(closeButton);
            panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            panel2.Location = new System.Drawing.Point(664, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(62, 200);
            panel2.TabIndex = 14;
            // 
            // FirstNameErrorProvider
            // 
            FirstNameErrorProvider.ContainerControl = this;
            // 
            // LastNameErrorProvider
            // 
            LastNameErrorProvider.ContainerControl = this;
            // 
            // loginErrorProvider
            // 
            loginErrorProvider.ContainerControl = this;
            // 
            // emailErrorProvider
            // 
            emailErrorProvider.ContainerControl = this;
            // 
            // passwordErrorProvider
            // 
            passwordErrorProvider.ContainerControl = this;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(726, 748);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Registration);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Registration.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FirstNameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)LastNameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)emailErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel Registration;
        private System.Windows.Forms.Label authorizationLabel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox userLastNameField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox userPasswordField;
        private System.Windows.Forms.Button signUpButton;
        public System.Windows.Forms.TextBox userLoginField;
        public System.Windows.Forms.TextBox userFirstNameField;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.TextBox userEmailField;
        private System.Windows.Forms.Label authorizathionLabel;
        private System.Windows.Forms.ErrorProvider FirstNameErrorProvider;
        private System.Windows.Forms.ErrorProvider LastNameErrorProvider;
        private System.Windows.Forms.ErrorProvider loginErrorProvider;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ErrorProvider passwordErrorProvider;
    }
}