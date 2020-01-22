using ShopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class WorkerDashboard : Form
    {
        ShopDB db = new ShopDB();
        Product selectedPro;
        Worker activeWorker;
        #region Cunsturctor
        public WorkerDashboard(Worker actWork)
        {
            activeWorker = actWork;
            InitializeComponent();
        }
        #endregion

        private void FillDataGrid()
        {
            double minPrice = (double)nmMinPrice.Value;
            double maxPrice = (double)nmMaxPrice.Value;

            dtgSaleProduct.DataSource = db.Orders.Where(or=>or.WorkerId==activeWorker.Id && or.Product.Category.Name.StartsWith(cmbFilterCat.Text)
            ).Select(or => new
            {
                or.Product.ProductName,
                or.Counts,
                or.PurchaseDate,
                or.Price
            }).ToList();

        }
        #region Worker Load Event
        private void WorkerDashboard_Load(object sender, EventArgs e)
        {
            nmMaxPrice.Maximum = (decimal)db.Orders.Where(or=>or.WorkerId==activeWorker.Id).Max(or => or.Price);
            nmMinPrice.Maximum = (decimal)db.Orders.Where(or => or.WorkerId == activeWorker.Id).Max(or => or.Price);
            nmMinPrice.Minimum= (decimal)db.Orders.Where(or => or.WorkerId == activeWorker.Id).Min(or => or.Price);

            CmbCategoryFill();
            FillDataGrid();
            cmbCategory.Items.AddRange(db.Categories.Select(ct => ct.Name).ToArray());
        }
#endregion

        private void CmbCategoryFill()
        {
            cmbFilterCat.Items.AddRange(db.Categories.Select(ct => ct.Name).ToArray());
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProducts.Items.Clear();
            Category selectedCategory = db.Categories.FirstOrDefault(ct => ct.Name == cmbCategory.Text);
            if (selectedCategory != null)
            {
                cmbProducts.Items.AddRange(db.Products.Where(pr => pr.CategoryId == selectedCategory.Id).Select(pr=>pr.ProductName).ToArray());

            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string proname = cmbProducts.Text;
            selectedPro = db.Products.FirstOrDefault(pr => pr.ProductName == proname);
            if (selectedPro != null)
            {
                if (selectedPro.Amounts <= 0)
                {
                    lblStock.Visible = true;
                    lblStock.Text = "Stockda bu mehsuldan qalmayib";
                    lblStock.BackColor = Color.Crimson;
                    lblStock.ForeColor = Color.White;
                    btnSale.Enabled = false;
                    nmCount.Enabled = false;
                }

                else
                {
                    lblStock.Visible = true;
                    lblStock.Text = $"Mehsuldan {selectedPro.Amounts} qeder qalib";
                    lblStock.BackColor = Color.Green;
                    lblStock.ForeColor= Color.White;
                    btnSale.Enabled = true;
                    nmCount.Enabled = true;
                    lblPrice.Text = (selectedPro.Price * (double)nmCount.Value).ToString();
                    lblPrice.Visible = true;

                }
            }
        }

        private void nmCount_ValueChanged(object sender, EventArgs e)
        {
            if (nmCount.Value > selectedPro.Amounts)
            {
                nmCount.Maximum = (decimal)selectedPro.Amounts;
            }
            else
            {
                lblPrice.Text = (selectedPro.Price * (double)nmCount.Value).ToString();
            }
            //lblPrice.visi
        }
        private void ClearAllData()
        {
            foreach (Control  cnt in this.Controls)
            {
                if(cnt is ComboBox)
                {
                    //ComboBox combo = (ComboBox)cnt;
                    cnt.Text = "";
                }
                if(cnt is RichTextBox)
                {
                    cnt.Text = "";
                }
            }
        }
        private void btnSale_Click(object sender, EventArgs e)
        {
            int count = (int)nmCount.Value;
            db.Orders.Add(new Order
            {
                WorkerId = activeWorker.Id,
                ProductId = selectedPro.Id,
                Price = Convert.ToDouble(lblPrice.Text),
                PurchaseDate = DateTime.Now,
                Counts = count
            });
            selectedPro.Amounts -= count;
            db.SaveChanges();
            lblPrice.Visible = false;
            lblStock.Visible = false;
            btnSale.Enabled = false;
            MessageBox.Show("Product Sale Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataGrid();
            ClearAllData();
        }

        private void cmbFilterCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double minPrice = (double)nmMinPrice.Value;
            double maxPrice = (double)nmMaxPrice.Value;
            double maxDBPrice = (double)db.Orders.Where(or => or.WorkerId == activeWorker.Id).Max(pr => pr.Price);
            double minDBPrice= (double)db.Orders.Where(or => or.WorkerId == activeWorker.Id).Min(pr => pr.Price);

            if (maxPrice <minPrice)
            {
                maxPrice = maxDBPrice;
            }
            dtgSaleProduct.DataSource = db.Orders.Where(or => or.WorkerId == activeWorker.Id && or.Product.Category.Name.StartsWith(cmbFilterCat.Text)
            &&  or.Price>=minPrice && or.Price<=maxPrice).Select(or => new
            {
                or.Product.ProductName,
                or.Counts,
                or.PurchaseDate,
                or.Price
            }).ToList();
        }

        private void cmbFilterCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            FillDataGrid();
        }
    }
}
