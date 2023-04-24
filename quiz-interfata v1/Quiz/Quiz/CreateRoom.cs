using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class CreateRoom : Form
    {
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void buttonLeaveSession_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStartQuiz_Click(object sender, EventArgs e)
        {
            QuizRoom qr = new QuizRoom();
            qr.Show();
            this.Hide();
        }
    }
}
