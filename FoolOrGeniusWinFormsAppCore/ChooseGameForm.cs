using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoolOrGeniusWinFormsApp._2048_Game;
using Microsoft.VisualBasic.ApplicationServices;

namespace FoolOrGeniusWinFormsApp
{
    public partial class ChooseGameForm : Form
    {
        public ChooseGameForm()
        {
           

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ChooseGame_Load(object sender, EventArgs e)
        {

        }

        private void TwentyFortyEightGameLabel_Click(object sender, EventArgs e)
        {
            ChooseSizeForm chooseSizeForm = new ChooseSizeForm();
            chooseSizeForm.ShowDialog();
            this.Hide();
            //TwentyFortyEightMainForm twentyFortyEightMainForm = new TwentyFortyEightMainForm();
            //twentyFortyEightMainForm.ShowDialog();


        }
    }
}
