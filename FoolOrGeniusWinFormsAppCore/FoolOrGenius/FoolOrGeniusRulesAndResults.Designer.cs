namespace FoolOrGeniusWinFormsApp.FoolOrGenius
{
    partial class FoolOrGeniusRulesAndResults
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            userResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            textBox1 = new System.Windows.Forms.TextBox();
            startButton = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { userResultsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(708, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // userResultsToolStripMenuItem
            // 
            userResultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem, exitToolStripMenuItem1 });
            userResultsToolStripMenuItem.Name = "userResultsToolStripMenuItem";
            userResultsToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            userResultsToolStripMenuItem.Text = "User Results";
            userResultsToolStripMenuItem.Click += userResultsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            exitToolStripMenuItem.Text = "Restart";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new System.Drawing.Size(138, 26);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.FromArgb(6, 56, 82);
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            textBox1.Location = new System.Drawing.Point(126, 188);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(478, 173);
            textBox1.TabIndex = 1;
            textBox1.Text = "This is a playful test. Nothing serious. Just answer the questions using logic. ";
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
            startButton.Location = new System.Drawing.Point(236, 478);
            startButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(222, 78);
            startButton.TabIndex = 6;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // FoolOrGeniusRulesAndResults
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(6, 56, 82);
            ClientSize = new System.Drawing.Size(708, 701);
            Controls.Add(startButton);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            ForeColor = System.Drawing.Color.Black;
            MainMenuStrip = menuStrip1;
            Name = "FoolOrGeniusRulesAndResults";
            Text = "FoolOrGeniusRulesAndResults";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startButton;
    }
}