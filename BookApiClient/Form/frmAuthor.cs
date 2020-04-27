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
    public partial class frmAuthor : DevExpress.XtraEditors.XtraForm
    {
        private AuthorRepository _authorRepository = new AuthorRepository();
        private bool _isUpdate = false;
        public frmAuthor()
        {
            InitializeComponent();
            groupControlEdit.Visible = false;
            // load data into gridview
            LoadDataToGridView();
        }

        // load All
        private async void LoadDataToGridView()
        {
            var listAuthor = await _authorRepository.GetAllAuthorsAsync();
            gridControl1.DataSource = listAuthor;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            txtID.Visible = true;
            lblId.Visible = true;
            groupControlEdit.Visible = true;


            txtFullName.Text = "";
            txtAddress.Text = "";
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
                var httpStatusCode = await _authorRepository.DeleteAuthorAsync(Id);
                if (httpStatusCode.ToString().Equals("OK"))
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
            var author = await _authorRepository.GetAuthorAsync(Id);
            if (author == null)
            {
                return;
            }
            txtID.Text = (author.ID).ToString();
            txtFullName.Text = (author.FullName).ToString();
            txtAddress.Text = (author.Address).ToString();

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


        private async void AddData()
        {
            Author author = new Author();
          
            author.FullName = txtFullName.Text;
            author.Address = txtAddress.Text;

            bool x = await _authorRepository.AddNewAuthorAsync(author);
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


        private async void UpdateData()
        {
            Author author = new Author();
            author.ID = int.Parse(txtID.Text);
            author.FullName= txtFullName.Text;
            author.Address = txtAddress.Text;

            bool x = await _authorRepository.EditAuthorAsync(author);
            if (x)
            {
                XtraMessageBox.Show("Edit successfully !", "Success", MessageBoxButtons.OK);
                LoadDataToGridView();
            }
            else
            {
                XtraMessageBox.Show("Edit failed (not null) !", "Fail", MessageBoxButtons.OK);
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