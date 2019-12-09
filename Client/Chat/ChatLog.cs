using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Chat
{
    class ChatLog
    {
        public int ChatID { get; set; }
        public String Username { get; set; }
        public String Message { get; set; }

        public String MakeLog()
        {
            return Username + " Wrote: " + Message;
        }
    }
}
