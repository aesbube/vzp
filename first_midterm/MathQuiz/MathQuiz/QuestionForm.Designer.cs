namespace MathQuiz
{
    partial class QuestionForm
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
            this.label_question = new System.Windows.Forms.Label();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.label_answer = new System.Windows.Forms.Label();
            this.button_answer = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.errorProvider_userAnswer = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_userAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_question.Location = new System.Drawing.Point(48, 54);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(104, 46);
            this.label_question.TabIndex = 0;
            this.label_question.Text = "label";
            // 
            // textBox_answer
            // 
            this.textBox_answer.Location = new System.Drawing.Point(56, 143);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(349, 22);
            this.textBox_answer.TabIndex = 1;
            this.textBox_answer.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_answer_Validating);
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Location = new System.Drawing.Point(53, 124);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(51, 16);
            this.label_answer.TabIndex = 2;
            this.label_answer.Text = "Answer";
            // 
            // button_answer
            // 
            this.button_answer.Location = new System.Drawing.Point(56, 185);
            this.button_answer.Name = "button_answer";
            this.button_answer.Size = new System.Drawing.Size(122, 36);
            this.button_answer.TabIndex = 3;
            this.button_answer.Text = "Answer";
            this.button_answer.UseVisualStyleBackColor = true;
            this.button_answer.Click += new System.EventHandler(this.button_answer_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.CausesValidation = false;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(283, 185);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(122, 36);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // errorProvider_userAnswer
            // 
            this.errorProvider_userAnswer.ContainerControl = this;
            // 
            // QuestionForm
            // 
            this.AcceptButton = this.button_answer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(466, 263);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_answer);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.label_question);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_userAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.TextBox textBox_answer;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Button button_answer;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ErrorProvider errorProvider_userAnswer;
    }
}