using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ_lab_2.Controllers
{
    public class AppController
    {

        #region Variables

        private static AppController _instance;
        private BookController _bookController;
        private AuthorsController _authorsController;
        private PublishersController _publishersController;

        #endregion


        #region Interface

        public AppController()
        {
            _instance = this;
            _bookController = new BookController();
            _authorsController = new AuthorsController();
            _publishersController = new PublishersController();
        }

        public T LoadForm<T>(Action act = null) where T : Form
        {
            T form = (T)Activator.CreateInstance(typeof(T));
            form.Show();

            act?.Invoke();
            return form;
        }

        #endregion


        #region Properties

        public static AppController Instance
        {
            get
            {
                if (null == _instance)
                {
                    _instance = new AppController();
                }
                return _instance;
            }
        }

        public BookController BookController => _bookController;
        public AuthorsController AuthorsController => _authorsController;
        public PublishersController PublishersController => _publishersController;

        #endregion

    }
}
