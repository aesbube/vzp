namespace CashAccount
{
    partial class NewProduct
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
            this.groupBox_product_info = new System.Windows.Forms.GroupBox();
            this.label_price = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_code = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            this.nud_code = new System.Windows.Forms.NumericUpDown();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.errorProvider_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_product_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_product_info
            // 
            this.groupBox_product_info.Controls.Add(this.label_price);
            this.groupBox_product_info.Controls.Add(this.label_name);
            this.groupBox_product_info.Controls.Add(this.label_code);
            this.groupBox_product_info.Controls.Add(this.tb_name);
            this.groupBox_product_info.Controls.Add(this.nud_price);
            this.groupBox_product_info.Controls.Add(this.nud_code);
            this.groupBox_product_info.Location = new System.Drawing.Point(12, 12);
            this.groupBox_product_info.Name = "groupBox_product_info";
            this.groupBox_product_info.Size = new System.Drawing.Size(468, 186);
            this.groupBox_product_info.TabIndex = 0;
            this.groupBox_product_info.TabStop = false;
            this.groupBox_product_info.Text = "Product data";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(22, 119);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(41, 16);
            this.label_price.TabIndex = 5;
            this.label_price.Text = "Price:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(22, 71);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(47, 16);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Name:";
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.Location = new System.Drawing.Point(22, 24);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(43, 16);
            this.label_code.TabIndex = 3;
            this.label_code.Text = "Code:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(25, 90);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(407, 22);
            this.tb_name.TabIndex = 2;
            this.tb_name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_name_Validating);
            // 
            // nud_price
            // 
            this.nud_price.DecimalPlaces = 2;
            this.nud_price.Location = new System.Drawing.Point(25, 138);
            this.nud_price.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_price.Name = "nud_price";
            this.nud_price.Size = new System.Drawing.Size(171, 22);
            this.nud_price.TabIndex = 1;
            // 
            // nud_code
            // 
            this.nud_code.Location = new System.Drawing.Point(25, 43);
            this.nud_code.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_code.Name = "nud_code";
            this.nud_code.Size = new System.Drawing.Size(171, 22);
            this.nud_code.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(378, 217);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add_product
            // 
            this.btn_add_product.Location = new System.Drawing.Point(245, 217);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(102, 23);
            this.btn_add_product.TabIndex = 3;
            this.btn_add_product.Text = "Add";
            this.btn_add_product.UseVisualStyleBackColor = true;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // errorProvider_name
            // 
            this.errorProvider_name.ContainerControl = this;
            // 
            // NewProduct
            // 
            this.AcceptButton = this.btn_add_product;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(496, 253);
            this.Controls.Add(this.btn_add_product);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox_product_info);
            this.Name = "NewProduct";
            this.Text = "New Product";
            this.groupBox_product_info.ResumeLayout(false);
            this.groupBox_product_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_product_info;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.NumericUpDown nud_price;
        private System.Windows.Forms.NumericUpDown nud_code;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.ErrorProvider errorProvider_name;
    }
}