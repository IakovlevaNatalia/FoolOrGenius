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
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.questionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.questionsDataGridView.Location = new System.Drawing.Point(75, 100);
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.RowHeadersWidth = 51;
            this.questionsDataGridView.RowTemplate.Height = 24;
            this.questionsDataGridView.Size = new System.Drawing.Size(680, 323);
            this.questionsDataGridView.TabIndex = 0;
            this.questionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Text";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 62;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Answer";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Remove Exsisting Question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuestionsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.questionsDataGridView);
            this.Name = "QuestionsListForm";
            this.Text = "QuestionsListForm";
            this.Load += new System.EventHandler(this.QuestionsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
    }
}