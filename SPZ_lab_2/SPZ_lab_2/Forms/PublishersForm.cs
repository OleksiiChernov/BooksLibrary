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
    public partial class PublishersForm : Form
    {
        public PublishersForm()
        {
            InitializeComponent();
            AppController.Instance.PublishersController.OnPublishersChanged += (sender, args) => Init();
            Init();
        }

        private void Init()
        {
            PublishersGrid.DataSource = AppController.Instance.PublishersController.Publishers;
            PublishersGrid.ReadOnly = true;
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.Name = "Edit";
            column.Text = "Edit";
            column.UseColumnTextForButtonValue = true;
            PublishersGrid.Columns.Add(column);
        }

        private void AuthorsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                EditPublisher authForm = AppController.Instance.LoadForm<EditPublisher>();
                authForm.Init(AppController.Instance.PublishersController.Publishers[e.RowIndex], e.RowIndex);
            }
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            AppController.Instance.LoadForm<EditPublisher>();
        }
    }
}
