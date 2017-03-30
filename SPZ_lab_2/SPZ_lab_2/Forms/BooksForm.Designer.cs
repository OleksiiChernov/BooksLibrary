namespace SPZ_lab_2.Forms
{
    partial class BooksForm
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
            this.BooksGrid = new System.Windows.Forms.DataGridView();
            this.AddBookButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BooksGrid
            // 
            this.BooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksGrid.Location = new System.Drawing.Point(12, 44);
            this.BooksGrid.Name = "BooksGrid";
            this.BooksGrid.Size = new System.Drawing.Size(650, 249);
            this.BooksGrid.TabIndex = 0;
            this.BooksGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksGrid_CellContentClick);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(287, 299);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(75, 23);
            this.AddBookButton.TabIndex = 2;
            this.AddBookButton.Text = "Add book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 330);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.BooksGrid);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.BooksGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BooksGrid;
        private System.Windows.Forms.Button AddBookButton;
    }
}