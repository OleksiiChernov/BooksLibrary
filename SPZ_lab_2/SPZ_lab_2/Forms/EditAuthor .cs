using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZ_lab_2.Controllers;
using SPZ_lab_2.Models;

namespace SPZ_lab_2.Forms
{
    public partial class EditAuthor : Form
    {
        private bool _isEditMode = false;
        private int _index;
        public EditAuthor()
        {
            InitializeComponent();
        }

        public void Init(Author author, int index)
        {
            if (null == author)
            {
                return;
                _isEditMode = false;
            }

            FirstNameLabel.Text = author.FirstName;
            LastNameLabel.Text = author.LastName;
            
            _isEditMode = true;
            _index = index;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                try
                {
                    AppController.Instance.AuthorsController.EditAuthor(_index, FirstNameLabel.Text, LastNameLabel.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    AppController.Instance.AuthorsController.AddAuthor(FirstNameLabel.Text, LastNameLabel.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    return;
                }
            }
        }
    }
}
