namespace SPZ_lab_2.Forms
{
    partial class EditBook
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditBookLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.TextBox();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.PublisherComboBox = new System.Windows.Forms.ComboBox();
            this.YearUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.YearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(110, 226);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditBookLabel
            // 
            this.EditBookLabel.AutoSize = true;
            this.EditBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBookLabel.Location = new System.Drawing.Point(109, 9);
            this.EditBookLabel.Name = "EditBookLabel";
            this.EditBookLabel.Size = new System.Drawing.Size(76, 20);
            this.EditBookLabel.TabIndex = 1;
            this.EditBookLabel.Text = "Edit book";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Location = new System.Drawing.Point(109, 54);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(163, 20);
            this.TitleLabel.TabIndex = 2;
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Location = new System.Drawing.Point(109, 80);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(163, 21);
            this.AuthorComboBox.TabIndex = 3;
            // 
            // PublisherComboBox
            // 
            this.PublisherComboBox.FormattingEnabled = true;
            this.PublisherComboBox.Location = new System.Drawing.Point(109, 108);
            this.PublisherComboBox.Name = "PublisherComboBox";
            this.PublisherComboBox.Size = new System.Drawing.Size(163, 21);
            this.PublisherComboBox.TabIndex = 4;
            // 
            // YearUpDown
            // 
            this.YearUpDown.Location = new System.Drawing.Point(109, 135);
            this.YearUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.YearUpDown.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.YearUpDown.Name = "YearUpDown";
            this.YearUpDown.Size = new System.Drawing.Size(163, 20);
            this.YearUpDown.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Publisher:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Year:";
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YearUpDown);
            this.Controls.Add(this.PublisherComboBox);
            this.Controls.Add(this.AuthorComboBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.EditBookLabel);
            this.Controls.Add(this.SaveButton);
            this.Name = "EditBook";
            this.Text = "EditBook";
            ((System.ComponentModel.ISupportInitialize)(this.YearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label EditBookLabel;
        private System.Windows.Forms.TextBox TitleLabel;
        private System.Windows.Forms.ComboBox AuthorComboBox;
        private System.Windows.Forms.ComboBox PublisherComboBox;
        private System.Windows.Forms.NumericUpDown YearUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}