using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class QuestionForm : Form
    {
        public int op1 {  get; set; }
        public int op2 { get; set; }
        public string randOperator { get; set; }
        public int userAnswer { get; set; }
        public Question question { get; set; }
        public QuestionForm()
        {
            InitializeComponent();
        }

        private void button_answer_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                question = new Question(op1, op2, randOperator, userAnswer);
                DialogResult = DialogResult.OK;
            }
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            op1 = random.Next(1, 101);
            op2 = random.Next(1, 101);
            int operation = random.Next(3);
            string[] opers = { "+", "-", "*" };
            randOperator = opers[operation];
            label_question.Text = $"{op1} {randOperator} {op2} = ?";
        }

        private void textBox_answer_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(textBox_answer.Text, out int answer) == false)
            {
                errorProvider_userAnswer.SetError(textBox_answer, "Please enter a number");
                e.Cancel = true;
            } else
            {
                userAnswer = answer;
                errorProvider_userAnswer.SetError(textBox_answer, null);
                e.Cancel = false;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
