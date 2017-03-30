namespace SPZ_lab_2.Forms
{
    partial class AuthorsForm
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
            this.AuthorsGrid = new System.Windows.Forms.DataGridView();
            this.AddAuthorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorsGrid
            // 
            this.AuthorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsGrid.Location = new System.Drawing.Point(12, 44);
            this.AuthorsGrid.Name = "AuthorsGrid";
            this.AuthorsGrid.Size = new System.Drawing.Size(650, 249);
            this.AuthorsGrid.TabIndex = 0;
            this.AuthorsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuthorsGrid_CellContentClick);
            // 
            // AddAuthorButton
            // 
            this.AddAuthorButton.Location = new System.Drawing.Point(295, 299);
            this.AddAuthorButton.Name = "AddAuthorButton";
            this.AddAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.AddAuthorButton.TabIndex = 1;
            this.AddAuthorButton.Text = "Add author";
            this.AddAuthorButton.UseVisualStyleBackColor = true;
            this.AddAuthorButton.Click += new System.EventHandler(this.AddAuthorButton_Click);
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 330);
            this.Controls.Add(this.AddAuthorButton);
            this.Controls.Add(this.AuthorsGrid);
            this.Name = "AuthorsForm";
            this.Text = "AuthorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AuthorsGrid;
        private System.Windows.Forms.Button AddAuthorButton;
    }
}