using Client.Chat;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

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

              Edit.AddToChatWindow((String)fromServer.username, (String)fromServer.username + " wrote: " + (String)fromServer.data);

            }

            if (String.Equals((String)fromServer.function, "Send file"))
            {
              Console.WriteLine("Adding to chat window");
            
              IFormatter formatter = new BinaryFormatter();
              Stream stream = new FileStream(@"C:\Users\armin\Dropbox\UNI\3. semester\DNP1\dnpTest.txt", FileMode.Create, FileAccess.Write, FileShare.None);
              formatter.Serialize(stream, fromServer.File);
              stream.Close();
              string fileName = Path.GetFileName((String)fromServer.NameOfFile);

              Edit.AddToChatWindow((String)fromServer.username, (String)fromServer.username + " wrote: " + fileName);

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
              Edit.ChangeFriendRequest((String)fromServer.accepted);
            }

                    }

                    if (String.Equals((String)fromServer.function, "ChatLogs"))
                    {
                        Console.WriteLine("got chatlogs");
                        List<String> Chatlogs = new List<String>();
                        foreach (string log in fromServer.Log)
                        {
                            Chatlogs.Add(log);
                        }

                        Edit.AddingChatlogs(Chatlogs, (String)fromServer.Username);

                    }
                }
            }
        }
    }
            if (String.Equals((String)fromServer.function, "UserRejected"))
            {
              Edit.ChangeFriendRequest((String)fromServer.RejectUser);
            }
        }
      }
    }
  }
}
