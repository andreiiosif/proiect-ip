using Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Verification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            Connection.Connection conn = new Connection.Connection(type);

            conn.StartReceiving();
            Console.ReadLine();

            string receivedData = conn.GetMessage();
            Console.WriteLine(receivedData);

            receivedData = conn.GetMessage();
            Console.WriteLine(receivedData);

            // Call the callback method to start receiving messages
            Console.ReadLine();
            conn.CloseConnection();

            // Keep the server application running


        }
    }
}
