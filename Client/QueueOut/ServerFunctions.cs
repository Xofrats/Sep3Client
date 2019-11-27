using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class ServerFunctions
    {
        //Dette objekt fungere som producer for køen
        //finder køen
        public Queue<ITranferable> OutToServerQueue = OutQueue.Instance.OutToServerQueue;

        public ServerFunctions()
        {
          
        }

        public void AddToQueue(ITranferable message)
        {
            OutToServerQueue.Enqueue(message);
        }
    }
}
