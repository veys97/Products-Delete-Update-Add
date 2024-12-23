using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDull _prdDull = new ProductDull();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _prdDull.GetAll();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            _prdDull.Add(new Product
            {
                Name = firsttbox.Text,
                UnitPrice = Convert.ToDecimal(secondtbox.Text),  
                StockAmount = Convert.ToInt32(thirdtbox.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Added!");
        }
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString(); 
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString(); 
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                ID = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            };
            _prdDull.Update(product);
            LoadProducts();
            MessageBox.Show("Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _prdDull.Delete(id);
            LoadProducts();
            MessageBox.Show("Deleted!");
        }
    }
}
