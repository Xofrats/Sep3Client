using Client.Chat;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    List<String> requestList = new List<string>();

    public void FromServer()
    {
      while (true)
      {
        if (InFromServerQueue.Count > 0)
        {
          Console.WriteLine("inConsumer working");
          dynamic fromServer = InFromServerQueue.Dequeue();
          Console.WriteLine("function is: " + fromServer.function);

          if ((String)fromServer.function == "chat")
          {
            Console.WriteLine("Adding to chat window");

            Edit.AddToChatWindow((String)fromServer.username, (String)fromServer.username + " wrote: " + (String)fromServer.data);

          }

          if ((String)fromServer.function == "chat group")
          {
            Console.WriteLine("Adding to chat window");

            Edit.AddToGroupWindow((String)fromServer.username, (String)fromServer.username + " wrote: " + (String)fromServer.data);

          }

          if ((String)fromServer.function == "Send file")
          {
            Console.WriteLine("Adding to chat window");

            string str = (string)fromServer.File;
            string fileName = Path.GetFileName((String)fromServer.NameOfFile);
            string path = $"C:\\Users\\{Environment.UserName}\\Downloads\\{fileName}";
            File.WriteAllBytes(path, Encoding.ASCII.GetBytes(str));

            Edit.AddToChatWindow((String)fromServer.username, (String)fromServer.username + " wrote: " + fileName);

          }

          if ((String)fromServer.function == "allFriends")
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

          if ((String)fromServer.function == "allGroups")
          {
            Console.WriteLine("got all groups");
            List<String> groups = new List<string>();
            int Count = 0;
            foreach (var grp in fromServer.data)
            {
              groups.Add((String)grp);
              Count++;
            }
            Console.WriteLine("Count er " + Count);
            Edit.AddToGroupWindow(groups, Count);

          }

          if ((String)fromServer.function == "Login")
          {
            Edit.Login();
          }

          if ((String)fromServer.function == "friendList")
          {
            String data = "";
            List<String> first = new List<string>();
            foreach (string request in fromServer.FriendRequest)
            {
              data += request + Environment.NewLine;
            }
            Edit.GetAllFriendRequest(data);

            //bool isEmpty = !first.Any();
            //if (isEmpty)
            //{
            //  Edit.GetOneFriendRequest("You have no request");
            //}
            //else
            //{
            foreach (string request in fromServer.FriendRequest)
            {
              first.Add(request);
            }
            Edit.GetOneFriendRequest(first.First());
            //}

          }

          if ((String)fromServer.function == "MyFriendRequest")
          {
            Edit.CheckOnFriendRequest((String)fromServer.SendFriendRequest);
          }

          if ((String)fromServer.function == "UserDeleted")
          {
            Edit.CheckOnFriendRequest((String)fromServer.DeleteUser);
          }

          if ((String)fromServer.function == "newFriend")
          {
            Edit.ChangeFriendRequest((String)fromServer.accepted);
          }

          if ((String)fromServer.function == "UserRejected")
          {
            Edit.ChangeFriendRequest((String)fromServer.RejectUser);
          }

          if ((String)fromServer.function == "ChatLogs")
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
}
