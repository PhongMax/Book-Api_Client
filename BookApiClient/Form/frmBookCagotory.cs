using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BookApiClient.Repository;
using BookApiClient.Models;

namespace BookApiClient
{
    public partial class frmBookCagotory : DevExpress.XtraEditors.XtraForm
    {

        private BookCategoryRepository _BookCategoryRepository = new BookCategoryRepository();
        private bool _isUpdate = false;
        public frmBookCagotory()
        {
            InitializeComponent();
            groupControlEdit.Visible = false;
            // load data into gridview
            LoadDataToGridView();
        }
        // load All
        private async void LoadDataToGridView()
        {
            var listBookCategory = await _BookCategoryRepository.GetAllBookCategoryAsync();
            gridControl1.DataSource = listBookCategory;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            txtID.Visible = true;
            lblId.Visible = true;
            groupControlEdit.Visible = true;


            txtName.Text = "";
            txtAlias.Text = "";
            txtDescription.Text = "";

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // get content selected row in gridview
            var CellValue = gridView1.GetFocusedRowCellValue("ID");

            DeleteData(int.Parse(CellValue.ToString()));
        }


        private async void DeleteData(int Id)
        {

            if (XtraMessageBox.Show("Are you sure  to delete this line? ", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var listPublisher = await _BookCategoryRepository.DeleteBookCategoryAsync(Id);
                if (listPublisher.ToString().Equals("OK"))
                {
                    XtraMessageBox.Show("Delete successfully !", "Success", MessageBoxButtons.OK);
                    LoadDataToGridView();
                }
                else
                {
                    XtraMessageBox.Show("Delete failed !", "Fail", MessageBoxButtons.OK);
                }
            }
            else
            {
                return;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            _isUpdate = true;
            groupControlEdit.Visible = true;
            // get content selected row in gridview
            var CellValue = gridView1.GetFocusedRowCellValue("ID");
            GetDataToEdit(int.Parse(CellValue.ToString()));

        }

        // Load One
        private async void GetDataToEdit(int Id)
        {
            var BookCategory = await _BookCategoryRepository.GetBookCategoryAsync(Id);
            if (BookCategory == null)
            {
                return;
            }
            txtID.Text = (BookCategory.ID).ToString();
            txtName.Text = (BookCategory.Name).ToString();
            txtAlias.Text = (BookCategory.Alias).ToString();
            txtDescription.Text = (BookCategory.Description).ToString();

        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
            XtraMessageBox.Show("Reload successfully !", "Success", MessageBoxButtons.OK);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                UpdateData();

            }
            else
            {
                AddData();
            }
        }
        private async void UpdateData()
        {
            BookCategory bookCategory = new BookCategory();
            
            bookCategory.ID = int.Parse(txtID.Text);
            bookCategory.Name = txtName.Text;
            bookCategory.Alias = txtAlias.Text;
            bookCategory.Description = txtDescription.Text;

            bool x = await _BookCategoryRepository.EditBookCategoryAsync(bookCategory);
            if (x)
            {
                XtraMessageBox.Show("Edit successfully !", "Success", MessageBoxButtons.OK);
                LoadDataToGridView();
            }
            else
            {
                XtraMessageBox.Show("Edit failed (not null)!", "Fail", MessageBoxButtons.OK);
            }

        }

        private async void AddData()
        {
            BookCategory bookCategory = new BookCategory();

            bookCategory.Name = txtName.Text;
            bookCategory.Alias = txtAlias.Text;
            bookCategory.Description = txtDescription.Text;

            bool x = await _BookCategoryRepository.AddNewBookCategoryAsync(bookCategory);
            if (x)
            {
                XtraMessageBox.Show("Add New successfully !", "Success", MessageBoxButtons.OK);
                LoadDataToGridView();
            }
            else
            {
                XtraMessageBox.Show("Add New failed (not null)!", "Fail", MessageBoxButtons.OK);
            }

        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            groupControlEdit.Visible = false;
            if (_isUpdate)
            {
                _isUpdate = false;
            }

        }
    }
}