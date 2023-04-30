using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mor_cu_acest_proiect
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string type = Console.ReadLine();

            Connection.Connection conn = new Connection.Connection(type, "192.168.0.181");

            string data = Console.ReadLine();

            await conn.SendDataAsync(data);


            data = Console.ReadLine();

            await conn.SendDataAsync(data);

        }
    }
}
