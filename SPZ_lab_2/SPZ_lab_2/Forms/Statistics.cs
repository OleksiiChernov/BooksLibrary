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
        }

        public void Init()
        {
            List<Book> books = AppController.Instance.BookController.Books;
            BooksByAuthorsChart.DataSource = books;
            BooksByAuthorsChart.Series["BooksByAuthors"].XValueMember = "Author";
            BooksByAuthorsChart.Series["BooksByAuthors"].XValueType = ChartValueType.String;
            BooksByAuthorsChart.Series["BooksByAuthors"].YValueMembers = "Total";
            BooksByAuthorsChart.Series["BooksByAuthors"].YValueType = ChartValueType.Int32;
        }

    }
}
