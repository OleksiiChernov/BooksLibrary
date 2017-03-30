using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZ_lab_2.Models;

namespace SPZ_lab_2.Controllers
{
    public class BookController
    {

        #region Variables

        private List<Book> _books;

        #endregion


        #region Interface

        public BookController()
        {
            _books = StorageProvider.LoadFromLocalStorage<List<Book>>(Constants.Strings.BooksLibrary);
        }

        public void AddBook(string title, Author author, Publisher publisher, int year)
        {
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show(Constants.Errors.IncorrectTitle);
                return;
            }
            if (null == author)
            {
                MessageBox.Show(Constants.Errors.NullAuthor);
                return;
            }
            if (null == publisher)
            {
                MessageBox.Show(Constants.Errors.NullPublisher);
                return;
            }
            if (year > DateTime.Today.Year)
            {
                MessageBox.Show(Constants.Errors.IncorrectYear);
                return;
            }

            Book book = new Book {Title = title, Author = author, Publisher = publisher, Year = year};

            if (null == _books)
            {
                _books = new List<Book>();
            }
            _books.Add(book);
            Save();
            MessageBox.Show("Book successfully added.");
        }

        public void EditBook(int index, string title, Author author, Publisher publisher, int year)
        {
            if (index >= _books.Count || index < 0)
            {
                MessageBox.Show(Constants.Errors.IncorrectIndex);
                return;
            }

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show(Constants.Errors.IncorrectTitle);
                return;
            }
            if (null == author)
            {
                MessageBox.Show(Constants.Errors.NullAuthor);
                return;
            }
            if (null == publisher)
            {
                MessageBox.Show(Constants.Errors.NullPublisher);
                return;
            }
            if (year > DateTime.Today.Year)
            {
                MessageBox.Show(Constants.Errors.IncorrectYear);
                return;
            }

            Book book = new Book { Title = title, Author = author, Publisher = publisher, Year = year };
            _books[index] = book;
            Save();
            MessageBox.Show("Book successfully edited.");
        }

        public void Save()
        {
            if (null != _books)
            {
                StorageProvider.SaveToLocalStorage(Constants.Strings.BooksLibrary, _books);
                if (null != OnBooksChanged)
                {
                    OnBooksChanged(this, new EventArgs());
                }
            }
        }

        public void Update()
        {
            _books = StorageProvider.LoadFromLocalStorage<List<Book>>(Constants.Strings.BooksLibrary);
        }

        public void Test()
        {
            Author auth = new Author {FirstName = "Jonh", LastName = "Richter"};
            Publisher publisher = new Publisher {Name = "Microsoft Press"};

            AddBook("CLR via C#", auth, publisher, 2012);

        }

        #endregion


        #region Properties

        public List<Book> Books => _books;
        public EventHandler OnBooksChanged { get; set; }

        #endregion

    }
}
