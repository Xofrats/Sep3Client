using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Client
{
    class OutConsumer
    {
        public Queue<ITranferable> OutToServerQueue { get; set; }
        private Client client = Client.Instance;
        public String Username { get; set; }

        private byte[] data = new byte[1024];

        public OutConsumer()
        {
            this.OutToServerQueue = OutQueue.Instance.OutToServerQueue;
        }

        public void TakeFromQueue()
        {
            while (true) {
                if (OutToServerQueue.Count != 0)
                {
                    Console.WriteLine("Sending message");
                    ITranferable FromQueue = OutToServerQueue.Dequeue();
                 
                        Message message = (Message)FromQueue;

                        //Laver objektet om til en string
                        String json = JsonConvert.SerializeObject(message);

                        //Laver json string om til bytes og sender dem
                        client.Network.Write(Encoding.UTF8.GetBytes(json), 0, json.Length);

                        //13 er et linje skrift og aflutter linjen
                        client.Network.WriteByte(13);

                        //tømmer streamen
                        client.Network.Flush();
                    
                } else
                {
                    Console.WriteLine("Sleeping");
                    Thread.Sleep(2000);
                }
            }

           
        }
    }
}
