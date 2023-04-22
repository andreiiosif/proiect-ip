using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private TcpClient _client;
        private Task<TcpClient> _server;
        public StreamReader _sr;
        public StreamWriter _sw;
        public string _receive;
        public string _textSend;

        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach(IPAddress ip in localIP)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    textConsole.ReadOnly = true;
                    textConsole.AppendText("Your ip " + ip.ToString() + Environment.NewLine);
                    textConsole.AppendText("Port: 5005" + Environment.NewLine);
                    textIP.Text = ip.ToString();
                }
            }
        }


        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //echivalent cu daca utilizatorul este jucator sau cel care detine camera
            _client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(textIP.Text), 5005);

            try
            {
                _client.Connect(IpEnd);
                textConsole.AppendText("Connected to the server" + Environment.NewLine);
                _sr = new StreamReader(_client.GetStream());
                _sw = new StreamWriter(_client.GetStream());
                _sw.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
          
        }

        private void buttonStartServer_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 5005);
            listener.Start();
            _server = listener.AcceptTcpClientAsync();
            _client = _server.Result;
            //listener.AcceptTcpClientAsync();
            //_sr = new StreamReader(_client.GetStream());
            //_sw = new StreamWriter(_client.GetStream());
            _sr = new StreamReader(_client.GetStream());
            _sw = new StreamWriter(_client.GetStream());
            _sw.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(textBoxChat.Text != "")
            {
                _textSend = textBoxChat.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            textBoxChat.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (_client.Connected)
            {
                try
                {
                    _receive = _sr.ReadLine();
                    this.textConsole.Invoke(new MethodInvoker(delegate ()
                    {
                        textConsole.AppendText("Client: " + _receive + Environment.NewLine);
                    }));
                    _receive = "";

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if(_client.Connected)
            {
                _sw.WriteLine(_textSend);
                this.textConsole.Invoke(new MethodInvoker(delegate ()
                {
                    textConsole.AppendText("Me: " + _textSend + Environment.NewLine);
                }));
            }
            else
            {
                MessageBox.Show("Sending Failed");
            }
            backgroundWorker2.CancelAsync();
        }
    }
}
