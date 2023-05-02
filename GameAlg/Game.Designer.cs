
namespace GameAlg
{
    partial class Game
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
            this.questionBox = new System.Windows.Forms.GroupBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.answer4 = new System.Windows.Forms.RadioButton();
            this.answer3 = new System.Windows.Forms.RadioButton();
            this.answer2 = new System.Windows.Forms.RadioButton();
            this.answer1 = new System.Windows.Forms.RadioButton();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionNrLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreNumber = new System.Windows.Forms.Label();
            this.slashLabel = new System.Windows.Forms.Label();
            this.totalQuestionsLabel = new System.Windows.Forms.Label();
            this.secondsLeftLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.questionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Controls.Add(this.nextButton);
            this.questionBox.Controls.Add(this.answer4);
            this.questionBox.Controls.Add(this.answer3);
            this.questionBox.Controls.Add(this.answer2);
            this.questionBox.Controls.Add(this.answer1);
            this.questionBox.Controls.Add(this.questionLabel);
            this.questionBox.Location = new System.Drawing.Point(152, 115);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(564, 304);
            this.questionBox.TabIndex = 0;
            this.questionBox.TabStop = false;
            this.questionBox.Text = "Intrebare";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(450, 264);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButtonClick);
            // 
            // answer4
            // 
            this.answer4.AutoSize = true;
            this.answer4.Location = new System.Drawing.Point(358, 215);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(14, 13);
            this.answer4.TabIndex = 4;
            this.answer4.TabStop = true;
            this.answer4.UseVisualStyleBackColor = true;
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.Location = new System.Drawing.Point(358, 157);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(14, 13);
            this.answer3.TabIndex = 3;
            this.answer3.TabStop = true;
            this.answer3.UseVisualStyleBackColor = true;
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.Location = new System.Drawing.Point(79, 215);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(14, 13);
            this.answer2.TabIndex = 2;
            this.answer2.TabStop = true;
            this.answer2.UseVisualStyleBackColor = true;
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.Location = new System.Drawing.Point(79, 157);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(14, 13);
            this.answer1.TabIndex = 1;
            this.answer1.TabStop = true;
            this.answer1.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(76, 64);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(69, 13);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "[QUESTION]";
            // 
            // questionNrLabel
            // 
            this.questionNrLabel.AutoSize = true;
            this.questionNrLabel.Location = new System.Drawing.Point(152, 80);
            this.questionNrLabel.Name = "questionNrLabel";
            this.questionNrLabel.Size = new System.Drawing.Size(12, 13);
            this.questionNrLabel.TabIndex = 1;
            this.questionNrLabel.Text = "x";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(13, 34);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Scor: ";
            // 
            // scoreNumber
            // 
            this.scoreNumber.AutoSize = true;
            this.scoreNumber.Location = new System.Drawing.Point(45, 34);
            this.scoreNumber.Name = "scoreNumber";
            this.scoreNumber.Size = new System.Drawing.Size(13, 13);
            this.scoreNumber.TabIndex = 3;
            this.scoreNumber.Text = "0";
            // 
            // slashLabel
            // 
            this.slashLabel.AutoSize = true;
            this.slashLabel.Location = new System.Drawing.Point(161, 80);
            this.slashLabel.Name = "slashLabel";
            this.slashLabel.Size = new System.Drawing.Size(18, 13);
            this.slashLabel.TabIndex = 4;
            this.slashLabel.Text = "/  ";
            // 
            // totalQuestionsLabel
            // 
            this.totalQuestionsLabel.AutoSize = true;
            this.totalQuestionsLabel.Location = new System.Drawing.Point(170, 80);
            this.totalQuestionsLabel.Name = "totalQuestionsLabel";
            this.totalQuestionsLabel.Size = new System.Drawing.Size(12, 13);
            this.totalQuestionsLabel.TabIndex = 5;
            this.totalQuestionsLabel.Text = "y";
            // 
            // secondsLeftLabel
            // 
            this.secondsLeftLabel.AutoSize = true;
            this.secondsLeftLabel.Location = new System.Drawing.Point(677, 34);
            this.secondsLeftLabel.Name = "secondsLeftLabel";
            this.secondsLeftLabel.Size = new System.Drawing.Size(19, 13);
            this.secondsLeftLabel.TabIndex = 6;
            this.secondsLeftLabel.Text = "30";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(693, 34);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(48, 13);
            this.secondsLabel.TabIndex = 7;
            this.secondsLabel.Text = "secunde";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.secondsLeftLabel);
            this.Controls.Add(this.totalQuestionsLabel);
            this.Controls.Add(this.slashLabel);
            this.Controls.Add(this.scoreNumber);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.questionNrLabel);
            this.Controls.Add(this.questionBox);
            this.Name = "Game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.questionBox.ResumeLayout(false);
            this.questionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox questionBox;
        private System.Windows.Forms.Label questionNrLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreNumber;
        private System.Windows.Forms.Label slashLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton answer4;
        private System.Windows.Forms.RadioButton answer3;
        private System.Windows.Forms.RadioButton answer2;
        private System.Windows.Forms.RadioButton answer1;
        private System.Windows.Forms.Label totalQuestionsLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label secondsLeftLabel;
        private System.Windows.Forms.Label secondsLabel;
    }
}

