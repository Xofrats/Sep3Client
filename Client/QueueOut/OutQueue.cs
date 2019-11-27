using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class OutQueue
    {
        //Singleton queue der tager klasser der implemeter ITranferable
        public Queue<ITranferable> OutToServerQueue { get; }

        private static OutQueue instance = null;

        private OutQueue()
        {
            OutToServerQueue = new Queue<ITranferable>();
        }

        public static OutQueue Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OutQueue();
                }
                return instance;
            }
        }
    }
}
