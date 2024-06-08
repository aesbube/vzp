using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashAccount
{
    public partial class CashRegister : Form
    {
        public CashRegister()
        {
            InitializeComponent();
        }

        private void btn_add_new_Click(object sender, EventArgs e)
        {
            NewProduct productForm = new NewProduct();
            if (productForm.ShowDialog() == DialogResult.OK)
            {
                Product newProduct = productForm.product;
                bool valid = true;
                foreach (Product product in listBoxProducts.Items)
                {
                    if (newProduct.Code == product.Code)
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid) 
                {
                    listBoxProducts.Items.Add(newProduct);
                }
                else
                {
                    MessageBox.Show("Cannot add a produt with an already existing code!");
                }

            }
        }

        private void btn_add_receipt_Click(object sender, EventArgs e)
        {
            btn_add_receipt.Enabled = false;
            Product pr = listBoxProducts.SelectedItem as Product;
            Product_quantity newProductWithQ = new Product_quantity(pr.Code, pr.Name, pr.Price, (int)nud_quantity.Value);
            listBoxReceipt.Items.Add(newProductWithQ);
            nud_quantity.Value = 1;
            updateData();
        }

        private void updateData()
        {
            decimal total = 0;
            decimal totalWithTax = 0;
            foreach (Product_quantity product in listBoxReceipt.Items)
            {
                total += product.Price * product.Quantity;
            }
            totalWithTax = total * (1 + nud_tax.Value / 100);
            tb_total.Text = total.ToString();
            tb_withTax.Text = totalWithTax.ToString();
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex != -1)
            {
                btn_add_receipt.Enabled = true;
            }
        }

        private void btn_delete_receipt_Click(object sender, EventArgs e)
        {
            btn_delete_receipt.Enabled = false;
            int pr = listBoxReceipt.SelectedIndex;
            listBoxReceipt.Items.RemoveAt(pr);
            updateData();
        }

        private void listBoxReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxReceipt.SelectedIndex != -1)
            {
                btn_delete_receipt.Enabled = true;  
            }
        }
    }
}
