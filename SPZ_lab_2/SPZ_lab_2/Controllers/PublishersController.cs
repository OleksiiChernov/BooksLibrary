using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZ_lab_2.Models;

namespace SPZ_lab_2.Controllers
{
    public class PublishersController
    {
        #region Varialbes

        private List<Publisher> _publishers;

        #endregion


        #region Interface

        public PublishersController()
        {
            _publishers = StorageProvider.LoadFromLocalStorage<List<Publisher>>(Constants.Strings.PublishersLibrary);
        }

        public void AddPublisher(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(Constants.Errors.IncorrectPublisherName);
                return;
            }

            if (null == _publishers)
            {
                _publishers = new List<Publisher>();
            }

            if (_publishers.Count(author1 => author1.Name == name) > 0)
            {
                MessageBox.Show(Constants.Errors.PublisherNameExist);
                return;
            }

            Publisher publisher = new Publisher { Name = name};
            _publishers.Add(publisher);
            Save();
            MessageBox.Show("Publisher successfully added.");
        }

        public void EditPublisher(int index, string name)
        {
            if (index < 0 || index >= _publishers.Count)
            {
                MessageBox.Show(Constants.Errors.IncorrectIndex);
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(Constants.Errors.IncorrectPublisherName);
                return;
            }

            if (null == _publishers)
            {
                _publishers = new List<Publisher>();
            }

            if (_publishers.Count(author1 => author1.Name == name) > 0)
            {
                MessageBox.Show(Constants.Errors.PublisherNameExist);
                return;
            }

            Publisher publisher = new Publisher { Name = name };
            _publishers[index] = publisher;
            Save();
            MessageBox.Show("Publisher successfully edited.");
        }

        public void Save()
        {
            if (null != _publishers)
            {
                StorageProvider.SaveToLocalStorage(Constants.Strings.PublishersLibrary, _publishers);
                if (null != OnPublishersChanged)
                {
                    OnPublishersChanged(this, new EventArgs());
                }
            }
        }

        public void Update()
        {
            _publishers = StorageProvider.LoadFromLocalStorage<List<Publisher>>(Constants.Strings.PublishersLibrary);
        }

        #endregion


        #region Properties

        public List<Publisher> Publishers => _publishers;
        public EventHandler OnPublishersChanged { get; set; }

        #endregion

    }
}
