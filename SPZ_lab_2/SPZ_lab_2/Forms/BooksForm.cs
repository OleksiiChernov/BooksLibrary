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
using SPZ_lab_2.Helpers;

namespace SPZ_lab_2.Forms
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
            AppController.Instance.BookController.OnBooksChanged += (sender, args) => Init();
            Init();
        }

        private void Init()
        {
            DataTable dt = Utilities.ConvertToDatatable(AppController.Instance.BookController.Books);

            BooksGrid.DataSource = dt;
            BooksGrid.ReadOnly = true;
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.Name = "Edit";
            column.Text = "Edit";
            column.UseColumnTextForButtonValue = true;
            if (BooksGrid.Columns[0].GetType() != typeof(DataGridViewButtonColumn))
            {
                BooksGrid.Columns.Add(column);
            }
        }

        private void BooksGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                EditBook bookForm = AppController.Instance.LoadForm<EditBook>();
                bookForm.Init(AppController.Instance.BookController.Books[e.RowIndex], e.RowIndex);
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AppController.Instance.LoadForm<EditBook>();
        }
    }
}
