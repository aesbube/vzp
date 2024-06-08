namespace WindowsFormsApp1
{
    partial class Form1
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
            this.listBox_allPapers = new System.Windows.Forms.ListBox();
            this.listBox_authorsAndPapers = new System.Windows.Forms.ListBox();
            this.label_authorsAndPapers = new System.Windows.Forms.Label();
            this.label_allPapers = new System.Windows.Forms.Label();
            this.button_addNewPaper = new System.Windows.Forms.Button();
            this.button_deletePaper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_allPapers
            // 
            this.listBox_allPapers.FormattingEnabled = true;
            this.listBox_allPapers.ItemHeight = 16;
            this.listBox_allPapers.Location = new System.Drawing.Point(42, 33);
            this.listBox_allPapers.Name = "listBox_allPapers";
            this.listBox_allPapers.Size = new System.Drawing.Size(301, 340);
            this.listBox_allPapers.TabIndex = 0;
            // 
            // listBox_authorsAndPapers
            // 
            this.listBox_authorsAndPapers.FormattingEnabled = true;
            this.listBox_authorsAndPapers.ItemHeight = 16;
            this.listBox_authorsAndPapers.Location = new System.Drawing.Point(464, 33);
            this.listBox_authorsAndPapers.Name = "listBox_authorsAndPapers";
            this.listBox_authorsAndPapers.Size = new System.Drawing.Size(301, 340);
            this.listBox_authorsAndPapers.TabIndex = 1;
            // 
            // label_authorsAndPapers
            // 
            this.label_authorsAndPapers.AutoSize = true;
            this.label_authorsAndPapers.Location = new System.Drawing.Point(461, 9);
            this.label_authorsAndPapers.Name = "label_authorsAndPapers";
            this.label_authorsAndPapers.Size = new System.Drawing.Size(124, 16);
            this.label_authorsAndPapers.TabIndex = 2;
            this.label_authorsAndPapers.Text = "Authors and papers";
            // 
            // label_allPapers
            // 
            this.label_allPapers.AutoSize = true;
            this.label_allPapers.Location = new System.Drawing.Point(39, 9);
            this.label_allPapers.Name = "label_allPapers";
            this.label_allPapers.Size = new System.Drawing.Size(68, 16);
            this.label_allPapers.TabIndex = 3;
            this.label_allPapers.Text = "All papers";
            // 
            // button_addNewPaper
            // 
            this.button_addNewPaper.Location = new System.Drawing.Point(42, 391);
            this.button_addNewPaper.Name = "button_addNewPaper";
            this.button_addNewPaper.Size = new System.Drawing.Size(300, 39);
            this.button_addNewPaper.TabIndex = 4;
            this.button_addNewPaper.Text = "Add new paper";
            this.button_addNewPaper.UseVisualStyleBackColor = true;
            this.button_addNewPaper.Click += new System.EventHandler(this.button_addNewPaper_Click);
            // 
            // button_deletePaper
            // 
            this.button_deletePaper.Location = new System.Drawing.Point(42, 449);
            this.button_deletePaper.Name = "button_deletePaper";
            this.button_deletePaper.Size = new System.Drawing.Size(301, 39);
            this.button_deletePaper.TabIndex = 5;
            this.button_deletePaper.Text = "Delete paper";
            this.button_deletePaper.UseVisualStyleBackColor = true;
            this.button_deletePaper.Click += new System.EventHandler(this.button_deletePaper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.button_deletePaper);
            this.Controls.Add(this.button_addNewPaper);
            this.Controls.Add(this.label_allPapers);
            this.Controls.Add(this.label_authorsAndPapers);
            this.Controls.Add(this.listBox_authorsAndPapers);
            this.Controls.Add(this.listBox_allPapers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_allPapers;
        private System.Windows.Forms.ListBox listBox_authorsAndPapers;
        private System.Windows.Forms.Label label_authorsAndPapers;
        private System.Windows.Forms.Label label_allPapers;
        private System.Windows.Forms.Button button_addNewPaper;
        private System.Windows.Forms.Button button_deletePaper;
    }
}

