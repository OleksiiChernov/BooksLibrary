using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using SPZ_lab_2.Models;

namespace SPZ_lab_2.Helpers
{
    public static class Utilities
    {
        public static DataTable ConvertToDatatable(List<Book> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Index");
            dt.Columns.Add("Title");
            dt.Columns.Add("Author");
            dt.Columns.Add("Publisher");
            dt.Columns.Add("Year");

            foreach (var item in list)
            {
                var row = dt.NewRow();

                row["Index"] = list.IndexOf(item);
                row["Title"] = item.Title;
                row["Author"] = item.Author;
                row["Publisher"] = item.Publisher;
                row["Year"] = item.Year;
                dt.Rows.Add(row);
            }

            return dt;
        }
    }
}
