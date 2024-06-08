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
    public partial class NewProduct : Form
    {
        public Product product {  get; set; }
        public NewProduct()
        {
            InitializeComponent();
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.product = new Product((int)nud_code.Value, tb_name.Text, nud_price.Value);
                this.DialogResult = DialogResult.OK;
            }
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tb_name_Validating(object sender, CancelEventArgs e)
        {
            if (tb_name.Text == "")
            {
                errorProvider_name.SetError(tb_name, "Must enter name of product!");
                e.Cancel = true;
            }
            else
            {
                errorProvider_name.SetError(tb_name, null);
            }

        }

        
    }
}
