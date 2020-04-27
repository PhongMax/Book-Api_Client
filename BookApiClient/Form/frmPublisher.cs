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
using BookApiClient.Models;

namespace BookApiClient
{
    public partial class frmPublisher : DevExpress.XtraEditors.XtraForm
    {
        private PublisherRepository _publisherRepository = new PublisherRepository();
        private bool _isUpdate = false;
        public frmPublisher()
        {
            InitializeComponent();
            groupControlEdit.Visible = false;
            // load data into gridview
            LoadDataToGridView();

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            _isUpdate = true;
            groupControlEdit.Visible = true;
            // get content selected row in gridview
            var CellValue = gridView1.GetFocusedRowCellValue("ID");
            GetDataToEdit(int.Parse(CellValue.ToString()));

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
            XtraMessageBox.Show("Reload successfully !" , "Success", MessageBoxButtons.OK);


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // get content selected row in gridview
            var CellValue = gridView1.GetFocusedRowCellValue("ID");

            DeleteData(int.Parse(CellValue.ToString()));
        }

        private async void AddData()
        {
            Publisher publisher = new Publisher();
           
            publisher.Name = txtName.Text;
            publisher.Phone = txtPhone.Text;
            publisher.Address = txtAddress.Text;

            bool x = await _publisherRepository.AddNewPublisherAsync(publisher);
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

        private async  void UpdateData()
        {
            Publisher publisher = new Publisher();
            publisher.ID = int.Parse(txtID.Text);
            publisher.Name = txtName.Text;
            publisher.Phone = txtPhone.Text;
            publisher.Address = txtAddress.Text;

            bool x = await _publisherRepository.EditPublisherAsync(publisher);
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

        // load All
        private async void LoadDataToGridView()
        {
            var listPublisher = await _publisherRepository.GetAllPublihersAsync();
            gridControl1.DataSource = listPublisher;
        }

        // Load One
        private async void GetDataToEdit(int  Id)
        {
            var Publisher = await _publisherRepository.GetPublisherAsync(Id);
            if (Publisher == null)
            {
                return;
            }
            txtID.Text = (Publisher.ID).ToString();
            txtName.Text = (Publisher.Name).ToString();
            txtPhone.Text = (Publisher.Phone).ToString();
            txtAddress.Text = (Publisher.Address).ToString();

        }


        private async void DeleteData(int Id)
        {

            if (XtraMessageBox.Show("Are you sure  to delete this line? ", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var listPublisher = await _publisherRepository.DeletePublisherAsync(Id);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                UpdateData();

            }else
            {
                AddData();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            groupControlEdit.Visible = false;
            if(_isUpdate)
            {
                _isUpdate = false;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtID.Visible = true;
            lblId.Visible = true;
            groupControlEdit.Visible = true;


            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        

        }
    }
}