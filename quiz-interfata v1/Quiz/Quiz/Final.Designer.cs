
namespace Quiz
{
    partial class Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Final));
            this.labelClasament = new System.Windows.Forms.Label();
            this.richTextBoxClasament = new System.Windows.Forms.RichTextBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonReturnToLobby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelClasament
            // 
            this.labelClasament.AutoSize = true;
            this.labelClasament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.labelClasament.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClasament.Location = new System.Drawing.Point(571, 37);
            this.labelClasament.Name = "labelClasament";
            this.labelClasament.Size = new System.Drawing.Size(226, 41);
            this.labelClasament.TabIndex = 0;
            this.labelClasament.Text = "Leaderboard:";
            // 
            // richTextBoxClasament
            // 
            this.richTextBoxClasament.BackColor = System.Drawing.Color.White;
            this.richTextBoxClasament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxClasament.Location = new System.Drawing.Point(421, 94);
            this.richTextBoxClasament.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBoxClasament.Name = "richTextBoxClasament";
            this.richTextBoxClasament.Size = new System.Drawing.Size(526, 475);
            this.richTextBoxClasament.TabIndex = 1;
            this.richTextBoxClasament.Text = "";
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.White;
            this.buttonQuit.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(1139, 583);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(193, 57);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonReturnToLobby
            // 
            this.buttonReturnToLobby.BackColor = System.Drawing.Color.White;
            this.buttonReturnToLobby.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnToLobby.Location = new System.Drawing.Point(1139, 673);
            this.buttonReturnToLobby.Name = "buttonReturnToLobby";
            this.buttonReturnToLobby.Size = new System.Drawing.Size(193, 57);
            this.buttonReturnToLobby.TabIndex = 3;
            this.buttonReturnToLobby.Text = "Return to lobby";
            this.buttonReturnToLobby.UseVisualStyleBackColor = false;
            this.buttonReturnToLobby.Click += new System.EventHandler(this.buttonReturnToLobby_Click);
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.buttonReturnToLobby);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.richTextBoxClasament);
            this.Controls.Add(this.labelClasament);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Final";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClasament;
        private System.Windows.Forms.RichTextBox richTextBoxClasament;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonReturnToLobby;
    }
}