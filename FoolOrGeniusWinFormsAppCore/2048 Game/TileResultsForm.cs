using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using FoolOrGeniusWinFormsApp;
using FoolOrGeniusLibrary;
using FoolOrGenius.DbCore.Models;
using System.Windows.Forms;

namespace FoolOrGeniusWinFormsApp._2048_Game
{
    public partial class TileResultsForm : Form
    {
        public TileResultsForm()
        {
            InitializeComponent();
        }

        private void TileResultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //private void TileResultsForm_Load(object sender, EventArgs e) ///json
        //{
        //    var users = TileUserManager.GetAll(); 
        //    foreach (var user in users)
        //    {
        //        TileResultsDataGridView.Rows.Add(user.Login, user.Score);

        //    }
        //}

        //private void TileResultsForm_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var users = TileUserManager.GetAll();

        //        foreach (var user in users)
        //        {
        //            TileResultsDataGridView.Rows.Add(user.Login, user.Score);
        //        }


        //        TileResultsDataGridView.Refresh();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"An error occurred while loading data: {ex.Message}");
        //    }
        //}
    }
}
