using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuiz
{
    public class Question
    {
        public int Operand1 {  get; set; }
        public int Operand2 { get; set; }
        public string Operator { get; set; }
        public int UserAnswer { get; set; }
        public int CorrectAnswer { get; set; }
        public bool isCorrect {  get; set; }
        public int Points {  get; set; }

        public Question(int operand1, int operand2, string operator_, int userAnswer)
        {
            Operand1 = operand1;
            Operand2 = operand2;
            Operator = operator_;
            UserAnswer = userAnswer;
            CorrectAnswer = calculateAnswer();
            Points = 0;
            if (CorrectAnswer == UserAnswer) { 
                isCorrect = true;
                if (Operand1 > 9 && Operand1 < 100)
                {
                    Points += 2;
                } else
                {
                    Points += 1;
                }
                if (Operand2 > 9 && Operand2 < 100)
                {
                    Points += 2;
                }
                else
                {
                    Points += 1;
                }
                if (Operator == "*")
                {
                    Points *= 3;
                }
            } else
            {
                isCorrect = false;
                Points = -2;
            }
            
        }

        private int calculateAnswer()
        {
            switch (Operator)
            {
                case "*":
                    return Operand1 * Operand2;
                case "+":
                    return Operand1 + Operand2; 
                case "-":
                    return Operand1 - Operand2;
                default:
                    throw new NotImplementedException();
            }

        }

        public override string ToString()
        {
            return string.Format($"{Operand1} {Operator} {Operand2} = {(isCorrect? "CORRECT" : "INCORRECT")} {Points} POINTS");
        }
    }
}
