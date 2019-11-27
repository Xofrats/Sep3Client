﻿using Newtonsoft.Json;
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
                    

                    if (String.Equals((String)test.function, "chat"))
                    {
                        Console.WriteLine("Adding to chat window");
                        Edit.AddToChatWindow((String)test.name);
                        
                    }

                    if (String.Equals((String)test.function, "alleVenner"))
                    {
                        Console.WriteLine("got  all friends");
                        String data = "";
                        foreach (string ven in test.alleVenner)
                        {
                            data += ven + Environment.NewLine;
                        }
                        Edit.AddToChatWindow(data);

                    }


                }
            }

            

            
        }
       
    }
}