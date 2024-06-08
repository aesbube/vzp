namespace WindowsFormsApp1
{
    partial class AddPaper
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
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_author1 = new System.Windows.Forms.TextBox();
            this.textBox_keywords = new System.Windows.Forms.TextBox();
            this.textBox_author2 = new System.Windows.Forms.TextBox();
            this.textBox_author3 = new System.Windows.Forms.TextBox();
            this.textBox_author4 = new System.Windows.Forms.TextBox();
            this.textBox_author5 = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_keywords = new System.Windows.Forms.Label();
            this.label_author1 = new System.Windows.Forms.Label();
            this.label_author2 = new System.Windows.Forms.Label();
            this.label_author3 = new System.Windows.Forms.Label();
            this.label_author4 = new System.Windows.Forms.Label();
            this.label_author5 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.errorProvider_title = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_keywords = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_author1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_keywords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_author1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(31, 50);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(415, 22);
            this.textBox_title.TabIndex = 0;
            this.textBox_title.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_title_Validating);
            // 
            // textBox_author1
            // 
            this.textBox_author1.Location = new System.Drawing.Point(31, 181);
            this.textBox_author1.Name = "textBox_author1";
            this.textBox_author1.Size = new System.Drawing.Size(415, 22);
            this.textBox_author1.TabIndex = 1;
            this.textBox_author1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_author1_Validating);
            // 
            // textBox_keywords
            // 
            this.textBox_keywords.Location = new System.Drawing.Point(31, 112);
            this.textBox_keywords.Name = "textBox_keywords";
            this.textBox_keywords.Size = new System.Drawing.Size(415, 22);
            this.textBox_keywords.TabIndex = 2;
            this.textBox_keywords.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_keywords_Validating);
            // 
            // textBox_author2
            // 
            this.textBox_author2.Location = new System.Drawing.Point(31, 249);
            this.textBox_author2.Name = "textBox_author2";
            this.textBox_author2.Size = new System.Drawing.Size(415, 22);
            this.textBox_author2.TabIndex = 3;
            // 
            // textBox_author3
            // 
            this.textBox_author3.Location = new System.Drawing.Point(31, 314);
            this.textBox_author3.Name = "textBox_author3";
            this.textBox_author3.Size = new System.Drawing.Size(415, 22);
            this.textBox_author3.TabIndex = 4;
            // 
            // textBox_author4
            // 
            this.textBox_author4.Location = new System.Drawing.Point(31, 377);
            this.textBox_author4.Name = "textBox_author4";
            this.textBox_author4.Size = new System.Drawing.Size(415, 22);
            this.textBox_author4.TabIndex = 5;
            // 
            // textBox_author5
            // 
            this.textBox_author5.Location = new System.Drawing.Point(31, 442);
            this.textBox_author5.Name = "textBox_author5";
            this.textBox_author5.Size = new System.Drawing.Size(415, 22);
            this.textBox_author5.TabIndex = 6;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(28, 31);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(33, 16);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "Title";
            // 
            // label_keywords
            // 
            this.label_keywords.AutoSize = true;
            this.label_keywords.Location = new System.Drawing.Point(28, 93);
            this.label_keywords.Name = "label_keywords";
            this.label_keywords.Size = new System.Drawing.Size(66, 16);
            this.label_keywords.TabIndex = 8;
            this.label_keywords.Text = "Keywords";
            // 
            // label_author1
            // 
            this.label_author1.AutoSize = true;
            this.label_author1.Location = new System.Drawing.Point(28, 162);
            this.label_author1.Name = "label_author1";
            this.label_author1.Size = new System.Drawing.Size(55, 16);
            this.label_author1.TabIndex = 9;
            this.label_author1.Text = "Author 1";
            // 
            // label_author2
            // 
            this.label_author2.AutoSize = true;
            this.label_author2.Location = new System.Drawing.Point(28, 230);
            this.label_author2.Name = "label_author2";
            this.label_author2.Size = new System.Drawing.Size(55, 16);
            this.label_author2.TabIndex = 10;
            this.label_author2.Text = "Author 2";
            // 
            // label_author3
            // 
            this.label_author3.AutoSize = true;
            this.label_author3.Location = new System.Drawing.Point(28, 295);
            this.label_author3.Name = "label_author3";
            this.label_author3.Size = new System.Drawing.Size(55, 16);
            this.label_author3.TabIndex = 11;
            this.label_author3.Text = "Author 3";
            // 
            // label_author4
            // 
            this.label_author4.AutoSize = true;
            this.label_author4.Location = new System.Drawing.Point(28, 358);
            this.label_author4.Name = "label_author4";
            this.label_author4.Size = new System.Drawing.Size(55, 16);
            this.label_author4.TabIndex = 12;
            this.label_author4.Text = "Author 4";
            // 
            // label_author5
            // 
            this.label_author5.AutoSize = true;
            this.label_author5.Location = new System.Drawing.Point(28, 423);
            this.label_author5.Name = "label_author5";
            this.label_author5.Size = new System.Drawing.Size(55, 16);
            this.label_author5.TabIndex = 13;
            this.label_author5.Text = "Author 5";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(31, 495);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(179, 43);
            this.button_OK.TabIndex = 14;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.CausesValidation = false;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(267, 495);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(179, 43);
            this.button_Cancel.TabIndex = 15;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider_title
            // 
            this.errorProvider_title.ContainerControl = this;
            // 
            // errorProvider_keywords
            // 
            this.errorProvider_keywords.ContainerControl = this;
            // 
            // errorProvider_author1
            // 
            this.errorProvider_author1.ContainerControl = this;
            // 
            // AddPaper
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(487, 562);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_author5);
            this.Controls.Add(this.label_author4);
            this.Controls.Add(this.label_author3);
            this.Controls.Add(this.label_author2);
            this.Controls.Add(this.label_author1);
            this.Controls.Add(this.label_keywords);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox_author5);
            this.Controls.Add(this.textBox_author4);
            this.Controls.Add(this.textBox_author3);
            this.Controls.Add(this.textBox_author2);
            this.Controls.Add(this.textBox_keywords);
            this.Controls.Add(this.textBox_author1);
            this.Controls.Add(this.textBox_title);
            this.Name = "AddPaper";
            this.Text = "AddPaper";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_keywords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_author1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_author1;
        private System.Windows.Forms.TextBox textBox_keywords;
        private System.Windows.Forms.TextBox textBox_author2;
        private System.Windows.Forms.TextBox textBox_author3;
        private System.Windows.Forms.TextBox textBox_author4;
        private System.Windows.Forms.TextBox textBox_author5;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_keywords;
        private System.Windows.Forms.Label label_author1;
        private System.Windows.Forms.Label label_author2;
        private System.Windows.Forms.Label label_author3;
        private System.Windows.Forms.Label label_author4;
        private System.Windows.Forms.Label label_author5;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ErrorProvider errorProvider_title;
        private System.Windows.Forms.ErrorProvider errorProvider_keywords;
        private System.Windows.Forms.ErrorProvider errorProvider_author1;
    }
}