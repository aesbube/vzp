namespace MathQuiz
{
    partial class MathQuiz
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
            this.listBox_questions = new System.Windows.Forms.ListBox();
            this.label_questions = new System.Windows.Forms.Label();
            this.btn_answer_question = new System.Windows.Forms.Button();
            this.textBox_stats = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox_questions
            // 
            this.listBox_questions.FormattingEnabled = true;
            this.listBox_questions.ItemHeight = 16;
            this.listBox_questions.Location = new System.Drawing.Point(32, 34);
            this.listBox_questions.Name = "listBox_questions";
            this.listBox_questions.Size = new System.Drawing.Size(304, 388);
            this.listBox_questions.TabIndex = 0;
            // 
            // label_questions
            // 
            this.label_questions.AutoSize = true;
            this.label_questions.Location = new System.Drawing.Point(29, 15);
            this.label_questions.Name = "label_questions";
            this.label_questions.Size = new System.Drawing.Size(67, 16);
            this.label_questions.TabIndex = 1;
            this.label_questions.Text = "Questions";
            // 
            // btn_answer_question
            // 
            this.btn_answer_question.Location = new System.Drawing.Point(367, 34);
            this.btn_answer_question.Name = "btn_answer_question";
            this.btn_answer_question.Size = new System.Drawing.Size(262, 51);
            this.btn_answer_question.TabIndex = 2;
            this.btn_answer_question.Text = "Answer question";
            this.btn_answer_question.UseVisualStyleBackColor = true;
            this.btn_answer_question.Click += new System.EventHandler(this.btn_answer_question_Click);
            // 
            // textBox_stats
            // 
            this.textBox_stats.Enabled = false;
            this.textBox_stats.Location = new System.Drawing.Point(367, 128);
            this.textBox_stats.Multiline = true;
            this.textBox_stats.Name = "textBox_stats";
            this.textBox_stats.ReadOnly = true;
            this.textBox_stats.Size = new System.Drawing.Size(262, 132);
            this.textBox_stats.TabIndex = 3;
            this.textBox_stats.Text = "Total answered question: \r\nMinimum points:\r\nMaximum points:\r\nTotal points:\r\nAvera" +
    "ge points\r\n:";
            this.textBox_stats.WordWrap = false;
            // 
            // MathQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 513);
            this.Controls.Add(this.textBox_stats);
            this.Controls.Add(this.btn_answer_question);
            this.Controls.Add(this.label_questions);
            this.Controls.Add(this.listBox_questions);
            this.Name = "MathQuiz";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_questions;
        private System.Windows.Forms.Label label_questions;
        private System.Windows.Forms.Button btn_answer_question;
        private System.Windows.Forms.TextBox textBox_stats;
    }
}

