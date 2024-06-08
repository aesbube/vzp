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
    public partial class Form1 : Form
    {
        public Dictionary<string, int> authors = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_addNewPaper_Click(object sender, EventArgs e)
        {
            AddPaper addPaperForm = new AddPaper();
            if (addPaperForm.ShowDialog() == DialogResult.OK)
            {
                Paper paper = addPaperForm.paper;
                listBox_allPapers.Items.Add(paper);

                foreach (string author in paper.Authors)
                {
                    if (authors.ContainsKey(author))
                    {
                        authors[author] += 1;
                    } else
                    {
                        authors[author] = 1;
                    }
                }
                Update();
            }
            else
            {
                return;
            }
        }

        private void button_deletePaper_Click(object sender, EventArgs e)
        {
            if (listBox_allPapers.SelectedIndex != -1)
            {
                foreach (string author in (listBox_allPapers.SelectedItem as Paper).Authors)
                {
                    if (authors.ContainsKey(author)) {
                        authors[author] -= 1;
                        if (authors[author] == 0) {
                            authors.Remove(author);
                        }
                    }
                }
                Update();
                listBox_allPapers.Items.RemoveAt(listBox_allPapers.SelectedIndex);
            }
        }

        private void Update()
        {
            listBox_authorsAndPapers.Items.Clear();
            foreach (var author in authors)
            {
                listBox_authorsAndPapers.Items.Add($"{author.Key} - {author.Value}");
            }
        }
    }
}
