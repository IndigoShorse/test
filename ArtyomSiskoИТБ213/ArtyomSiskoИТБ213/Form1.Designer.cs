namespace ArtyomSiskoИТБ213
{
    partial class index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainButton = new System.Windows.Forms.Button();
            this.team1Box = new System.Windows.Forms.TextBox();
            this.team2Box = new System.Windows.Forms.TextBox();
            this.team1UpDown = new System.Windows.Forms.NumericUpDown();
            this.team2UpDown = new System.Windows.Forms.NumericUpDown();
            this.gameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.team1UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mainButton
            // 
            this.mainButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainButton.Location = new System.Drawing.Point(32, 222);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(169, 54);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "Принять";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // team1Box
            // 
            this.team1Box.Location = new System.Drawing.Point(34, 69);
            this.team1Box.Name = "team1Box";
            this.team1Box.ReadOnly = true;
            this.team1Box.Size = new System.Drawing.Size(108, 23);
            this.team1Box.TabIndex = 1;
            // 
            // team2Box
            // 
            this.team2Box.Location = new System.Drawing.Point(516, 69);
            this.team2Box.Name = "team2Box";
            this.team2Box.ReadOnly = true;
            this.team2Box.Size = new System.Drawing.Size(124, 23);
            this.team2Box.TabIndex = 2;
            // 
            // team1UpDown
            // 
            this.team1UpDown.Location = new System.Drawing.Point(32, 122);
            this.team1UpDown.Name = "team1UpDown";
            this.team1UpDown.Size = new System.Drawing.Size(110, 23);
            this.team1UpDown.TabIndex = 5;
            // 
            // team2UpDown
            // 
            this.team2UpDown.Location = new System.Drawing.Point(516, 122);
            this.team2UpDown.Name = "team2UpDown";
            this.team2UpDown.Size = new System.Drawing.Size(124, 23);
            this.team2UpDown.TabIndex = 6;
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameLabel.Location = new System.Drawing.Point(278, 9);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(129, 28);
            this.gameLabel.TabIndex = 7;
            this.gameLabel.Text = "Первый этап";
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.team2UpDown);
            this.Controls.Add(this.team1UpDown);
            this.Controls.Add(this.team2Box);
            this.Controls.Add(this.team1Box);
            this.Controls.Add(this.mainButton);
            this.Name = "index";
            this.Text = "Index";
            ((System.ComponentModel.ISupportInitialize)(this.team1UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button mainButton;
        private TextBox team1Box;
        private TextBox team2Box;
        private NumericUpDown team1UpDown;
        private NumericUpDown team2UpDown;
        private Label gameLabel;
    }
}