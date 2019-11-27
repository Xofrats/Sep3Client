using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.QueueIn
{
    class InQueue
    {
        public Queue<dynamic> InFromServerQueue { get; }

        private static InQueue instance = null;

        private InQueue()
        {
            InFromServerQueue = new Queue<dynamic>();
        }

        public static InQueue Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InQueue();
                }
                return instance;
            }
        }
    }
}
