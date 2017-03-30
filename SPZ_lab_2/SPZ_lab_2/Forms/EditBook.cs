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
    public partial class EditBook : Form
    {
        private bool _isEditMode = false;
        private int _index;
        public EditBook()
        {
            InitializeComponent();
            AuthorComboBox.DataSource = AppController.Instance.AuthorsController.Authors;
            PublisherComboBox.DataSource = AppController.Instance.PublishersController.Publishers;
        }

        public void Init(Book book, int index)
        {
            if (null == book)
            {
                return;
                _isEditMode = false;
            }

            TitleLabel.Text = book.Title;

            AuthorComboBox.DataSource = AppController.Instance.AuthorsController.Authors;
            int authorIndex = AppController.Instance.AuthorsController.Authors.IndexOf(book.Author);
            AuthorComboBox.SelectedIndex = authorIndex;

            PublisherComboBox.DataSource = AppController.Instance.PublishersController.Publishers;
            PublisherComboBox.SelectedIndex = AppController.Instance.PublishersController.Publishers.IndexOf(book.Publisher);

            YearUpDown.Value = book.Year;
            _isEditMode = true;
            _index = index;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                try
                {
                    Author author = AppController.Instance.AuthorsController.Authors[AuthorComboBox.SelectedIndex];
                    Publisher publisher =
                        AppController.Instance.PublishersController.Publishers[PublisherComboBox.SelectedIndex];
                    AppController.Instance.BookController.EditBook(_index, TitleLabel.Text, author, publisher,
                        (int) YearUpDown.Value);
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
                    Author author = AppController.Instance.AuthorsController.Authors[AuthorComboBox.SelectedIndex];
                    Publisher publisher =
                        AppController.Instance.PublishersController.Publishers[PublisherComboBox.SelectedIndex];
                    AppController.Instance.BookController.AddBook(TitleLabel.Text, author, publisher,
                        (int)YearUpDown.Value);
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
