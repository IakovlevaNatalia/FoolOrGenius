namespace FoolOrGeniusWinFormsApp
{
    partial class ChooseGameForm
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
            foolOrGeniusRadioButton = new System.Windows.Forms.RadioButton();
            Game2048RadioButton = new System.Windows.Forms.RadioButton();
            startButton = new System.Windows.Forms.Button();
            easyBallRadioButton = new System.Windows.Forms.RadioButton();
            FireworkRadioButton = new System.Windows.Forms.RadioButton();
            FruitNinjaRadioButton = new System.Windows.Forms.RadioButton();
            angryBirdsRadioButton = new System.Windows.Forms.RadioButton();
            SuspendLayout();
            // 
            // foolOrGeniusRadioButton
            // 
            foolOrGeniusRadioButton.AutoSize = true;
            foolOrGeniusRadioButton.Location = new System.Drawing.Point(117, 95);
            foolOrGeniusRadioButton.Name = "foolOrGeniusRadioButton";
            foolOrGeniusRadioButton.Size = new System.Drawing.Size(127, 24);
            foolOrGeniusRadioButton.TabIndex = 3;
            foolOrGeniusRadioButton.TabStop = true;
            foolOrGeniusRadioButton.Text = "Fool Or Genius";
            foolOrGeniusRadioButton.UseVisualStyleBackColor = true;
            foolOrGeniusRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Game2048RadioButton
            // 
            Game2048RadioButton.AutoSize = true;
            Game2048RadioButton.Location = new System.Drawing.Point(523, 95);
            Game2048RadioButton.Name = "Game2048RadioButton";
            Game2048RadioButton.Size = new System.Drawing.Size(62, 24);
            Game2048RadioButton.TabIndex = 4;
            Game2048RadioButton.TabStop = true;
            Game2048RadioButton.Text = "2048";
            Game2048RadioButton.UseVisualStyleBackColor = true;
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
            startButton.Location = new System.Drawing.Point(274, 304);
            startButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(222, 78);
            startButton.TabIndex = 5;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // easyBallRadioButton
            // 
            easyBallRadioButton.AutoSize = true;
            easyBallRadioButton.Location = new System.Drawing.Point(82, 245);
            easyBallRadioButton.Name = "easyBallRadioButton";
            easyBallRadioButton.Size = new System.Drawing.Size(162, 24);
            easyBallRadioButton.TabIndex = 6;
            easyBallRadioButton.TabStop = true;
            easyBallRadioButton.Text = "Catch Me If You Can";
            easyBallRadioButton.UseVisualStyleBackColor = true;
            // 
            // FireworkRadioButton
            // 
            FireworkRadioButton.AutoSize = true;
            FireworkRadioButton.Location = new System.Drawing.Point(264, 245);
            FireworkRadioButton.Name = "FireworkRadioButton";
            FireworkRadioButton.Size = new System.Drawing.Size(92, 24);
            FireworkRadioButton.TabIndex = 7;
            FireworkRadioButton.TabStop = true;
            FireworkRadioButton.Text = "Fireworks";
            FireworkRadioButton.UseVisualStyleBackColor = true;
            // 
            // FruitNinjaRadioButton
            // 
            FruitNinjaRadioButton.AutoSize = true;
            FruitNinjaRadioButton.Location = new System.Drawing.Point(374, 246);
            FruitNinjaRadioButton.Name = "FruitNinjaRadioButton";
            FruitNinjaRadioButton.Size = new System.Drawing.Size(98, 24);
            FruitNinjaRadioButton.TabIndex = 8;
            FruitNinjaRadioButton.TabStop = true;
            FruitNinjaRadioButton.Text = "Fruit Ninja";
            FruitNinjaRadioButton.UseVisualStyleBackColor = true;
            // 
            // angryBirdsRadioButton
            // 
            angryBirdsRadioButton.AutoSize = true;
            angryBirdsRadioButton.Location = new System.Drawing.Point(505, 250);
            angryBirdsRadioButton.Name = "angryBirdsRadioButton";
            angryBirdsRadioButton.Size = new System.Drawing.Size(106, 24);
            angryBirdsRadioButton.TabIndex = 9;
            angryBirdsRadioButton.TabStop = true;
            angryBirdsRadioButton.Text = "Angry Birds";
            angryBirdsRadioButton.UseVisualStyleBackColor = true;
            // 
            // ChooseGameForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(angryBirdsRadioButton);
            Controls.Add(FruitNinjaRadioButton);
            Controls.Add(FireworkRadioButton);
            Controls.Add(easyBallRadioButton);
            Controls.Add(startButton);
            Controls.Add(Game2048RadioButton);
            Controls.Add(foolOrGeniusRadioButton);
            Name = "ChooseGameForm";
            Text = "ChooseGameForm";
            Load += ChooseGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.RadioButton foolOrGeniusRadioButton;
        private System.Windows.Forms.RadioButton Game2048RadioButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RadioButton easyBallRadioButton;
        private System.Windows.Forms.RadioButton FireworkRadioButton;
        private System.Windows.Forms.RadioButton FruitNinjaRadioButton;
        private System.Windows.Forms.RadioButton angryBirdsRadioButton;
    }
}