using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FoolOrGenius.DbCore.Models;
using Microsoft.Extensions.Hosting.Internal;

namespace FoolOrGeniusWinFormsApp._2048_Game
{
    public partial class TwentyFortyEightMainForm : Form
    {
        private const int labelSize = 70;
        private const int padding = 6;
        private const int startX = 10;
        private const int startY = 70;

        private Label[,] labelsMap;
        private int mapSize = 4;
        private static Random random = new Random();
        private int score = 0;
        private int bestScore = 0;




        public TwentyFortyEightMainForm(int chosenSize)

        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            mapSize = chosenSize;
            //Load += TwentyFortyEightMainFormLoad;
        }

        private void TwentyFortyEightMainFormLoad(object sender, EventArgs e)

        {
            var chooseSize = new ChooseSizeForm();
            //chooseSize.ShowDialog();
            this.Hide();

            //DrawMap(chooseSize.radioButtons);

            InitMap(mapSize);

           // DrawMap(chooseSize.radioButtons);
            GenerateNumber();
            ShowScore();
            CalculateBestScore();
        }

        //private void DrawMap(List<RadioButton> radioButtons)
        //{
        //    //foreach (var item in radioButtons)
        //    //{
        //    //    if (item.Checked)
        //    //        mapSize = Convert.ToInt32(item.Text[0].ToString());
        //    //  break;
        //    //}
        //    foreach (var item in radioButtons)
        //    {
        //        if (item.Checked)
        //        {
        //            mapSize = Convert.ToInt32(item.Text);
        //            break; // Если нашли выбранный RadioButton, завершаем цикл
        //        }
        //    }
        //}

        private void CalculateBestScore()
        {
            var users = TileUserManager.GetAll();

            if (users.Count == 0)
            {
                return;
            }

            bestScore = users[0].Score;
            foreach (var user in users)
            {
                if (user.Score > bestScore)
                {
                    bestScore = user.Score;
                }
            }

            ShowBestScore();
        }

        private void ShowBestScore()
        {
            if (score > bestScore)
            {
                bestScore = score;
            }

            bestScoreLabel.Text = bestScore.ToString();
        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
        }

        //private void GenerateNumber()
        //{
        //    var random = new Random();
        //    while (true)
        //    {
        //        var randomNumberLabel = random.Next(mapSize * mapSize);
        //        var indexRow = randomNumberLabel / mapSize;
        //        var indexColumn = randomNumberLabel % mapSize;
        //        if (labelsMap[indexRow, indexColumn].Text == string.Empty)
        //        {
        //            var randoNumber = random.Next(1, 101);
        //            if (randoNumber <= 75)
        //            {
        //                labelsMap[indexRow, indexColumn].Text = "2";
        //            }
        //            else
        //            {
        //                labelsMap[indexRow, indexColumn].Text = "4";
        //            }

