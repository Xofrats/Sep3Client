using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Client.QueueIn
{
    class InProducer
    {
        private Client client = Client.Instance;
        private Queue<dynamic> InFromServerQueue = InQueue.Instance.InFromServerQueue;


        byte[] data = new byte[1024];
        String stringData;

       


        public void ListenToServer()
        {
            while (true)
            {
                int recv = client.Network.Read(data, 0, data.Length);
                Console.WriteLine("Got something from Server");
                stringData = Encoding.ASCII.GetString(data, 0, recv);

                dynamic test = JsonConvert.DeserializeObject(stringData);

                InFromServerQueue.Enqueue(test);
                
            }
            
        }
    }
}
