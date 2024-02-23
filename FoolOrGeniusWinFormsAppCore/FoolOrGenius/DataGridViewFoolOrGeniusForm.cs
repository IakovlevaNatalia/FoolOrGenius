using System.Linq;
using System;
using System.Windows.Forms;
using FoolOrGenius.Db;
using Microsoft.EntityFrameworkCore;

namespace FoolOrGeniusWinFormsApp.FoolOrGenius
{
    public partial class DataGridViewFoolOrGeniusForm : Form
    {
        private DatabaseContext db;
        public DataGridViewFoolOrGeniusForm(DatabaseContext db)
        {
            InitializeComponent();
            this.db = db;

            this.Text = "User result";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db.Game.Load();

            SetData();

            var result = db.Game
                .Join(db.User, g => g.UserId, u => u.Id, (g, u) => new { game = g, user = u })
                .Join(db.Diagnosis, g => g.game.UserDiagnosis, d => d.Id,
                    (g, d) => new { Login = g.user.Login, Diagnosis = d.DiagnosisName })
                .ToArray();

            this.dataGridView1.DataSource = result;

        }
        private void SetData()
        {

            dataGridView1.Columns["loginColumn"].Visible = true;

            dataGridView1.Columns["DiagnosisColumn"].Visible = true;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name != "loginColumn" && column.Name != "DiagnosisColumn")
                {
                    column.Visible = false;
                }
            }
        }
    }
}
