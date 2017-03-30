using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZ_lab_2.Models;

namespace SPZ_lab_2.Controllers
{
    public class AuthorsController
    {

        #region Varialbes

        private List<Author> _authors;

        #endregion


        #region Interface

        public AuthorsController()
        {
            _authors = StorageProvider.LoadFromLocalStorage<List<Author>>(Constants.Strings.AuthorsLibrary);
        }

        public void AddAuthor(string name, string surname)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                MessageBox.Show(Constants.Errors.IncorrectAuthorName);
                return;
            }

            if (null == _authors)
            {
                _authors = new List<Author>();
            }

            if (_authors.Count(author1 => author1.FirstName == name || author1.LastName == surname) > 0)
            {
                MessageBox.Show(Constants.Errors.AuthorNameExist);
                return;
            }

            Author author = new Author { FirstName = name, LastName = surname };
            _authors.Add(author);
            Save();
            MessageBox.Show("Author successfully added.");
        }

        public void EditAuthor(int index, string name, string surname)
        {
            if (index < 0 || index >= _authors.Count)
            {
                MessageBox.Show(Constants.Errors.IncorrectIndex);
                return;
            }
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                MessageBox.Show(Constants.Errors.IncorrectAuthorName);
                return;
            }

            if (null == _authors)
            {
                _authors = new List<Author>();
            }

            if (_authors.Count(author1 => author1.FirstName == name || author1.LastName == surname) > 0)
            {
                MessageBox.Show(Constants.Errors.AuthorNameExist);
                return;
            }

            Author author = new Author {FirstName = name, LastName = surname};
            _authors[index] = author;
            Save();
            MessageBox.Show("Author successfully edited.");
        }

        public void Save()
        {
            if (null != _authors)
            {
                StorageProvider.SaveToLocalStorage(Constants.Strings.AuthorsLibrary, _authors);
                if (null != OnAuthorsChanged)
                {
                    OnAuthorsChanged(this, new EventArgs());
                }
            }
        }

        public void Update()
        {
            _authors = StorageProvider.LoadFromLocalStorage<List<Author>>(Constants.Strings.AuthorsLibrary);
        }

        #endregion


        #region Properties

        public List<Author> Authors => _authors;
        public EventHandler OnAuthorsChanged { get; set; }

        #endregion

    }
}
