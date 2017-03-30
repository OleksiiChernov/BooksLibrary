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
using SPZ_lab_2.Models;

namespace SPZ_lab_2.Forms
{
    public partial class EditPublisher : Form
    {
        private bool _isEditMode = false;
        private int _index;
        public EditPublisher()
        {
            InitializeComponent();
        }

        public void Init(Publisher publisher, int index)
        {
            if (null == publisher)
            {
                return;
                _isEditMode = false;
            }

            Name.Text = publisher.Name;
            
            _isEditMode = true;
            _index = index;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                try
                {
                    AppController.Instance.PublishersController.EditPublisher(_index, Name.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    AppController.Instance.PublishersController.AddPublisher(Name.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    return;
                }
            }
        }
    }
}
