
namespace Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectUser = new System.Windows.Forms.ComboBox();
            this.panelUserEntersCode = new System.Windows.Forms.Panel();
            this.panelUserCreatesRoom = new System.Windows.Forms.Panel();
            this.buttonCreateRoom = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textRoomCode = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.labelRoomCode = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelUserEntersCode.SuspendLayout();
            this.panelUserCreatesRoom.SuspendLayout();
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
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(1317, 9);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonExit.MinimumSize = new System.Drawing.Size(40, 40);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 40);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(851, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select user type:";
            // 
            // comboBoxSelectUser
            // 
            this.comboBoxSelectUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.comboBoxSelectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectUser.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSelectUser.FormattingEnabled = true;
            this.comboBoxSelectUser.ItemHeight = 24;
            this.comboBoxSelectUser.Items.AddRange(new object[] {
            "Create a room",
            "Enter room code"});
            this.comboBoxSelectUser.Location = new System.Drawing.Point(819, 387);
            this.comboBoxSelectUser.Name = "comboBoxSelectUser";
            this.comboBoxSelectUser.Size = new System.Drawing.Size(391, 32);
            this.comboBoxSelectUser.TabIndex = 6;
            this.comboBoxSelectUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectUser_SelectedIndexChanged);
            // 
            // panelUserEntersCode
            // 
            this.panelUserEntersCode.Controls.Add(this.buttonConnect);
            this.panelUserEntersCode.Controls.Add(this.textRoomCode);
            this.panelUserEntersCode.Controls.Add(this.textUsername);
            this.panelUserEntersCode.Controls.Add(this.labelRoomCode);
            this.panelUserEntersCode.Controls.Add(this.labelUsername);
            this.panelUserEntersCode.Location = new System.Drawing.Point(819, 428);
            this.panelUserEntersCode.Name = "panelUserEntersCode";
            this.panelUserEntersCode.Size = new System.Drawing.Size(391, 300);
            this.panelUserEntersCode.TabIndex = 7;
            // 
            // panelUserCreatesRoom
            // 
            this.panelUserCreatesRoom.Controls.Add(this.buttonCreateRoom);
            this.panelUserCreatesRoom.Controls.Add(this.textBox2);
            this.panelUserCreatesRoom.Controls.Add(this.label3);
            this.panelUserCreatesRoom.Location = new System.Drawing.Point(816, 425);
            this.panelUserCreatesRoom.Name = "panelUserCreatesRoom";
            this.panelUserCreatesRoom.Size = new System.Drawing.Size(391, 300);
            this.panelUserCreatesRoom.TabIndex = 8;
            // 
            // buttonCreateRoom
            // 
            this.buttonCreateRoom.BackColor = System.Drawing.Color.White;
            this.buttonCreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateRoom.ForeColor = System.Drawing.Color.Black;
            this.buttonCreateRoom.Location = new System.Drawing.Point(86, 128);
            this.buttonCreateRoom.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCreateRoom.Name = "buttonCreateRoom";
            this.buttonCreateRoom.Size = new System.Drawing.Size(230, 39);
            this.buttonCreateRoom.TabIndex = 4;
            this.buttonCreateRoom.Text = "Create a Quiz Room";
            this.buttonCreateRoom.UseVisualStyleBackColor = false;
            this.buttonCreateRoom.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(31, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(332, 29);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(132, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.White;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.Black;
            this.buttonConnect.Location = new System.Drawing.Point(140, 232);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(141, 39);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textRoomCode
            // 
            this.textRoomCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRoomCode.ForeColor = System.Drawing.Color.Black;
            this.textRoomCode.Location = new System.Drawing.Point(40, 146);
            this.textRoomCode.Name = "textRoomCode";
            this.textRoomCode.Size = new System.Drawing.Size(332, 29);
            this.textRoomCode.TabIndex = 3;
            this.textRoomCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.ForeColor = System.Drawing.Color.Black;
            this.textUsername.Location = new System.Drawing.Point(40, 61);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(332, 29);
            this.textUsername.TabIndex = 2;
            this.textUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRoomCode
            // 
            this.labelRoomCode.AutoSize = true;
            this.labelRoomCode.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomCode.ForeColor = System.Drawing.Color.Black;
            this.labelRoomCode.Location = new System.Drawing.Point(141, 113);
            this.labelRoomCode.Name = "labelRoomCode";
            this.labelRoomCode.Size = new System.Drawing.Size(140, 30);
            this.labelRoomCode.TabIndex = 1;
            this.labelRoomCode.Text = "Room code";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Black;
            this.labelUsername.Location = new System.Drawing.Point(141, 28);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(131, 30);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelUserCreatesRoom);
            this.Controls.Add(this.panelUserEntersCode);
            this.Controls.Add(this.comboBoxSelectUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelUserEntersCode.ResumeLayout(false);
            this.panelUserEntersCode.PerformLayout();
            this.panelUserCreatesRoom.ResumeLayout(false);
            this.panelUserCreatesRoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectUser;
        private System.Windows.Forms.Panel panelUserEntersCode;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textRoomCode;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label labelRoomCode;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelUserCreatesRoom;
        private System.Windows.Forms.Button buttonCreateRoom;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}

