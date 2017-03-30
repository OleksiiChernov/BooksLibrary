namespace SPZ_lab_2
{
    partial class MainForm
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
            this.ShowBooksButton = new System.Windows.Forms.Button();
            this.ShowAuthorsButton = new System.Windows.Forms.Button();
            this.ShowPublishersButton = new System.Windows.Forms.Button();
            this.StatisticButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowBooksButton
            // 
            this.ShowBooksButton.Location = new System.Drawing.Point(101, 58);
            this.ShowBooksButton.Name = "ShowBooksButton";
            this.ShowBooksButton.Size = new System.Drawing.Size(98, 23);
            this.ShowBooksButton.TabIndex = 0;
            this.ShowBooksButton.Text = "Show books";
            this.ShowBooksButton.UseVisualStyleBackColor = true;
            this.ShowBooksButton.Click += new System.EventHandler(this.ShowBooksButton_Click);
            // 
            // ShowAuthorsButton
            // 
            this.ShowAuthorsButton.Location = new System.Drawing.Point(101, 87);
            this.ShowAuthorsButton.Name = "ShowAuthorsButton";
            this.ShowAuthorsButton.Size = new System.Drawing.Size(98, 23);
            this.ShowAuthorsButton.TabIndex = 1;
            this.ShowAuthorsButton.Text = "Show authors";
            this.ShowAuthorsButton.UseVisualStyleBackColor = true;
            this.ShowAuthorsButton.Click += new System.EventHandler(this.ShowAuthorsButton_Click);
            // 
            // ShowPublishersButton
            // 
            this.ShowPublishersButton.Location = new System.Drawing.Point(101, 119);
            this.ShowPublishersButton.Name = "ShowPublishersButton";
            this.ShowPublishersButton.Size = new System.Drawing.Size(98, 23);
            this.ShowPublishersButton.TabIndex = 2;
            this.ShowPublishersButton.Text = "Show publishers";
            this.ShowPublishersButton.UseVisualStyleBackColor = true;
            this.ShowPublishersButton.Click += new System.EventHandler(this.ShowPublishersButton_Click);
            // 
            // StatisticButton
            // 
            this.StatisticButton.Location = new System.Drawing.Point(101, 148);
            this.StatisticButton.Name = "StatisticButton";
            this.StatisticButton.Size = new System.Drawing.Size(98, 23);
            this.StatisticButton.TabIndex = 3;
            this.StatisticButton.Text = "Statistic";
            this.StatisticButton.UseVisualStyleBackColor = true;
            this.StatisticButton.Click += new System.EventHandler(this.StatisticButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.StatisticButton);
            this.Controls.Add(this.ShowPublishersButton);
            this.Controls.Add(this.ShowAuthorsButton);
            this.Controls.Add(this.ShowBooksButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowBooksButton;
        private System.Windows.Forms.Button ShowAuthorsButton;
        private System.Windows.Forms.Button ShowPublishersButton;
        private System.Windows.Forms.Button StatisticButton;
    }
}

