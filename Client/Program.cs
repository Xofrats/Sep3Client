using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace myClient
{
    class myClientMain
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            string stringData2, stringData;
        
            TcpClient client;

            try
            {
                client = new TcpClient("127.0.0.1", 7331);
            }
            catch (SocketException)
            {
                Console.WriteLine("Unable to connect to server");
                return;
            }

            NetworkStream ns = client.GetStream();

            Console.WriteLine("Connected to server");
            int recv1 = ns.Read(data, 0, data.Length);
            stringData = Encoding.ASCII.GetString(data, 0, recv1);
            Console.WriteLine(stringData);
            string s = Console.ReadLine();

            ns.Write(Encoding.ASCII.GetBytes(s), 0, s.Length);
            int recv2 = ns.Read(data, 0, data.Length);
            stringData2 = Encoding.ASCII.GetString(data, 0, recv2);
            Console.WriteLine(stringData2);

            Console.ReadKey();

            ns.Close();
            client.Close();

        }
    }
}