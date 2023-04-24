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
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReturnToLobby_Click(object sender, EventArgs e)
        {
            CreateRoom cr = new CreateRoom();
            cr.Show();
            this.Hide();
        }
    }
}
