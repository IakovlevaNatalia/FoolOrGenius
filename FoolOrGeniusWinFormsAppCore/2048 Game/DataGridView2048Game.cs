using System;
using System.Linq;
using System.Windows.Forms;
using FoolOrGenius.Db;
using Microsoft.EntityFrameworkCore;

namespace FoolOrGeniusWinFormsApp._2048_Game
{
    public partial class DataGridView2048Game : Form
    {
        private DatabaseContext db;
        public DataGridView2048Game(DatabaseContext db)
        {
            InitializeComponent();
            this.db = db;

            this.Text = "Users best score";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SetData();

            this.db.Game2048.Load();

            this.dataGridView1.DataSource = db.Game2048.Local.GroupBy(x => x.Login)
                .Select(x => new { Login = x.Key, Score = x.Max(y => y.Score) }).ToList();
        }
        internal void SetData()
        {

            dataGridView1.Columns["loginColumn"].Visible = true;

            dataGridView1.Columns["bestScoreColumn"].Visible = true;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name != "loginColumn" && column.Name != "bestScoreColumn")
                {
                    column.Visible = false;
                }
            }
        }

    }

}
