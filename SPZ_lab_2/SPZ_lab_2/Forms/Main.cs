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
using SPZ_lab_2.Forms;

namespace SPZ_lab_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowBooksButton_Click(object sender, EventArgs e)
        {
            AppController.Instance.LoadForm<BooksForm>();
        }

        private void ShowAuthorsButton_Click(object sender, EventArgs e)
        {
            AppController.Instance.LoadForm<AuthorsForm>();
        }

        private void ShowPublishersButton_Click(object sender, EventArgs e)
        {
            AppController.Instance.LoadForm<PublishersForm>();
        }

        private void StatisticButton_Click(object sender, EventArgs e)
        {
            AppController.Instance.LoadForm<Statistics>();
        }
    }
}
