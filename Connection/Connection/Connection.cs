using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Connection
{
    public class Connection
    {
        private static byte[] _buffer = new byte[1024];

        private static List<Socket> _clients = null;
       // private static IPHostEntry _ipHost = 
        private static IPAddress _ipAddr = null;
        private static IPEndPoint _localEndPoint = null;
        private static Socket _socket = null;
        private static string _type = null;

        public Connection(string identifier, string ipAddress = "127.0.0.1")
        {   

            if (identifier == "server")
            {
                _type = "server";
                _clients = new List<Socket>();
                _socket = new Socket(AddressFamily.InterNetwork,
        SocketType.Stream, ProtocolType.Tcp);
                IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (IPAddress ip in localIP)
                {
                    if(ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        _ipAddr = ip;
                        break;
                    }
                }
                _localEndPoint = new IPEndPoint(_ipAddr, 5005);
                _socket.Bind(_localEndPoint);
                _socket.Listen(5);
                Console.WriteLine(_ipAddr);

            }
            else if(identifier == "client"){
                _type = "client";
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(ipAddress), 5005);
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _socket.Connect(IpEnd);
            }

        }

        public async Task<string> ReceiveDataAsync()
        {
            string receivedData = "";

            if(_type == "client")
            {
                
                
                var receiveCompleted = new ManualResetEvent(false);

                _socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, result =>
                {
                    int bytesReceived = _socket.EndReceive(result);

                    receivedData = Encoding.ASCII.GetString(_buffer, 0, bytesReceived);

                    receiveCompleted.Set();
                }, null);

                await Task.Run(() => receiveCompleted.WaitOne());
            }
            else if( _type == "server") {


                var acceptCompleted = new ManualResetEvent(false);
                _socket.BeginAccept(result =>
                {
                    Socket clientSocket = _socket.EndAccept(result);
                    _clients.Add(clientSocket);

                    var receiveCompleted = new ManualResetEvent(false);

                    clientSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, receiveResult =>
                    {
                        int bytesReceived = clientSocket.EndReceive(receiveResult);

                        receivedData = Encoding.ASCII.GetString(_buffer, 0, bytesReceived);

                        receiveCompleted.Set();

                       // clientSocket.Shutdown(SocketShutdown.Both);
                        //clientSocket.Close();

                    }, null);

                    receiveCompleted.WaitOne();
                    acceptCompleted.Set();
                }, null);
                await Task.Run(() => acceptCompleted.WaitOne());
            }

            return receivedData;

        }

        public async Task SendDataAsync(string data)
        {
            _buffer = Encoding.ASCII.GetBytes(data);
            try
            {
                await _socket.SendAsync(new ArraySegment<byte>(_buffer), SocketFlags.None);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


    }
}
