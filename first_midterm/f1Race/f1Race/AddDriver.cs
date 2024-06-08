using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f1Race
{
    public partial class AddDriver : Form
    {
        public Driver driver {  get; set; }
        public AddDriver()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                driver = new Driver(tb_driver_name.Text, (int)nud_driver_age.Value, cb_first_driver.Checked);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void tb_driver_name_Validating(object sender, CancelEventArgs e)
        {
            if (tb_driver_name.Text == "")
            {
                errorProvider_driver_name.SetError(tb_driver_name, "Must enter driver name!");
                e.Cancel = true;
            }
            else
            {
                errorProvider_driver_name.SetError(tb_driver_name, null);
                e.Cancel = false;
            }
        }
    }
}
