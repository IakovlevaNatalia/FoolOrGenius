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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Registration = new System.Windows.Forms.Panel();
            this.authorizationLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userEmailField = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userLoginField = new System.Windows.Forms.TextBox();
            this.userFirstNameField = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.userPasswordField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userLastNameField = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Registration.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.Registration.Controls.Add(this.authorizationLabel);
            this.Registration.Font = new System.Drawing.Font("Times New Roman", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Registration.Location = new System.Drawing.Point(0, 0);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(667, 163);
            this.Registration.TabIndex = 12;
            this.Registration.TabStop = true;
            // 
            // authorizationLabel
            // 
            this.authorizationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.authorizationLabel.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.authorizationLabel.Location = new System.Drawing.Point(0, 0);
            this.authorizationLabel.Name = "authorizationLabel";
            this.authorizationLabel.Size = new System.Drawing.Size(723, 163);
            this.authorizationLabel.TabIndex = 7;
            this.authorizationLabel.Text = "Registration";
            this.authorizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authorizationLabel.Click += new System.EventHandler(this.authorizationLabel_Click_1);
            this.authorizationLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.authorizationLabel_MouseDown_1);
            this.authorizationLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.authorizationLabel_MouseMove_1);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.Location = new System.Drawing.Point(13, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(37, 36);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(8)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.userEmailField);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.userLoginField);
            this.panel1.Controls.Add(this.userFirstNameField);
            this.panel1.Controls.Add(this.signUpButton);
            this.panel1.Controls.Add(this.userPasswordField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.userLastNameField);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 439);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // userEmailField
            // 
            this.userEmailField.BackColor = System.Drawing.Color.White;
            this.userEmailField.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmailField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userEmailField.Location = new System.Drawing.Point(255, 231);
            this.userEmailField.Name = "userEmailField";
            this.userEmailField.Size = new System.Drawing.Size(303, 39);
            this.userEmailField.TabIndex = 17;
            this.userEmailField.Enter += new System.EventHandler(this.userEmailField_Enter);
            this.userEmailField.Leave += new System.EventHandler(this.userEmailField_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FoolOrGeniusWinFormsApp.Properties.Resources.e_mail;
            this.pictureBox5.Location = new System.Drawing.Point(160, 210);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FoolOrGeniusWinFormsApp.Properties.Resources.icognito2;
            this.pictureBox4.Location = new System.Drawing.Point(160, 144);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoolOrGeniusWinFormsApp.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(160, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // userLoginField
            // 
            this.userLoginField.BackColor = System.Drawing.Color.White;
            this.userLoginField.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoginField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userLoginField.Location = new System.Drawing.Point(255, 165);
            this.userLoginField.Name = "userLoginField";
            this.userLoginField.Size = new System.Drawing.Size(303, 39);
            this.userLoginField.TabIndex = 13;
            this.userLoginField.TextChanged += new System.EventHandler(this.userLoginField_TextChanged);
            this.userLoginField.Enter += new System.EventHandler(this.userLoginField_Enter);
            this.userLoginField.Leave += new System.EventHandler(this.userLoginField_Leave);
            // 
            // userFirstNameField
            // 
            this.userFirstNameField.BackColor = System.Drawing.Color.White;
            this.userFirstNameField.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFirstNameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userFirstNameField.Location = new System.Drawing.Point(255, 21);
            this.userFirstNameField.Name = "userFirstNameField";
            this.userFirstNameField.Size = new System.Drawing.Size(303, 39);
            this.userFirstNameField.TabIndex = 12;
            this.userFirstNameField.TextChanged += new System.EventHandler(this.userFirstNameField_TextChanged);
            this.userFirstNameField.Enter += new System.EventHandler(this.userFirstNameField_Enter);
            this.userFirstNameField.Leave += new System.EventHandler(this.userFirstNameField_Leave);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.signUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(283, 358);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(222, 62);
            this.signUpButton.TabIndex = 11;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            // 
            // userPasswordField
            // 
            this.userPasswordField.BackColor = System.Drawing.Color.White;
            this.userPasswordField.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPasswordField.Location = new System.Drawing.Point(255, 294);
            this.userPasswordField.Name = "userPasswordField";
            this.userPasswordField.Size = new System.Drawing.Size(303, 39);
            this.userPasswordField.TabIndex = 10;
            this.userPasswordField.UseSystemPasswordChar = true;
            this.userPasswordField.Enter += new System.EventHandler(this.userPasswordField_Enter);
            this.userPasswordField.Leave += new System.EventHandler(this.userPasswordField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FoolOrGeniusWinFormsApp.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(160, 284);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // userLastNameField
            // 
            this.userLastNameField.BackColor = System.Drawing.Color.White;
            this.userLastNameField.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLastNameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userLastNameField.Location = new System.Drawing.Point(255, 90);
            this.userLastNameField.Name = "userLastNameField";
            this.userLastNameField.Size = new System.Drawing.Size(303, 39);
            this.userLastNameField.TabIndex = 8;
            this.userLastNameField.TextChanged += new System.EventHandler(this.userLastName_TextChanged);
            this.userLastNameField.Enter += new System.EventHandler(this.userLastNameField_Enter);
            this.userLastNameField.Leave += new System.EventHandler(this.userLastNameField_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FoolOrGeniusWinFormsApp.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(160, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(664, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(62, 160);
            this.panel2.TabIndex = 14;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 598);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Registration.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}