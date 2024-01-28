namespace FoolOrGeniusWinFormsApp._2048_Game
{
    partial class TileResultsForm
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
            TileResultsDataGridView = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)TileResultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // TileResultsDataGridView
            // 
            TileResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TileResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2 });
            TileResultsDataGridView.Location = new System.Drawing.Point(27, 13);
            TileResultsDataGridView.Name = "TileResultsDataGridView";
            TileResultsDataGridView.RowHeadersWidth = 51;
            TileResultsDataGridView.Size = new System.Drawing.Size(492, 389);
            TileResultsDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Login";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Score";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // TileResultsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(TileResultsDataGridView);
            Name = "TileResultsForm";
            Text = "TileResultsForm";
            Load += TileResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)TileResultsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView TileResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}