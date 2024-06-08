using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddPaper : Form
    {
        public Paper paper { get; set; }
        public AddPaper()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                string title = textBox_title.Text;
                List<string> keywords = textBox_keywords.Text.Split(',').ToList();
                List<string> authors = new List<string>();
                authors.Add(textBox_author1.Text);
                if (textBox_author2.Text != "")
                {
                    authors.Add(textBox_author2.Text);
                }
                if (textBox_author2.Text != "")
                {
                    authors.Add(textBox_author3.Text);
                }
                if (textBox_author2.Text != "")
                {
                    authors.Add(textBox_author4.Text);
                }
                if (textBox_author2.Text != "")
                {
                    authors.Add(textBox_author5.Text);
                }
                paper = new Paper(title, keywords, authors);
            }
        }

        private void textBox_title_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_title.Text == "")
            {
                errorProvider_title.SetError(textBox_title, "Must enter title!");
                e.Cancel = true;
            }
            else
            {
                errorProvider_title.SetError(textBox_title, null);
                e.Cancel = false;
            }
        }

        private void textBox_keywords_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_keywords.Text == "")
            {
                errorProvider_keywords.SetError(textBox_keywords, "Must enter keywords!");
                e.Cancel = true;
            }
            else
            {
                errorProvider_keywords.SetError(textBox_keywords, null);
                e.Cancel = false;
            }
        }

        private void textBox_author1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_author1.Text == "")
            {
                errorProvider_author1.SetError(textBox_author1, "Must enter at least one author!");
                e.Cancel = true;
            }
            else
            {
                errorProvider_author1.SetError(textBox_author1, null);
                e.Cancel = false;
            }
        }
    }
}
