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
                    dynamic fromServer = InFromServerQueue.Dequeue();
                    Console.WriteLine("function is: " + fromServer.function);

                    if (String.Equals((String)fromServer.function, "chat"))
                    {
                        Console.WriteLine("Adding to chat window");
                        Edit.AddToChatWindow((String)fromServer.username + "wrote: " + (String)fromServer.data);
                        
                    }

                    if (String.Equals((String)fromServer.function, "alleVenner"))
                    {
                        Console.WriteLine("got all friends");
                        String data = "";
                        foreach (var ven in fromServer.data)
                        {
                            data += (String)ven + Environment.NewLine;
                        }
                        Edit.AddToFriendWindow(data);

                    }

                    if (String.Equals((String)fromServer.function, "Login"))
                    {
                        Console.WriteLine("Logging in");
                        
                        Edit.Login();

                    }


                }
            }

            

            
        }
       
    }
}
