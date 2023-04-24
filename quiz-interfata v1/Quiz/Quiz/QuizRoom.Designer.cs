
namespace Quiz
{
    partial class QuizRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizRoom));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLeaveThisQuiz = new System.Windows.Forms.Button();
            this.textBoxQuestionNo = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelChatQuizRoom = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonExit.ForeColor = System.Drawing.Color.LightCyan;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(1317, 9);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonExit.MinimumSize = new System.Drawing.Size(40, 40);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 40);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLeaveThisQuiz
            // 
            this.buttonLeaveThisQuiz.BackColor = System.Drawing.Color.White;
            this.buttonLeaveThisQuiz.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeaveThisQuiz.Location = new System.Drawing.Point(1067, 663);
            this.buttonLeaveThisQuiz.Name = "buttonLeaveThisQuiz";
            this.buttonLeaveThisQuiz.Size = new System.Drawing.Size(232, 63);
            this.buttonLeaveThisQuiz.TabIndex = 2;
            this.buttonLeaveThisQuiz.Text = "Leave this Quiz";
            this.buttonLeaveThisQuiz.UseVisualStyleBackColor = false;
            this.buttonLeaveThisQuiz.Click += new System.EventHandler(this.buttonLeaveThisQuiz_Click);
            // 
            // textBoxQuestionNo
            // 
            this.textBoxQuestionNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.textBoxQuestionNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.textBoxQuestionNo.Location = new System.Drawing.Point(346, 123);
            this.textBoxQuestionNo.Name = "textBoxQuestionNo";
            this.textBoxQuestionNo.Size = new System.Drawing.Size(84, 20);
            this.textBoxQuestionNo.TabIndex = 3;
            this.textBoxQuestionNo.Text = "Question x/x\r\n";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.labelScore.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(99, 33);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "Score:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(251, 236);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // labelChatQuizRoom
            // 
            this.labelChatQuizRoom.AutoSize = true;
            this.labelChatQuizRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.labelChatQuizRoom.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChatQuizRoom.Location = new System.Drawing.Point(12, 294);
            this.labelChatQuizRoom.Name = "labelChatQuizRoom";
            this.labelChatQuizRoom.Size = new System.Drawing.Size(85, 33);
            this.labelChatQuizRoom.TabIndex = 6;
            this.labelChatQuizRoom.Text = "Chat:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(18, 330);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(251, 426);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // QuizRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.labelChatQuizRoom);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxQuestionNo);
            this.Controls.Add(this.buttonLeaveThisQuiz);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLeaveThisQuiz;
        private System.Windows.Forms.TextBox textBoxQuestionNo;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelChatQuizRoom;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}