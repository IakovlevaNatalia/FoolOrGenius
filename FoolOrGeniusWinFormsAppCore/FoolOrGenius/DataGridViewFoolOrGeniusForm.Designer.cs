namespace FoolOrGeniusWinFormsApp.FoolOrGenius
{
    partial class DataGridViewFoolOrGeniusForm
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            loginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DiagnosisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { loginColumn, DiagnosisColumn });
            dataGridView1.Location = new System.Drawing.Point(11, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // loginColumn
            // 
            loginColumn.HeaderText = "Login";
            loginColumn.MinimumWidth = 6;
            loginColumn.Name = "loginColumn";
            loginColumn.Width = 125;
            // 
            // DiagnosisColumn
            // 
            DiagnosisColumn.HeaderText = "Diagnosis";
            DiagnosisColumn.MinimumWidth = 6;
            DiagnosisColumn.Name = "DiagnosisColumn";
            DiagnosisColumn.Width = 125;
            // 
            // DataGridViewFoolOrGeniusForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "DataGridViewFoolOrGeniusForm";
            Text = "DataGridViewFoolOrGeniusForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisColumn;
    }
}