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
        private OutProducer Producer = new OutProducer();
     
        public ServerFunctions()
        {
          
        }

        public void SendMessage(Message message)
        {
            Producer.PutInQueue(message);  
        }
    }
}
