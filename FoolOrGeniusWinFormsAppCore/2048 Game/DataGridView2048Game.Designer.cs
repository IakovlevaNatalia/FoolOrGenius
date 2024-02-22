namespace FoolOrGeniusWinFormsApp._2048_Game
{
    partial class DataGridView2048Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            loginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bestScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gameIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gameTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gameTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            resultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            gameDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            game2048BindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)game2048BindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(204, 192, 179);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { loginColumn, bestScoreColumn, gameIdDataGridViewTextBoxColumn, gameTypeIdDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, gameTypeDataGridViewTextBoxColumn, userDataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, scoreDataGridViewTextBoxColumn, resultDataGridViewCheckBoxColumn, gameDateTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = game2048BindingSource;
            dataGridView1.Location = new System.Drawing.Point(2, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(746, 446);
            dataGridView1.TabIndex = 0;
            // 
            // loginColumn
            // 
            loginColumn.DataPropertyName = "Login";
            loginColumn.HeaderText = "Login";
            loginColumn.MinimumWidth = 6;
            loginColumn.Name = "loginColumn";
            loginColumn.Width = 125;
            // 
            // bestScoreColumn
            // 
            bestScoreColumn.DataPropertyName = "Score";
            bestScoreColumn.HeaderText = "Best Score";
            bestScoreColumn.MinimumWidth = 6;
            bestScoreColumn.Name = "bestScoreColumn";
            bestScoreColumn.Width = 125;
            // 
            // gameIdDataGridViewTextBoxColumn
            // 
            gameIdDataGridViewTextBoxColumn.DataPropertyName = "GameId";
            gameIdDataGridViewTextBoxColumn.HeaderText = "GameId";
            gameIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            gameIdDataGridViewTextBoxColumn.Name = "gameIdDataGridViewTextBoxColumn";
            gameIdDataGridViewTextBoxColumn.ReadOnly = true;
            gameIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // gameTypeIdDataGridViewTextBoxColumn
            // 
            gameTypeIdDataGridViewTextBoxColumn.DataPropertyName = "GameTypeId";
            gameTypeIdDataGridViewTextBoxColumn.HeaderText = "GameTypeId";
            gameTypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            gameTypeIdDataGridViewTextBoxColumn.Name = "gameTypeIdDataGridViewTextBoxColumn";
            gameTypeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // gameTypeDataGridViewTextBoxColumn
            // 
            gameTypeDataGridViewTextBoxColumn.DataPropertyName = "GameType";
            gameTypeDataGridViewTextBoxColumn.HeaderText = "GameType";
            gameTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            gameTypeDataGridViewTextBoxColumn.Name = "gameTypeDataGridViewTextBoxColumn";
            gameTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // userDataGridViewTextBoxColumn
            // 
            userDataGridViewTextBoxColumn.DataPropertyName = "User";
            userDataGridViewTextBoxColumn.HeaderText = "User";
            userDataGridViewTextBoxColumn.MinimumWidth = 6;
            userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            userDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            loginDataGridViewTextBoxColumn.HeaderText = "Login";
            loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            scoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            scoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultDataGridViewCheckBoxColumn
            // 
            resultDataGridViewCheckBoxColumn.DataPropertyName = "Result";
            resultDataGridViewCheckBoxColumn.HeaderText = "Result";
            resultDataGridViewCheckBoxColumn.MinimumWidth = 6;
            resultDataGridViewCheckBoxColumn.Name = "resultDataGridViewCheckBoxColumn";
            resultDataGridViewCheckBoxColumn.Width = 125;
            // 
            // gameDateTimeDataGridViewTextBoxColumn
            // 
            gameDateTimeDataGridViewTextBoxColumn.DataPropertyName = "GameDateTime";
            gameDateTimeDataGridViewTextBoxColumn.HeaderText = "GameDateTime";
            gameDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            gameDateTimeDataGridViewTextBoxColumn.Name = "gameDateTimeDataGridViewTextBoxColumn";
            gameDateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // game2048BindingSource
            // 
            //game2048BindingSource.DataSource = typeof(FoolOrGenius.DbCore.Models.Game2048);
            // 
            // DataGridView2048Game
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "DataGridView2048Game";
            Text = "DataGridView2048Game";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)game2048BindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource game2048BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn resultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDateTimeDataGridViewTextBoxColumn;
    }
}