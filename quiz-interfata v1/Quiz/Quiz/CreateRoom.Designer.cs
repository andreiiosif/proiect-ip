
namespace Quiz
{
    partial class CreateRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRoom));
            this.labelUsersConnected = new System.Windows.Forms.Label();
            this.richTextBoxUsersConnected = new System.Windows.Forms.RichTextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelChat = new System.Windows.Forms.Label();
            this.richTextBoxChat = new System.Windows.Forms.RichTextBox();
            this.buttonLeaveSession = new System.Windows.Forms.Button();
            this.buttonStartQuiz = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsersConnected
            // 
            this.labelUsersConnected.AutoSize = true;
            this.labelUsersConnected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.labelUsersConnected.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsersConnected.Location = new System.Drawing.Point(31, 40);
            this.labelUsersConnected.Name = "labelUsersConnected";
            this.labelUsersConnected.Size = new System.Drawing.Size(272, 38);
            this.labelUsersConnected.TabIndex = 0;
            this.labelUsersConnected.Text = "Users Connected";
            // 
            // richTextBoxUsersConnected
            // 
            this.richTextBoxUsersConnected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxUsersConnected.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxUsersConnected.Location = new System.Drawing.Point(38, 93);
            this.richTextBoxUsersConnected.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBoxUsersConnected.Name = "richTextBoxUsersConnected";
            this.richTextBoxUsersConnected.Size = new System.Drawing.Size(254, 397);
            this.richTextBoxUsersConnected.TabIndex = 2;
            this.richTextBoxUsersConnected.Text = "";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.labelCode.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Location = new System.Drawing.Point(369, 40);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(488, 38);
            this.labelCode.TabIndex = 3;
            this.labelCode.Text = "The code for your Quiz Room is:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.textBoxCode.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(376, 93);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(456, 46);
            this.textBoxCode.TabIndex = 4;
            // 
            // labelChat
            // 
            this.labelChat.AutoSize = true;
            this.labelChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.labelChat.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChat.Location = new System.Drawing.Point(559, 190);
            this.labelChat.Name = "labelChat";
            this.labelChat.Size = new System.Drawing.Size(95, 38);
            this.labelChat.TabIndex = 5;
            this.labelChat.Text = "Chat:";
            // 
            // richTextBoxChat
            // 
            this.richTextBoxChat.Location = new System.Drawing.Point(376, 241);
            this.richTextBoxChat.Name = "richTextBoxChat";
            this.richTextBoxChat.Size = new System.Drawing.Size(456, 381);
            this.richTextBoxChat.TabIndex = 6;
            this.richTextBoxChat.Text = "";
            // 
            // buttonLeaveSession
            // 
            this.buttonLeaveSession.BackColor = System.Drawing.Color.White;
            this.buttonLeaveSession.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeaveSession.Location = new System.Drawing.Point(1110, 71);
            this.buttonLeaveSession.Name = "buttonLeaveSession";
            this.buttonLeaveSession.Size = new System.Drawing.Size(219, 52);
            this.buttonLeaveSession.TabIndex = 7;
            this.buttonLeaveSession.Text = "Leave this session";
            this.buttonLeaveSession.UseVisualStyleBackColor = false;
            this.buttonLeaveSession.Click += new System.EventHandler(this.buttonLeaveSession_Click);
            // 
            // buttonStartQuiz
            // 
            this.buttonStartQuiz.BackColor = System.Drawing.Color.White;
            this.buttonStartQuiz.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartQuiz.Location = new System.Drawing.Point(1110, 149);
            this.buttonStartQuiz.Name = "buttonStartQuiz";
            this.buttonStartQuiz.Size = new System.Drawing.Size(219, 52);
            this.buttonStartQuiz.TabIndex = 8;
            this.buttonStartQuiz.Text = "Start Quiz";
            this.buttonStartQuiz.UseVisualStyleBackColor = false;
            this.buttonStartQuiz.Click += new System.EventHandler(this.buttonStartQuiz_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(1317, 9);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonExit.MinimumSize = new System.Drawing.Size(40, 40);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 40);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // CreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStartQuiz);
            this.Controls.Add(this.buttonLeaveSession);
            this.Controls.Add(this.richTextBoxChat);
            this.Controls.Add(this.labelChat);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.richTextBoxUsersConnected);
            this.Controls.Add(this.labelUsersConnected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateRoom";
            this.Text = "CreateRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsersConnected;
        private System.Windows.Forms.RichTextBox richTextBoxUsersConnected;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelChat;
        private System.Windows.Forms.RichTextBox richTextBoxChat;
        private System.Windows.Forms.Button buttonLeaveSession;
        private System.Windows.Forms.Button buttonStartQuiz;
        private System.Windows.Forms.Button buttonExit;
    }
}