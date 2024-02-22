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

            //this.dataGridView1.DataSource = db.Game.Local.GroupBy(x => x.UserId)
            //    .Select(x => new { Login = x.Key, Diagnosis = x.Key(y => y.D) }).ToList();
            //this.dataGridView1.DataSource = db.Game.Local
            //    .GroupJoin(
            //        db.User.Local,  // Ваша другая таблица
            //        game => game.UserId,  // Свойство в таблице Game
            //        user => user.Login,  // Свойство в таблице Users
            //        (game, users) => new
            //        {
            //            UserId = game.UserId,
            //            Login = users.FirstOrDefault()?.Login,  // Берем логин первого пользователя или null
            //            Diagnosis = game.UserDiagnosis
            //        })
            //    .ToList();

            var result = (from game in db.Game.Local
                join user in db.User.Local on game.UserId equals user.Id
                join diagnosis in db.Diagnosis.Local on game.UserDiagnosis equals diagnosis.Id
                select new
                {
                    Login = user.Login,
                    DiagnosisName = diagnosis.DiagnosisName
                }).ToList();

            this.dataGridView1.DataSource = result;

            // Ваш код для скрытия колонок
            this.dataGridView1.Columns["loginColumn"].Visible = true;
            this.dataGridView1.Columns["DiagnosisColumn"].Visible = true;

            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                if (column.Name != "loginColumn" && column.Name != "DiagnosisColumn")
                {
                    column.Visible = false;
                }
            }
        }
        internal void SetData()
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
