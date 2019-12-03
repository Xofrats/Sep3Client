using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Client.QueueIn
{
    class InConsumer
    {
        private Queue<dynamic> InFromServerQueue = InQueue.Instance.InFromServerQueue;
        EditUI Edit = new EditUI();

        public void FromServer()
        {
            while (true)
            {
                if (InFromServerQueue.Count > 0)
                {
                    Console.WriteLine("inConsumer working");
                    dynamic test = InFromServerQueue.Dequeue();
                    Console.WriteLine("function is: " + test.function);

                    if (String.Equals((String)test.function, "chat"))
                    {
                        Console.WriteLine("Adding to chat window");
                        Edit.AddToChatWindow((String)test.name);
                        
                    }

                    if (String.Equals((String)test.function, "alleVenner"))
                    {
                        Console.WriteLine("got all friends");
                        String data = "";
                        foreach (var ven in test.data)
                        {
                            data += (String)ven + Environment.NewLine;
                        }
                        Edit.AddToFriendWindow(data);

                    }

                    if (String.Equals((String)test.function, "Login"))
                    {
                        Console.WriteLine("Logging in");
                        
                        Edit.Login();

                    }


                }
            }

            

            
        }
       
    }
}
