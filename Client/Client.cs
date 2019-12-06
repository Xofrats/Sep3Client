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
        public TcpClient TCPClient { get; set; }
        public NetworkStream Network { get; set; }


        private static Client instance = null;



        public Client()
        {

            try
            {
                TCPClient = new TcpClient("127.0.0.1", 7331);
                Network = TCPClient.GetStream();
            }
            catch (SocketException e)
            {
                Console.WriteLine("Unable to connect to server");
                throw e;
            }
        }

        public static Client Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Client();
                }
                return instance;
            }
        }

    }

}


