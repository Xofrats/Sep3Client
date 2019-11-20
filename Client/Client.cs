using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Text;
    using System.Net.Sockets;
    using System.Threading.Tasks;

  
        public class Client
        {
            public TcpClient TCPClient;
            public NetworkStream network;

            public TcpClient connect()
            {
                try
                {
                    TcpClient client = new TcpClient("127.0.0.1", 7331);
                    return client;
                }
                catch (SocketException e)
                {
                    Console.WriteLine("Unable to connect to server");
                    throw e;
                }


            }

            public void WriteToServer(string besked)
            {
                byte[] input = new byte[1024];
                network.Write(Encoding.ASCII.GetBytes(besked), 0, input.Length);
                network.Flush();
            }

          
        }
    }


