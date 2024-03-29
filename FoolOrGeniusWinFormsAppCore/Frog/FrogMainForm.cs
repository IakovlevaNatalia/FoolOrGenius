﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp.Frog
{
    public partial class FrogMainForm : Form
    {
        int startLocationXEmptyPictureBox = 440;
        private int minMoves = 24;
        public FrogMainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.Text = "";

        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
            if (EndGame())
            {
                if (CanBetter(Convert.ToInt32(scoreLabel.Text)))
                {
                    MessageBox.Show("You won with the minimum number of moves");

                }
                else
                {
                    var result = MessageBox.Show("You can improve the result. Would you like to try again?", "End of the game",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
            }
        }
        private bool CanBetter(int moves)
        {
            return moves == minMoves;
        }
        private bool EndGame()
        {

            if
                (leftrPictureBox1.Location.X > emptyPictureBox.Location.X &&
                 leftrPictureBox2.Location.X > emptyPictureBox.Location.X &&
                 leftrPictureBox3.Location.X > emptyPictureBox.Location.X &&
                 leftrPictureBox4.Location.X > emptyPictureBox.Location.X &&
                 emptyPictureBox.Location.X == startLocationXEmptyPictureBox)
            {
                leftrPictureBox1.Enabled = false;
                leftrPictureBox2.Enabled = false;
                leftrPictureBox3.Enabled = false;
                leftrPictureBox4.Enabled = false;

                rightPictureBox1.Enabled = false;
                rightPictureBox2.Enabled = false;
                rightPictureBox3.Enabled = false;
                rightPictureBox4.Enabled = false;

                return true;
            }

            return false;
        }
        private void Swap(PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) /
                           emptyPictureBox.Size.Width;
            if (distance > 2)
            {
                MessageBox.Show("The frog can only jump to the adjacent lily pad or skip one");
            }
            else
            {
                var location = clickedPicture.Location;
                clickedPicture.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;
                scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();
            }
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "There are 8 frogs on the swamp. The frogs dream of swapping places. Four frogs want to jump to the right, and four to the left. A frog can jump either to the adjacent empty lily pad, skip one frog, or jump backward. The goal of the game is to rearrange the frogs. The minimum number of moves is 24.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var frogsPairPictureBox = new PictureBox();
            frogsPairPictureBox.Image = Resources.frogsPair;
            frogsPairPictureBox.Size = new Size(100, 100);
            frogsPairPictureBox.BackColor = Color.Transparent;
            this.Controls.Add(frogsPairPictureBox);

        }
    }
}
