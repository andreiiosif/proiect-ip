using Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verification
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string type = Console.ReadLine();

            Connection.Connection conn = new Connection.Connection(type);


            string receivedData = await conn.ReceiveDataAsync();

            Console.WriteLine(receivedData);

            receivedData = await conn.ReceiveDataAsync();

            Console.WriteLine(receivedData);

        }
    }
}
