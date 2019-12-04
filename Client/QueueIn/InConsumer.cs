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
                    dynamic fromServer = InFromServerQueue.Dequeue();
                    Console.WriteLine("function is: " + fromServer.function);

                    if (String.Equals((String)fromServer.function, "chat"))
                    {
                        Console.WriteLine("Adding to chat window");

                        Edit.AddToChatWindow((String)fromServer.username,(String)fromServer.username + " wrote: " + (String)fromServer.data);
                        
                    }

                    if (String.Equals((String)fromServer.function, "alleVenner"))
                    {
                        Console.WriteLine("got all friends");
                        List<String> names = new List<string>();
                        int Count = 0;
                        foreach (var ven in fromServer.data)
                        {
                            names.Add((String)ven);
                            Count++;
                        }
                       Edit.AddToFriendWindow(names, Count);

                    }

                    if (String.Equals((String)fromServer.function, "Login"))
                    {
                        Console.WriteLine("Logging in");
                        
                        Edit.Login();

                    }

                    if (String.Equals((String)fromServer.function, "friendList"))
                    {
                        String data = "";
                        foreach (string request in fromServer.FriendRequest)
                        {
                          data += request + Environment.NewLine;
                        }
                        Edit.GetAllFriendRequest(data);

                        String first = "";
                        foreach (string oneRequest in fromServer.FriendRequest)
                        {
                          first += oneRequest.First();
                        }
                        Edit.GetOneFriendRequest(first);

                    }

                    if (String.Equals((String)fromServer.accepted, "Friend added"))
                    {
                                String data = fromServer.accepted;
                               // Edit.AcceptFriendRequest(data);

                    }
                }
            }
        }
    }
}
