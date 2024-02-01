using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FoolOrGenius.Db;
using FoolOrGenius.DbCore.Models;

namespace FoolOrGeniusWinFormsApp._2048_Game
{
    public partial class TwentyFortyEightMainForm : Form
    {
        DatabaseContext db;
        UserFactory userFactory;
        private Game2048Type game2048Type;

        private const int labelSize = 100;
        private const int padding = 13;
        private const int startX = 10;
        private const int startY = 70;

        private Label[,] labelsMap;
        private int mapSize = 4;
        private static Random random = new Random();
        private int score = 0;
        private int bestScore = 0;
        private GameService2048 gameService2048;

        public TwentyFortyEightMainForm(DatabaseContext db, UserFactory userFactory, Game2048Type game2048Type, GameService2048 gameService2048)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.db=db;
            this.userFactory = userFactory;
            this.game2048Type= game2048Type;
            this.gameService2048 = gameService2048;
        }

        public void Init(int chosenSize)
        {
            mapSize = chosenSize;
        }

        private void TwentyFortyEightMainFormLoad(object sender, EventArgs e)

        {
            var chooseSize = new ChooseSizeForm();
            this.Hide();

            InitMap(mapSize);
            GenerateNumber();
            ShowScore();
            ShowYourBestScore();
            ShowBestScore();
        }
        private void ShowBestScore()
        {
            var bestScore = db.Game2048.Select(x => x.Score).DefaultIfEmpty().Max();
            bestScoreLabel.Text= bestScore.ToString();
        }
        private void ShowYourBestScore()
        {
            var bestScore = db.Game2048.Where(x => x.UserId == userFactory.ExistingUser.Id).Select(x => x.Score).DefaultIfEmpty().Max();
            yoursBestScoreLabel.Text = bestScore.ToString();
        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
        }
        private void GenerateNumber()
        {
            var emptyMap = 0;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == String.Empty)
                    {
                        emptyMap++;
                    }
                }
            }
            while (emptyMap > 0)
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLabel / mapSize;
                var indexColumn = randomNumberLabel % mapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    var randomPercentNumber = random.Next(1, 5);
                    if (randomPercentNumber <= 3)
                    {
                        labelsMap[indexRow, indexColumn].Text = "2";
                        labelsMap[indexRow, indexColumn].BackColor = Color.FromArgb(238, 228, 218);
                        labelsMap[indexRow, indexColumn].ForeColor = Color.DimGray;

                    }
                    else
                    {
                        labelsMap[indexRow, indexColumn].Text = "4";
                        labelsMap[indexRow, indexColumn].BackColor = Color.FromArgb(237, 224, 200);
                        labelsMap[indexRow, indexColumn].ForeColor = Color.DimGray;
                    }
                    break;
                }
            }
        }
        private void InitMap(int size)
        {
            this.mapSize=size;
            this.ClientSize = new Size(startX+(labelSize+padding)*mapSize, startY+(labelSize+padding)*mapSize);

            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }
        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = SystemColors.ButtonShadow;
            label.Font = new Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.ButtonHighlight;
            label.Size = new Size(labelSize, labelSize);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = startX + indexColumn *(labelSize+padding);
            int y = startY + indexRow * (labelSize+padding);
            label.Location = new Point(x, y);

            label.TextChanged += Label_TextChanged;
            return label;
        }

        private void Label_TextChanged(object sender, EventArgs e)
        {
            var label = (Label)sender;

            switch (label.Text)
            {
                case "": label.BackColor = Color.FromArgb(204, 192, 179); break;
                case "2": label.BackColor = Color.FromArgb(238, 228, 218); break;
                case "4": label.BackColor = Color.FromArgb(237, 224, 200); break;
                case "8": label.BackColor = Color.FromArgb(242, 177, 121); break;
                case "16": label.BackColor = Color.FromArgb(245, 149, 99); break;
                case "32": label.BackColor = Color.FromArgb(246, 124, 95); break;
                case "64": label.BackColor = Color.FromArgb(246, 94, 59); break;
                case "128": label.BackColor = Color.FromArgb(237, 207, 114); break;
                case "256": label.BackColor = Color.FromArgb(237, 204, 97); break;
                case "512": label.BackColor = Color.FromArgb(237, 200, 80); break;
                case "1024": label.BackColor = Color.FromArgb(237, 197, 63); break;
                case "2048": label.BackColor = Color.FromArgb(237, 194, 46); break;
            }
        }

        private void TwentyFortyEightMainForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
            {
                return;
            }

            if (e.KeyCode == Keys.Right)
            {
                MoveRight();
            }

            if (e.KeyCode == Keys.Left)
            {
                MoveLeft();
            }

            if (e.KeyCode == Keys.Up)
            {
                MoveUp();
            }

            if (e.KeyCode == Keys.Down)
            {
                MoveDown();
            }

            GenerateNumber();
            ShowScore();
            
            if (Win())
            {
                gameService2048.SaveGameResult(mapSize, score, true);
                MessageBox.Show("Congratulations!!! You are the winner!!!");

               return;
            }

            if (EndGame())
            {
                MessageBox.Show("Unfortunately, you have lost");
                gameService2048.SaveGameResult(mapSize, score, false);
                return;
            }
        }
       
        //private bool EndGame()
        //{
        //    for (int i = 0; i < mapSize; i++)
        //    {
        //        for (int j = 0; j < mapSize; j++)
        //        {
        //            if (labelsMap[i, j].Text == "")
        //            {
        //                return false;
        //            }

        //        }
        //    }

        //    for (int i = 0; i < mapSize - 1; i++)
        //    {
        //        for (int j = 0; j < mapSize - 1; j++)
        //        {
        //            if (labelsMap[i, j].Text == labelsMap[i, j + 1].Text || labelsMap[i, j].Text == labelsMap[i + 1, j].Text)
        //                //(labelsMap[i, j].Text == labelsMap[i, j + 1].Text || labelsMap[i, j].Text == labelsMap[i + 1, j].Text || labelsMap[i + 1, j].Text == labelsMap[i + 1, j + 1].Text)
        //            {
        //                return false;
        //            }
        //        }
        //    }

        //    return true;
        //}

        private bool EndGame()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        return false; 
                    }
                }
            }

            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text.Equals(labelsMap[i, j + 1].Text) ||
                        labelsMap[i, j].Text.Equals(labelsMap[i + 1, j].Text) ||
                        labelsMap[i + 1, j].Text.Equals(labelsMap[i + 1, j + 1].Text))
                    {
                        return false; 
                    }
                }
            }
            return true; 
        }

        private bool Win()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "2048")
                    {
                        return true;

                    }
                }
            }
            return false;
        }

 
        private void MoveRight()
        {
            for (int i = 0; i < mapSize; i++)
            {

                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != String.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != String.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    //GenerateBackColor(labelsMap[i, j], number * 2);
                                    labelsMap[i, k].Text = String.Empty;
                                    labelsMap[i, k].BackColor = SystemColors.AppWorkspace;
                                }

                                break;
                            }

                        }
                    }
                }
            }


            for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text == String.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {

                                if (labelsMap[i, j].Text != labelsMap[i, k].Text)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    // GenerateBackColor(labelsMap[i, j], int.Parse(labelsMap[i, j].Text) * 2);
                                    labelsMap[i, k].Text = String.Empty;
                                    labelsMap[i, k].BackColor = SystemColors.AppWorkspace;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            private void MoveLeft()
            {
                 for (int i = 0; i < mapSize; i++)
                    {
                        for (int j = 0; j < mapSize; j++)
                        {
                            if (labelsMap[i, j].Text != String.Empty)
                            {
                                for (int k = j + 1; k < mapSize; k++)
                                {
                                    if (labelsMap[i, k].Text != String.Empty)
                                    {
                                        if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                        {
                                            var number = int.Parse(labelsMap[i, j].Text);
                                            score += number * 2;
                                            labelsMap[i, j].Text = (number * 2).ToString();
                                            // GenerateBackColor(labelsMap[i, j], number * 2);
                                            labelsMap[i, k].Text = String.Empty;
                                            labelsMap[i, k].BackColor = SystemColors.AppWorkspace;
                                        }

                                        break;
                                    }
                                }
                            }
                        }
                    }

                    for (int i = 0; i < mapSize; i++)
                    {
                        for (int j = 0; j < mapSize; j++)
                        {
                            if (labelsMap[i, j].Text == String.Empty)
                            {
                                for (int k = j + 1; k < mapSize; k++)
                                {

                                    if (labelsMap[i, j].Text != labelsMap[i, k].Text)
                                    {
                                        labelsMap[i, j].Text = labelsMap[i, k].Text;
                                        // GenerateBackColor(labelsMap[i, j], int.Parse(labelsMap[i, j].Text) * 2);
                                        labelsMap[i, k].Text = String.Empty;
                                        labelsMap[i, k].BackColor = SystemColors.AppWorkspace;
                                        break;
                                    }
                                }
                            }
                        }
                    }

                
            }

            private void MoveUp()
            {
               
                    for (int i = 0; i < mapSize; i++)
                    {
                        for (int j = 0; j < mapSize; j++)
                        {
                            if (labelsMap[i, j].Text != String.Empty)
                            {
                                for (int k = i + 1; k < mapSize; k++)
                                {
                                    if (labelsMap[k, j].Text != String.Empty)
                                    {
                                        if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                        {
                                            var number = int.Parse(labelsMap[k, j].Text);
                                            score += number * 2;
                                            labelsMap[i, j].Text = (number * 2).ToString();
                                            labelsMap[k, j].Text = String.Empty;
                                            labelsMap[k, j].BackColor = SystemColors.AppWorkspace;
                                        }

                                        break;
                                    }
                                }
                            }
                        }
                    }

                    for (int i = 0; i < mapSize; i++)
                    {
                        for (int j = 0; j < mapSize; j++)
                        {
                            if (labelsMap[i, j].Text == String.Empty)
                            {
                                for (int k = i + 1; k < mapSize; k++)
                                {

                                    if (labelsMap[i, j].Text != labelsMap[k, j].Text)
                                    {
                                        labelsMap[i, j].Text = labelsMap[k, j].Text;
                                        labelsMap[k, j].Text = String.Empty;
                                        labelsMap[k, j].BackColor = SystemColors.AppWorkspace;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                
            }
            private void MoveDown()
            {
                   for (int i = mapSize - 1; i >= 0; i--)
                    {
                        for (int j = mapSize - 1; j >= 0; j--)
                        {
                            if (labelsMap[i, j].Text != String.Empty)
                            {
                                for (int k = i - 1; k >= 0; k--)
                                {
                                    if (labelsMap[k, j].Text != String.Empty)
                                    {
                                        if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                        {
                                            var number = int.Parse(labelsMap[k, j].Text);
                                            score += number * 2;
                                            labelsMap[i, j].Text = (number * 2).ToString();
                                            //GenerateBackColor(labelsMap[i, j], number * 2);
                                            labelsMap[k, j].Text = String.Empty;
                                            labelsMap[k, j].BackColor = SystemColors.AppWorkspace;
                                        }

                                        break;
                                    }
                                }
                            }
                        }
                    }

                    for (int i = mapSize - 1; i >= 0; i--)
                    {
                        for (int j = mapSize - 1; j >= 0; j--)
                        {
                            if (labelsMap[i, j].Text == String.Empty)
                            {
                                for (int k = i - 1; k >= 0; k--)
                                {

                                    if (labelsMap[i, j].Text != labelsMap[k, j].Text)
                                    {
                                        labelsMap[i, j].Text = labelsMap[k, j].Text;
                                        labelsMap[k, j].Text = String.Empty;
                                        labelsMap[k, j].BackColor = SystemColors.AppWorkspace;
                                        break;
                                    }
                                }
                            }
                        }
                    
                }
            }
            private void restartToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Application.Restart();
            }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("The goal of 2048 is to combine enough tiles to total 2048 before you run out of empty squares. Use your arrow keys to move the tiles left, right, up or down .\r\n\r\nThe objective of the game is to keep combining like numbers until one tile totals 2048.Two numbers will be given: usually two number twos, or maybe one number four. Move the tiles up or down, left or right, trying to join two equal numbered tiles. When two equal numbers touch, they will add together and become one tile with the sum of the original two.\r\n\r\nIf you run out of equal numbers on the grid, or you are unable to touch two equal numbers, the game will automatically add another numbered tile to an empty square so you can continue. If there are no empty squares left on the grid, the game will end. By adding numbers together, you will get continually get larger numbers until you (hopefully) can combine two tiles of 1024 to make one tile totaling 2048. Good luck!");
            }

            private void showResultsToolStripMenuItem_Click(object sender, EventArgs e)
            {
                var tileResultsForm = new TileResultsForm();
                tileResultsForm.ShowDialog();
            }

        
    }
}

