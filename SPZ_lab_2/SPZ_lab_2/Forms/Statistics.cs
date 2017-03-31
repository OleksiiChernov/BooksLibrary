using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SPZ_lab_2.Controllers;
using SPZ_lab_2.Models;

namespace SPZ_lab_2.Forms
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            Init();

            AppController.Instance.PublishersController.OnPublishersChanged += OnDataChanged;
            AppController.Instance.AuthorsController.OnAuthorsChanged += OnDataChanged;
            AppController.Instance.BookController.OnBooksChanged += OnDataChanged;

        }

        private void OnDataChanged(object sender, EventArgs eventArgs)
        {
            Init();
        }

        public void Init()
        {
            List<Book> books = AppController.Instance.BookController.Books;
            List<Author> authors = AppController.Instance.AuthorsController.Authors;
            List<Publisher> publishers = AppController.Instance.PublishersController.Publishers;

            DataTable dt_authors = new DataTable();
            Dictionary<Author, int> booksByAuthor = authors.ToDictionary(auth => auth, auth => books.Count(book => book.Author == auth));
            Dictionary<Publisher, int> booksByPublisher = publishers.ToDictionary(publisher => publisher, publisher => books.Count(book => book.Publisher == publisher));
            BooksByAuthorsView.DataSource = booksByAuthor.ToList();
            BooksByPublisherView.DataSource = booksByPublisher.ToList();
        }

    }
}
