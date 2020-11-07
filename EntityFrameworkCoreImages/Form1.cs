using System;
using System.ComponentModel;
using System.Windows.Forms;
using EntityFrameworkCoreImages.Classes;
using EntityFrameworkCoreImages.Models;

namespace EntityFrameworkCoreImages
{
    public partial class Form1 : Form
    {
        private BindingList<Categories> _categoriesBindingList = new BindingList<Categories>();
        private readonly BindingSource _categoryBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            _categoriesBindingList = new BindingList<Categories>(await CategoryOperations.GetCategoriesAsync());
            _categoryBindingSource.DataSource = _categoriesBindingList;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _categoryBindingSource;

            dataGridView1.ExpandColumns();

            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
        }
        /// <summary>
        /// Populate image for current category and if no image a error image which could
        /// be null instead, see GetPictureBytes comments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = CategoryOperations.GetPictureBytes(((Categories)_categoryBindingSource.Current).CategoryId);
        }
    }
}
