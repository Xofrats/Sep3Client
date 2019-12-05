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
                        Edit.AddToChatWindow((String)fromServer.username + "wrote: " + (String)fromServer.data);
                        
                    }

                    //if (String.Equals((String)fromServer.function, "alleVenner"))
                    //{
                    //    Console.WriteLine("got all friends");
                    //    String data = "";
                    //    foreach (var ven in fromServer.data)
                    //    {
                    //        data += (String)ven + Environment.NewLine;
                    //    }
                    //    Edit.AddToFriendWindow(data);

                    //}

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

                        List<String> first = new List<string>();
                        foreach (string request in fromServer.FriendRequest)
                        {
                          first.Add(request);
                        }
                        Edit.GetOneFriendRequest(first[0]);

                    }

                    if (String.Equals((String)fromServer.function, "MyFriendRequest"))
                    {
                      Edit.CheckOnFriendRequest((String)fromServer.SendFriendRequest);
                    }

                    if (String.Equals((String)fromServer.function, "newFriend"))
                    {
                      Edit.AddFriendWindow((String)fromServer.accepted);
                    }

                    if (String.Equals((String)fromServer.function, "UserRejected"))
                    {
                      Edit.AddFriendWindow((String)fromServer.RejectUser);
                    }
                }
            }
        }
    }
}
