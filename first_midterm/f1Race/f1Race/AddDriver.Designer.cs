namespace f1Race
{
    partial class AddDriver
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
            this.tb_driver_name = new System.Windows.Forms.TextBox();
            this.nud_driver_age = new System.Windows.Forms.NumericUpDown();
            this.cb_first_driver = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label_driver_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.errorProvider_driver_name = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_driver_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_driver_name)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_driver_name
            // 
            this.tb_driver_name.Location = new System.Drawing.Point(19, 38);
            this.tb_driver_name.Name = "tb_driver_name";
            this.tb_driver_name.Size = new System.Drawing.Size(314, 22);
            this.tb_driver_name.TabIndex = 0;
            this.tb_driver_name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_driver_name_Validating);
            // 
            // nud_driver_age
            // 
            this.nud_driver_age.Location = new System.Drawing.Point(22, 89);
            this.nud_driver_age.Name = "nud_driver_age";
            this.nud_driver_age.Size = new System.Drawing.Size(145, 22);
            this.nud_driver_age.TabIndex = 1;
            // 
            // cb_first_driver
            // 
            this.cb_first_driver.AutoSize = true;
            this.cb_first_driver.Location = new System.Drawing.Point(194, 91);
            this.cb_first_driver.Name = "cb_first_driver";
            this.cb_first_driver.Size = new System.Drawing.Size(91, 20);
            this.cb_first_driver.TabIndex = 2;
            this.cb_first_driver.Text = "First driver";
            this.cb_first_driver.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.CausesValidation = false;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(22, 127);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(139, 39);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(194, 127);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(139, 39);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label_driver_name
            // 
            this.label_driver_name.AutoSize = true;
            this.label_driver_name.Location = new System.Drawing.Point(19, 19);
            this.label_driver_name.Name = "label_driver_name";
            this.label_driver_name.Size = new System.Drawing.Size(44, 16);
            this.label_driver_name.TabIndex = 5;
            this.label_driver_name.Text = "Name";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(19, 70);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(32, 16);
            this.label_age.TabIndex = 6;
            this.label_age.Text = "Age";
            // 
            // errorProvider_driver_name
            // 
            this.errorProvider_driver_name.ContainerControl = this;
            // 
            // AddDriver
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(356, 182);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_driver_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cb_first_driver);
            this.Controls.Add(this.nud_driver_age);
            this.Controls.Add(this.tb_driver_name);
            this.Name = "AddDriver";
            this.Text = "AddDriver";
            ((System.ComponentModel.ISupportInitialize)(this.nud_driver_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_driver_name)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_driver_name;
        private System.Windows.Forms.NumericUpDown nud_driver_age;
        private System.Windows.Forms.CheckBox cb_first_driver;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label_driver_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.ErrorProvider errorProvider_driver_name;
    }
}