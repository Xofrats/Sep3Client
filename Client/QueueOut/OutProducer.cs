using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class OutProducer
    {
        public Queue<ITranferable> OutToServerQueue = OutQueue.Instance.OutToServerQueue;

        public OutProducer()
        {
           
        }

        public void PutInQueue(ITranferable message)
        {
            Console.WriteLine("producer putting in queue");
            OutToServerQueue.Enqueue(message);
        }
    }
}
