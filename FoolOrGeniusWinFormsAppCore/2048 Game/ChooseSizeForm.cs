using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
                    var twentyFortyEightMainForm = Program.Services.GetRequiredService<TwentyFortyEightMainForm>();
                    twentyFortyEightMainForm.Init(selectedSize);
                    twentyFortyEightMainForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Choose the field size.");
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartButton_MouseEnter_1(object sender, EventArgs e)
        {
            StartButton.ForeColor = Color.Blue;
        }

        private void StartButton_MouseLeave_1(object sender, EventArgs e)
        {
            StartButton.ForeColor = Color.White;
        }

        private void closeButton_MouseEnter_1(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave_1(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }
    }
}