        //            break;
        //        }
        //    }
        //}
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
                        labelsMap[indexRow, indexColumn].BackColor = Color.FromArgb(150, 230, 0);
                    }
                    else
                    {
                        labelsMap[indexRow, indexColumn].Text = "4";
                        labelsMap[indexRow, indexColumn].BackColor = Color.FromArgb(150, 220, 0);
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
            label.Font = new Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            label.Size = new Size(labelSize, labelSize);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = startX + indexColumn *(labelSize+padding);
            int y = startY + indexRow * (labelSize+padding);
            label.Location = new Point(x, y);
            return label;
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
            ShowBestScore();


            if (Win())
            {
                TileUserManager.Add(new UserTile() { Login = "test" + score, Score = score });
                MessageBox.Show("Congratulations!!! You are the winner!!!");
                return;

            }

            if (EndGame())
            {
                TileUserManager.Add(new UserTile() { Login = "test" + score, Score = score });
                MessageBox.Show("Unfortunately, you have lost");
                return;

            }
        }


        private bool EndGame()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "")
                    {
                        return false;
                    }

                }
            }

            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text == labelsMap[i, j + 1].Text || labelsMap[i, j].Text == labelsMap[i + 1, j].Text)
                        //(labelsMap[i, j].Text == labelsMap[i, j + 1].Text || labelsMap[i, j].Text == labelsMap[i + 1, j].Text || labelsMap[i + 1, j].Text == labelsMap[i + 1, j + 1].Text)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        //private bool EndGame()
        //{
        //    for (int i = 0; i < mapSize; i++)
        //    {
        //        for (int j = 0; j < mapSize; j++)
        //        {
        //            //Проверка наличия пустой ячейки
        //            if (labelsMap[i, j].Text == string.Empty)
        //            {
        //                return false; // Если есть пустая ячейка, игра продолжается
        //            }
        //        }
        //    }

        //    for (int i = 0; i < mapSize - 1; i++)
        //    {
        //        for (int j = 0; j < mapSize - 1; j++)
        //        {
        //            //Проверка наличия соседних равных значений
        //            if (labelsMap[i, j].Text.Equals(labelsMap[i, j + 1].Text) ||
        //                labelsMap[i, j].Text.Equals(labelsMap[i + 1, j].Text) ||
        //                labelsMap[i + 1, j].Text.Equals(labelsMap[i + 1, j + 1].Text))
        //            {
        //                return false; // Если есть соседние равные значения, игра продолжается
        //            }
        //        }
        //    }

        //    return true; // Если нет пустых ячеек и соседних равных значений, игра завершена
        //}

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

        //private void MoveDown()
        //{
        //    for (int j = 0; j < mapSize; j++)
        //    {
        //        for (int i = mapSize - 1; i >= 0; i--)
        //        {
        //            if (labelsMap[i, j].Text != string.Empty)
        //            {
        //                for (int k = i - 1; k >= 0; k--)
        //                {
        //                    if (labelsMap[k, j].Text != string.Empty)
        //                    {
        //                        if (labelsMap[i, j].Text == labelsMap[k, j].Text)
        //                        {
        //                            var number = int.Parse(labelsMap[i, j].Text);
        //                            score += number * 2;
        //                            labelsMap[i, j].Text = (number * 2).ToString();
        //                            labelsMap[k, j].Text = string.Empty;
        //                        }
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    for (int j = 0; j < mapSize; j++)
        //    {
        //        for (int i = mapSize - 1; i >= 0; i--)
        //        {
        //            if (labelsMap[i, j].Text == string.Empty)
        //            {
        //                for (int k = i - 1; k >= 0; k--)
        //                {
        //                    if (labelsMap[k, j].Text != string.Empty)
        //                    {
        //                        labelsMap[i, j].Text = labelsMap[k, j].Text;
        //                        labelsMap[k, j].Text = string.Empty;
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //private void MoveUp()
        //{
        //    for (int j = 0; j < mapSize; j++)
        //    {
        //        for (int i = 0; i < mapSize; i++)
        //        {
        //            if (labelsMap[i, j].Text != string.Empty)
        //            {
        //                for (int k = i + 1; k < mapSize; k++)
        //                {
        //                    if (labelsMap[k, j].Text != string.Empty)
        //                    {
        //                        if (labelsMap[i, j].Text == labelsMap[k, j].Text)
        //                        {
        //                            var number = int.Parse(labelsMap[i, j].Text);
        //                            score += number * 2;
        //                            labelsMap[i, j].Text = (number * 2).ToString();
        //                            labelsMap[k, j].Text = string.Empty;
        //                        }
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    for (int j = 0; j < mapSize; j++)
        //    {
        //        for (int i = 0; i < mapSize; i++)
        //        {
        //            if (labelsMap[i, j].Text == string.Empty)
        //            {
        //                for (int k = i + 1; k < mapSize; k++)
        //                {
        //                    if (labelsMap[k, j].Text != string.Empty)
        //                    {
        //                        labelsMap[i, j].Text = labelsMap[k, j].Text;
        //                        labelsMap[k, j].Text = string.Empty;
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}


        //private void MoveLeft()
        //{
        //    for (int i = 0; i < mapSize; i++)
        //    {
        //        for (int j = 0; j < mapSize; j++)
        //        {
        //            if (labelsMap[i, j].Text != string.Empty)
        //            {
        //                for (int k = j + 1; k < mapSize; k++)
        //                {
        //                    if (labelsMap[i, k].Text != string.Empty)
        //                    {
        //                        if (labelsMap[i, j].Text == labelsMap[i, k].Text)
        //                        {
        //                            var number = int.Parse(labelsMap[i, j].Text);
        //                            score += number * 2;
        //                            labelsMap[i, j].Text = (number * 2).ToString();
        //                            labelsMap[i, k].Text = string.Empty;
        //                        }

        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    for (int i = 0; i < mapSize; i++)
        //    {
        //        for (int j = 0; j < mapSize; j++)
        //        {
        //            if (labelsMap[i, j].Text == string.Empty)
        //            {
        //                for (int k = j + 1; k < mapSize; k++)
        //                {
        //                    if (labelsMap[i, k].Text != string.Empty)
        //                    {
        //                        labelsMap[i, j].Text = labelsMap[i, k].Text;
        //                        labelsMap[i, k].Text = string.Empty;
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //private void MoveRight()
        //{
        //        for (int i = 0; i < mapSize; i++)
        //        {
        //            for (int j = mapSize - 1; j >= 0; j--)
        //            {
        //                if (labelsMap[i, j].Text != string.Empty)
        //                {
        //                    for (int k = j - 1; k >= 0; k--)
        //                    {
        //                        if (labelsMap[i, k].Text != string.Empty)
        //                        {
        //                            if (labelsMap[i, j].Text == labelsMap[i, k].Text)
        //                            {
        //                                var number = int.Parse(labelsMap[i, j].Text);
        //                            score += number * 2;
        //                            labelsMap[i, j].Text = (number * 2).ToString();
        //                                labelsMap[i, k].Text = string.Empty;
        //                            }
        //                            break;
        //                        }
        //                    }
        //                }
        //            }
        //        }


        //        for (int i = 0; i < mapSize; i++)
        //        {
        //            for (int j = mapSize - 1; j >= 0; j--)
        //            {
        //                if (labelsMap[i, j].Text == string.Empty)
        //                {
        //                    for (int k = j - 1; k >= 0; k--)
        //                    {
        //                        if (labelsMap[i, k].Text != string.Empty)
        //                        {
        //                            labelsMap[i, j].Text = labelsMap[i, k].Text;
        //                            labelsMap[i, k].Text = string.Empty;
        //                            break;
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //}

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
                                            // GenerateBackColor(labelsMap[i, j], number * 2);
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
                                        // GenerateBackColor(labelsMap[i, j], int.Parse(labelsMap[i, j].Text) * 2);
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
                                        //GenerateBackColor(labelsMap[i, j], int.Parse(labelsMap[i, j].Text) * 2);
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
                MessageBox.Show("Rules");
            }

            private void showResultsToolStripMenuItem_Click(object sender, EventArgs e)
            {
                var tileResultsForm = new TileResultsForm();
                tileResultsForm.ShowDialog();
            }

        
    }
}

