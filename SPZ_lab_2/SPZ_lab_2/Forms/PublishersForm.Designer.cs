namespace SPZ_lab_2.Forms
{
    partial class PublishersForm
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
            this.PublishersGrid = new System.Windows.Forms.DataGridView();
            this.AddPublisherButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PublishersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PublishersGrid
            // 
            this.PublishersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PublishersGrid.Location = new System.Drawing.Point(12, 44);
            this.PublishersGrid.Name = "PublishersGrid";
            this.PublishersGrid.Size = new System.Drawing.Size(650, 249);
            this.PublishersGrid.TabIndex = 0;
            this.PublishersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuthorsGrid_CellContentClick);
            // 
            // AddPublisherButton
            // 
            this.AddPublisherButton.Location = new System.Drawing.Point(288, 299);
            this.AddPublisherButton.Name = "AddPublisherButton";
            this.AddPublisherButton.Size = new System.Drawing.Size(82, 23);
            this.AddPublisherButton.TabIndex = 1;
            this.AddPublisherButton.Text = "Add publisher";
            this.AddPublisherButton.UseVisualStyleBackColor = true;
            this.AddPublisherButton.Click += new System.EventHandler(this.AddAuthorButton_Click);
            // 
            // PublishersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 330);
            this.Controls.Add(this.AddPublisherButton);
            this.Controls.Add(this.PublishersGrid);
            this.Name = "PublishersForm";
            this.Text = "AuthorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.PublishersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PublishersGrid;
        private System.Windows.Forms.Button AddPublisherButton;
    }
}