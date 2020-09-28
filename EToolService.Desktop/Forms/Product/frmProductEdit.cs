using EToolService.Desktop.Services;
using EToolService.Desktop.UserControls;
using EToolService.Model.Models;
using EToolService.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EToolService.Desktop.Forms.Product
{
    public partial class frmProductEdit : Form
    {
        private readonly APIService _service = new APIService("Product");
        private EToolService.Model.Models.Product _product;
        private string _originalFilename;
        public ProductCard Parent;
        public frmProductEdit(EToolService.Model.Models.Product product)
        {
            InitializeComponent();
            _product = product;

            if (product != null)
            {
                txtCijena.Text = Math.Round(product.Price, 2).ToString();
                txtNaziv.Text = product.ProductName;
                txtPopust.Text = (product.Discount * 100).ToString();
                txtStanje.Text = product.Condition;
                txtDimensions.Text = product.Description;
                valID.Text = product.Id.ToString();
                txtFilename.Text = product.ImageLocation;
                _originalFilename = product.ImageLocation;
                Image image = null;
                try
                {
                    using (var ms = new MemoryStream(product.Image))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                catch (Exception) { }
                imgProductImage.Image = image;
            }
            else
            {
                valID.Visible = false;
                btnPromijeniSliku.ButtonText = "Dodaj sliku";
            }
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPromijeniSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = pictureDialog;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    if (dialog.OpenFile() != null)
                    {
                        txtFilename.Text = dialog.SafeFileName;
                        Stream file = dialog.OpenFile();
                        using (file)
                        {
                            imgProductImage.Image = Image.FromStream(file);
                        }
                    }

                }
                catch (Exception) { }
            }
            else
            {
                return;
            }
        }

        private bool ValidateAll()
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
                return false;
            if (string.IsNullOrEmpty(txtStanje.Text))
                return false;
            if (string.IsNullOrEmpty(txtDimensions.Text))
                return false;

            try
            {
                double.Parse(txtPopust.Text);
                double.Parse(txtCijena.Text);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private async void btnAddRequest_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
            {
                MessageBox.Show("Podaci nisu ispravni", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var request = new ProductUpsertRequest()
            {
                Condition = txtStanje.Text,
                Description = txtDimensions.Text,
                Discount = double.Parse(txtPopust.Text) / 100,
                ProductName = txtNaziv.Text,
                Price = double.Parse(txtCijena.Text)
            };

            if(txtFilename.Text != _originalFilename)
            {
                request.ImageFileName = pictureDialog.SafeFileName;
                try
                {
                    var stream = pictureDialog.OpenFile();
                    using (stream)
                    {
                        request.Image = File.ReadAllBytes(pictureDialog.FileName);
                    }
                }
                catch (Exception) { }
            }

            if(_product != null)
            {
                var result = await _service
                    .Patch<EToolService.Model.Models.Product>(_product.Id, request);

                MessageBox.Show("Uspješno promijenjeno", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Parent.Reload(result);
                this.Close();
            }
            else
            {
                var result = await _service
                    .Insert<EToolService.Model.Models.Product>(request);

                MessageBox.Show("Proizvod uspješno dodan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(_product != null)
                    Parent.Reload(result);
                this.Close();
            }
        }
    }
}
