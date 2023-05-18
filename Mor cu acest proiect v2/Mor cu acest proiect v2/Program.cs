using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mor_cu_acest_proiect_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Connection.Connection conn = new Connection.Connection("client", "192.168.0.183");

            string data = Console.ReadLine();

            conn.SendData(data);


            data = Console.ReadLine();

            conn.SendData(data);

            Console.ReadLine();
            conn.CloseConnection();
        }
    }
}
