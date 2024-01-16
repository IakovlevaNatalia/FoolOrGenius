namespace FoolOrGeniusWinFormsApp
{
    partial class QuestionsListForm
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
            questionsDataGridView = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            questionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            questionsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(8, 24, 70);
            questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2 });
            questionsDataGridView.Location = new System.Drawing.Point(33, 29);
            questionsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.RowHeadersWidth = 51;
            questionsDataGridView.RowTemplate.Height = 24;
            questionsDataGridView.Size = new System.Drawing.Size(680, 98);
            questionsDataGridView.TabIndex = 0;
            questionsDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Text";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 65;
            // 
            // Column2
            // 
            Column2.HeaderText = "Answer";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 86;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(316, 386);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(134, 74);
            button1.TabIndex = 1;
            button1.Text = "Remove Exsisting Question";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // QuestionsListForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(70, 8, 24);
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(button1);
            Controls.Add(questionsDataGridView);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "QuestionsListForm";
            Text = "QuestionsListForm";
            Load += QuestionsListForm_Load;
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
    }
}