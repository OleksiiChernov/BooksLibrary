namespace SPZ_lab_2.Forms
{
    partial class Statistics
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.BooksByAuthorsView = new System.Windows.Forms.DataGridView();
            this.BooksByPublisherView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BooksByAuthorsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksByPublisherView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Books by authors";
            // 
            // BooksByAuthorsView
            // 
            this.BooksByAuthorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksByAuthorsView.Location = new System.Drawing.Point(29, 76);
            this.BooksByAuthorsView.Name = "BooksByAuthorsView";
            this.BooksByAuthorsView.Size = new System.Drawing.Size(364, 425);
            this.BooksByAuthorsView.TabIndex = 2;
            // 
            // BooksByPublisherView
            // 
            this.BooksByPublisherView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksByPublisherView.Location = new System.Drawing.Point(545, 76);
            this.BooksByPublisherView.Name = "BooksByPublisherView";
            this.BooksByPublisherView.Size = new System.Drawing.Size(364, 425);
            this.BooksByPublisherView.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(653, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Books by publisher";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 513);
            this.Controls.Add(this.BooksByPublisherView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BooksByAuthorsView);
            this.Controls.Add(this.label1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.BooksByAuthorsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksByPublisherView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BooksByAuthorsView;
        private System.Windows.Forms.DataGridView BooksByPublisherView;
        private System.Windows.Forms.Label label2;
    }
}