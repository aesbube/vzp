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
    public partial class MathQuiz : Form
    {
        public int numOfAnsweredQuestions = 0;
        public int minPoints = 0;
        public int maxPoints = 0;
        public int totalPoints = 0;
        public double averagePoints = 0;
        public MathQuiz()
        {
            InitializeComponent();
        }

        private void btn_answer_question_Click(object sender, EventArgs e)
        {
            QuestionForm questionForm = new QuestionForm();
            if (questionForm.ShowDialog() == DialogResult.OK)
            {
                Question question = questionForm.question;
                listBox_questions.Items.Add(questionForm.question);
                numOfAnsweredQuestions++;
                if (question.Points < minPoints)
                {
                    minPoints = question.Points;
                }
                if (question.Points > maxPoints) 
                {  
                    maxPoints = question.Points; 
                }
                totalPoints += question.Points;
                averagePoints = (double)totalPoints / (double)numOfAnsweredQuestions;
                textBox_stats.Clear();
                textBox_stats.Text = $"Total answered question: {numOfAnsweredQuestions}\r\n" +
                    $"Minimum points: {minPoints}\r\n" +
                    $"Maximum points: {maxPoints}\r\n" +
                    $"Total points: {totalPoints}\r\n" +
                    $"Average points: {averagePoints:F2}";

            } else
            {
                return;
            }
        }

 
    }
}
