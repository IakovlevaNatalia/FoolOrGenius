using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp._2048_Game
{
    public partial class ChooseSizeForm : Form
    {
        public List<RadioButton> radioButtons;
        public int SelectedSize { get; private set; }

        public ChooseSizeForm()
        {
            InitializeComponent();
            radioButtons = new List<RadioButton>()
            {
                FourByFourRadioButton, FiveByFiveRadioButton, SixBySixRadioButton, SevenBySevenRadioButton
            };
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        //private void StartButton_Click(object sender, EventArgs e)
        //{

        //    RadioButton selectedRadioButton = radioButtons.FirstOrDefault(rb => rb.Checked);

        //    if (selectedRadioButton != null)
        //    {
        //        string buttonText = selectedRadioButton.Text;

        //        // Извлекаем числовую часть из текста
        //        string numericPart = new string(buttonText.Where(char.IsDigit).ToArray());

        //        if (int.TryParse(numericPart, out int selectedSize))
        //        {
        //            SelectedSize = selectedSize;
        //            this.DialogResult = DialogResult.OK;
        //            this.Close();
        //            MessageBox.Show("я отпарсился");
        //            TwentyFortyEightMainForm twentyFortyEightMainForm = new TwentyFortyEightMainForm(selectedSize);
        //            twentyFortyEightMainForm.ShowDialog();

        //        }
        //        else
        //        {
        //            MessageBox.Show("Невозможно преобразовать числовую часть текста RadioButton в число.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Выберите размер карты.");
        //    }


        //}
        private void StartButton_Click(object sender, EventArgs e)
        {

            RadioButton selectedRadioButton = radioButtons.FirstOrDefault(rb => rb.Checked);

            if (selectedRadioButton != null)
            {
                string buttonText = selectedRadioButton.Text;
                char firstChar = buttonText.FirstOrDefault(char.IsDigit);

                if (char.IsDigit(firstChar))
                {
                    int selectedSize = int.Parse(firstChar.ToString());
                    SelectedSize = selectedSize;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    MessageBox.Show("Я отпарсился");
                    TwentyFortyEightMainForm twentyFortyEightMainForm = new TwentyFortyEightMainForm(selectedSize);
                    twentyFortyEightMainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Не удалось определить размер поля.");
                }
            }
            else
            {
                MessageBox.Show("Выберите размер поля.");
            }
        }
    }
}
