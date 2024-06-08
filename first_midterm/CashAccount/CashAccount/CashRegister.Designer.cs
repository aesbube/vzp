namespace CashAccount
{
    partial class CashRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.listBoxReceipt = new System.Windows.Forms.ListBox();
            this.groupBox_products = new System.Windows.Forms.GroupBox();
            this.btn_add_new = new System.Windows.Forms.Button();
            this.btn_add_receipt = new System.Windows.Forms.Button();
            this.label_quantity = new System.Windows.Forms.Label();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox_receipt = new System.Windows.Forms.GroupBox();
            this.label_money = new System.Windows.Forms.Label();
            this.label_tax = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.btn_delete_receipt = new System.Windows.Forms.Button();
            this.tb_withTax = new System.Windows.Forms.TextBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.nud_tax = new System.Windows.Forms.NumericUpDown();
            this.errorProvider_addNew = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            this.groupBox_receipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_addNew)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(22, 21);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(267, 260);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // listBoxReceipt
            // 
            this.listBoxReceipt.FormattingEnabled = true;
            this.listBoxReceipt.ItemHeight = 16;
            this.listBoxReceipt.Location = new System.Drawing.Point(6, 21);
            this.listBoxReceipt.Name = "listBoxReceipt";
            this.listBoxReceipt.Size = new System.Drawing.Size(345, 228);
            this.listBoxReceipt.TabIndex = 1;
            this.listBoxReceipt.SelectedIndexChanged += new System.EventHandler(this.listBoxReceipt_SelectedIndexChanged);
            // 
            // groupBox_products
            // 
            this.groupBox_products.Controls.Add(this.btn_add_new);
            this.groupBox_products.Controls.Add(this.btn_add_receipt);
            this.groupBox_products.Controls.Add(this.label_quantity);
            this.groupBox_products.Controls.Add(this.nud_quantity);
            this.groupBox_products.Controls.Add(this.listBoxProducts);
            this.groupBox_products.Location = new System.Drawing.Point(12, 12);
            this.groupBox_products.Name = "groupBox_products";
            this.groupBox_products.Size = new System.Drawing.Size(306, 395);
            this.groupBox_products.TabIndex = 2;
            this.groupBox_products.TabStop = false;
            this.groupBox_products.Text = "Products";
            // 
            // btn_add_new
            // 
            this.btn_add_new.Location = new System.Drawing.Point(22, 368);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(267, 23);
            this.btn_add_new.TabIndex = 4;
            this.btn_add_new.Text = "Add new";
            this.btn_add_new.UseVisualStyleBackColor = true;
            this.btn_add_new.Click += new System.EventHandler(this.btn_add_new_Click);
            // 
            // btn_add_receipt
            // 
            this.btn_add_receipt.Enabled = false;
            this.btn_add_receipt.Location = new System.Drawing.Point(22, 333);
            this.btn_add_receipt.Name = "btn_add_receipt";
            this.btn_add_receipt.Size = new System.Drawing.Size(267, 23);
            this.btn_add_receipt.TabIndex = 2;
            this.btn_add_receipt.Text = "Add to receipt";
            this.btn_add_receipt.UseVisualStyleBackColor = true;
            this.btn_add_receipt.Click += new System.EventHandler(this.btn_add_receipt_Click);
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(19, 298);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(58, 16);
            this.label_quantity.TabIndex = 6;
            this.label_quantity.Text = "Quantity:";
            // 
            // nud_quantity
            // 
            this.nud_quantity.Location = new System.Drawing.Point(116, 296);
            this.nud_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(173, 22);
            this.nud_quantity.TabIndex = 1;
            this.nud_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox_receipt
            // 
            this.groupBox_receipt.Controls.Add(this.label_money);
            this.groupBox_receipt.Controls.Add(this.label_tax);
            this.groupBox_receipt.Controls.Add(this.label_total);
            this.groupBox_receipt.Controls.Add(this.btn_delete_receipt);
            this.groupBox_receipt.Controls.Add(this.tb_withTax);
            this.groupBox_receipt.Controls.Add(this.tb_total);
            this.groupBox_receipt.Controls.Add(this.nud_tax);
            this.groupBox_receipt.Controls.Add(this.listBoxReceipt);
            this.groupBox_receipt.Location = new System.Drawing.Point(324, 12);
            this.groupBox_receipt.Name = "groupBox_receipt";
            this.groupBox_receipt.Size = new System.Drawing.Size(367, 395);
            this.groupBox_receipt.TabIndex = 3;
            this.groupBox_receipt.TabStop = false;
            this.groupBox_receipt.Text = "Receipt";
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Location = new System.Drawing.Point(19, 357);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(50, 16);
            this.label_money.TabIndex = 8;
            this.label_money.Text = "To pay";
            // 
            // label_tax
            // 
            this.label_tax.AutoSize = true;
            this.label_tax.Location = new System.Drawing.Point(19, 328);
            this.label_tax.Name = "label_tax";
            this.label_tax.Size = new System.Drawing.Size(56, 16);
            this.label_tax.TabIndex = 7;
            this.label_tax.Text = "Tax (%):";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(19, 299);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(41, 16);
            this.label_total.TabIndex = 5;
            this.label_total.Text = "Total:";
            // 
            // btn_delete_receipt
            // 
            this.btn_delete_receipt.Enabled = false;
            this.btn_delete_receipt.Location = new System.Drawing.Point(6, 252);
            this.btn_delete_receipt.Name = "btn_delete_receipt";
            this.btn_delete_receipt.Size = new System.Drawing.Size(345, 23);
            this.btn_delete_receipt.TabIndex = 4;
            this.btn_delete_receipt.Text = "Delete receipt";
            this.btn_delete_receipt.UseVisualStyleBackColor = true;
            this.btn_delete_receipt.Click += new System.EventHandler(this.btn_delete_receipt_Click);
            // 
            // tb_withTax
            // 
            this.tb_withTax.Location = new System.Drawing.Point(170, 354);
            this.tb_withTax.Name = "tb_withTax";
            this.tb_withTax.Size = new System.Drawing.Size(181, 22);
            this.tb_withTax.TabIndex = 4;
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(170, 296);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(181, 22);
            this.tb_total.TabIndex = 3;
            // 
            // nud_tax
            // 
            this.nud_tax.Location = new System.Drawing.Point(170, 326);
            this.nud_tax.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_tax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_tax.Name = "nud_tax";
            this.nud_tax.Size = new System.Drawing.Size(181, 22);
            this.nud_tax.TabIndex = 2;
            this.nud_tax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // errorProvider_addNew
            // 
            this.errorProvider_addNew.ContainerControl = this;
            // 
            // CashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 430);
            this.Controls.Add(this.groupBox_receipt);
            this.Controls.Add(this.groupBox_products);
            this.Name = "CashRegister";
            this.Text = "CashRegister";
            this.groupBox_products.ResumeLayout(false);
            this.groupBox_products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            this.groupBox_receipt.ResumeLayout(false);
            this.groupBox_receipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_addNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.ListBox listBoxReceipt;
        private System.Windows.Forms.GroupBox groupBox_products;
        private System.Windows.Forms.GroupBox groupBox_receipt;
        private System.Windows.Forms.Button btn_add_new;
        private System.Windows.Forms.Button btn_add_receipt;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Label label_tax;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button btn_delete_receipt;
        private System.Windows.Forms.TextBox tb_withTax;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.NumericUpDown nud_tax;
        private System.Windows.Forms.ErrorProvider errorProvider_addNew;
    }
}