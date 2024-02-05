namespace FoolOrGeniusWinFormsApp.Firework
{
    partial class FireworkForm
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
            fireworksStartButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // fireworksStartButton
            // 
            fireworksStartButton.Location = new System.Drawing.Point(656, 35);
            fireworksStartButton.Name = "fireworksStartButton";
            fireworksStartButton.Size = new System.Drawing.Size(114, 56);
            fireworksStartButton.TabIndex = 0;
            fireworksStartButton.Text = "Start Fireworks";
            fireworksStartButton.UseVisualStyleBackColor = true;
            fireworksStartButton.Click += fireworksStartButton_Click_1;
            // 
            // FireworkForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(fireworksStartButton);
            Name = "FireworkForm";
            Text = "FireworkForm";
            MouseDown += FireworkForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button fireworksStartButton;
    }
}