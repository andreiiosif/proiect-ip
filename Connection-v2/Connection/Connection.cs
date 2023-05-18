using System;
using System.Collections.Concurrent;
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
        private byte[] _buffer = new byte[1024];

        private static List<Socket> _clients = null;
       // private static IPHostEntry _ipHost = 
        private  IPAddress _ipAddr = null;
        private  IPEndPoint _localEndPoint = null;
        private  Socket _socket = null;
        private  string _type = null;
        private ConcurrentQueue<string> _queue = null;
        private object _lock = new object();

        public Connection(string identifier, string ipAddress = "127.0.0.1")
        {   
            _queue = new ConcurrentQueue<string>();
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

        public void CloseConnection()
        {
            if(_type == "client")
            {
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
            }
            else if(_type == "server")
            {
                foreach(Socket client in _clients)
                {
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }
            }
        }


        public void StartReceiving()
        {
            Thread receiving = new Thread(() =>
            {
                while (true)
                {
                    if (_type == "client")
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead = _socket.Receive(buffer);
                        string message = null;
                        if (bytesRead > 0)
                        {
                            message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                            if (message != "ACK")
                            {
                                _queue.Enqueue(message);
                                byte[] ack = Encoding.ASCII.GetBytes("ACK");
                                _socket.Send(ack);
                            }
                        }
                    }
                    else if (_type == "server")
                    {

                        Socket clientSocket = _socket.Accept();
                        lock(_lock) { 
                            _clients.Add(clientSocket);
                        }
                        Thread processClient = new Thread(() => { 
                            while(true)
                            {
                                try
                                {
                                    byte[] buffer = new byte[1024];
                                    int bytesRead = clientSocket.Receive(buffer);
                                    string message = null;
                                    if (bytesRead > 0)
                                    {
                                        message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                                        if (message != "ACK")
                                        {
                                            _queue.Enqueue(message);
                                            byte[] ack = Encoding.ASCII.GetBytes("ACK");
                                            clientSocket.Send(ack);
                                        }
                                    }
                                }
                                catch(SocketException e)
                                {
                                    Console.WriteLine("Client connection abruptly closed: " + e.ToString());
                                    break;
                                }
                            }
                        });
                        processClient.Start();

                    }
                }
            });
            receiving.Start();

        }

        public bool SendData(string message)
        {
            int maxRetries = 3;
            int retryCount = 0;
            bool isAcknowledged = false;
            ManualResetEvent receiveCompleted = new ManualResetEvent(false);

            // Create a new thread for receiving the acknowledgment
            Thread receiveThread = new Thread(() =>
            {
                byte[] buffer = new byte[1024];
                int bytesRead = _socket.Receive(buffer);
                string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                if (receivedData == "ACK")
                {
                    isAcknowledged = true;
                }

                receiveCompleted.Set();
            });

            while (retryCount < maxRetries && !isAcknowledged)
            {
                // Send the message
                _socket.Send(Encoding.ASCII.GetBytes(message));

                // Start the receive thread
                receiveCompleted.Reset();
                receiveThread.Start();

                // Wait for acknowledgment or timeout
                bool completed = receiveCompleted.WaitOne(TimeSpan.FromSeconds(5));

                if (completed && isAcknowledged)
                {
                    // Message successfully acknowledged
                    return true;
                }
                else
                {
                    // Increment the retry count and try again
                    retryCount++;
                }
            }

            // Clean up and return false if message not acknowledged after maximum retries
            receiveThread.Join(); // Wait for the receive thread to complete before returning
            return false;
        }


        public bool SendData(string message, Socket clientSocket)
        {
            int maxRetries = 3;
            int retryCount = 0;
            bool isAcknowledged = false;
            ManualResetEvent receiveCompleted = new ManualResetEvent(false);

            // Create a new thread for receiving the acknowledgment
            Thread receiveThread = new Thread(() =>
            {
                byte[] buffer = new byte[1024];
                int bytesRead = clientSocket.Receive(buffer);
                string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                if (receivedData == "ACK")
                {
                    isAcknowledged = true;
                }

                receiveCompleted.Set();
            });

            while (retryCount < maxRetries && !isAcknowledged)
            {
                // Send the message
                clientSocket.Send(Encoding.ASCII.GetBytes(message));

                // Start the receive thread
                receiveCompleted.Reset();
                receiveThread.Start();

                // Wait for acknowledgment or timeout
                bool completed = receiveCompleted.WaitOne(TimeSpan.FromSeconds(5));

                if (completed && isAcknowledged)
                {
                    // Message successfully acknowledged
                    return true;
                }
                else
                {
                    // Increment the retry count and try again
                    retryCount++;
                }
            }

            // Clean up and return false if message not acknowledged after maximum retries
            receiveThread.Join(); // Wait for the receive thread to complete before returning
            return false;
        }


        public bool SendDataAll(string message)
        {
            if (_type == "server")
            {
                foreach (Socket clientSocket in _clients)
                {
                    int maxRetries = 3;
                    int retryCount = 0;
                    bool isAcknowledged = false;
                    ManualResetEvent receiveCompleted = new ManualResetEvent(false);

                    // Create a new thread for receiving the acknowledgment
                    Thread receiveThread = new Thread(() =>
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead = clientSocket.Receive(buffer);
                        string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                        if (receivedData == "ACK")
                        {
                            isAcknowledged = true;
                        }

                        receiveCompleted.Set();
                    });

                    while (retryCount < maxRetries && !isAcknowledged)
                    {
                        // Send the message
                        clientSocket.Send(Encoding.ASCII.GetBytes(message));

                        // Start the receive thread
                        receiveCompleted.Reset();
                        receiveThread.Start();

                        // Wait for acknowledgment or timeout
                        bool completed = receiveCompleted.WaitOne(TimeSpan.FromSeconds(5));

                        if (completed && isAcknowledged)
                        {
                            // Message successfully acknowledged
                            return true;
                        }
                        else
                        {
                            // Increment the retry count and try again
                            retryCount++;
                        }
                    }

                    // Clean up and return false if message not acknowledged after maximum retries
                    receiveThread.Join(); // Wait for the receive thread to complete before returning
                    return false;
                }
            }
            throw new Exception("Cannot call this methon on a client type");
        }

        public string GetMessage()
        {
            if (_queue.TryDequeue(out string message))
            {
                return message;
            }

            return null;
        }

    }
}
