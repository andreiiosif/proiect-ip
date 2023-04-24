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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelUserCreatesRoom.Visible = false;
            panelUserEntersCode.Visible=false;
        }

        private void comboBoxSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSelectUser.SelectedIndex==0)
            {
                panelUserCreatesRoom.Visible = true;
                panelUserEntersCode.Visible = false;
            }
            else if(comboBoxSelectUser.SelectedIndex == 1)
            {
                panelUserCreatesRoom.Visible = false;
                panelUserEntersCode.Visible = true;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            QuizRoom qr = new QuizRoom();
            qr.Show();
            this.Hide();
        }
        //am redenumit butonul asta, dar nu mai stiu cum faceam ca sa l sterg si sa l adaug
        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateRoom cr = new CreateRoom();
            cr.Show();
            this.Hide();
        }
    }
}
