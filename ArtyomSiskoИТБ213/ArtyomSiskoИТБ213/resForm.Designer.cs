namespace ArtyomSiskoИТБ213
{
    partial class resForm
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
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            this.positionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsGrid
            // 
            this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionCol,
            this.nameCol,
            this.sumCol});
            this.resultsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGrid.Location = new System.Drawing.Point(0, 0);
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.RowTemplate.Height = 25;
            this.resultsGrid.Size = new System.Drawing.Size(800, 450);
            this.resultsGrid.TabIndex = 0;
            // 
            // positionCol
            // 
            this.positionCol.HeaderText = "Место";
            this.positionCol.Name = "positionCol";
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Имя команды";
            this.nameCol.Name = "nameCol";
            // 
            // sumCol
            // 
            this.sumCol.HeaderText = "Очки";
            this.sumCol.Name = "sumCol";
            // 
            // resForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsGrid);
            this.Name = "resForm";
            this.Text = "resForm";
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView resultsGrid;
        private DataGridViewTextBoxColumn positionCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn sumCol;
    }
}