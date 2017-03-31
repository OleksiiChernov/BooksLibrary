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
    public partial class AuthorsForm : Form
    {
        public AuthorsForm()
        {
            InitializeComponent();
            AppController.Instance.AuthorsController.OnAuthorsChanged += (sender, args) => Init();
            Init();
        }

        private void Init()
        {
            AuthorsGrid.DataSource = AppController.Instance.AuthorsController.Authors;
            AuthorsGrid.ReadOnly = true;

            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.Name = "Edit";
            column.Text = "Edit";
            column.UseColumnTextForButtonValue = true;

            if (AuthorsGrid.Columns[0].GetType() != typeof(DataGridViewButtonColumn))
            {
                AuthorsGrid.Columns.Add(column);
            }
        }

        private void AuthorsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                EditAuthor authForm = AppController.Instance.LoadForm<EditAuthor>();
                authForm.Init(AppController.Instance.AuthorsController.Authors[e.RowIndex], e.RowIndex);
            }
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            AppController.Instance.LoadForm<EditAuthor>();
        }
    }
}
