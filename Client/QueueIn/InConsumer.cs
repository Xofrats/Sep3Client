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

                    switch ((String)fromServer.function)
                    {
                        case "chat":
                            Console.WriteLine("Adding to chat window");
                            Edit.AddToChatWindow((String)fromServer.username, (String)fromServer.username + " wrote: " + (String)fromServer.data);
                            break;

                        case "chat group":
                            Console.WriteLine("Adding to Groupchat window");
                            Edit.AddToGroupWindow((String)fromServer.groupnumber, (String)fromServer.username + " wrote: " + (String)fromServer.data);
                            break;

                        case "Send file":
                            Console.WriteLine("Adding to chat window");

                            IFormatter formatter = new BinaryFormatter();
                            Stream stream = new FileStream(@"C:\Users\armin\Dropbox\UNI\3. semester\DNP1\dnpTest.txt", FileMode.Create, FileAccess.Write, FileShare.None);
                            formatter.Serialize(stream, fromServer.File);
                            stream.Close();
                            string fileName = Path.GetFileName((String)fromServer.NameOfFile);

                            Edit.AddToChatWindow((String)fromServer.username, (String)fromServer.username + " wrote: " + fileName);

                            break;

                        case "allFriends":
                            Console.WriteLine("got all friends");
                            List<String> names = new List<string>();
                            foreach (var ven in fromServer.data)
                            {
                                names.Add((String)ven);
                                Console.WriteLine((String)ven);
                            }
                            Edit.AddToFriendWindow(names);
                            break;

                        case "allGroups":
                            Console.WriteLine("got all groups");
                            List<String> groups = new List<string>();
                            
                            foreach (var grp in fromServer.data)
                            {
                                groups.Add((String)grp);
                               
                            }
                            
                            Edit.AddToGroupWindow(groups);
                            break;


                        case "Login":
                            Console.WriteLine("Logging in");
                            string valid = (String)fromServer.data;
                            if (valid != null){
                                Edit.Login();
                            } else
                            {
                                Edit.InvalidLogin("Invalid info");
                            }
                           
                            break;

                        case "friendList":
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
                            break;

                        case "MyFriendRequest":
                            Edit.CheckOnFriendRequest((String)fromServer.SendFriendRequest);
                            break;

                        case "UserDeleted":
                            Edit.CheckOnFriendRequest((String)fromServer.DeleteUser);
                            break;

                        case "newFriend":
                            Edit.ChangeFriendRequest((String)fromServer.accepted);
                            break;

                        case "UserRejected":
                            Edit.ChangeFriendRequest((String)fromServer.RejectUser);
                            break;

                        case "ChatLogs":
                            Console.WriteLine("got chatlogs");
                            List<String> Chatlogs = new List<String>();
                            foreach (string log in fromServer.Log)
                            {
                                Chatlogs.Add(log);
                            }

                            if (fromServer.Username != null)
                            {
                                Console.WriteLine("Username: " + fromServer.Username);
                                Edit.AddingChatlogs(Chatlogs, (String)fromServer.Username);
                            } else
                            {
                                Console.WriteLine("Group ID: " + fromServer.GroupID);
                                Edit.AddLogsToGroupWindow(Chatlogs, (String)fromServer.GroupID);
                            }
                            break;

                        case "VoiceChatRequest":
                            Edit.OpenVoiceChat((String)fromServer.username, (String)fromServer.IP, (Int32)fromServer.PORT);
                            break;

                        case "VoiceChatAccept":
                            Console.WriteLine((String)fromServer.username + " accepted voicechat");
                            Edit.VoiceChatAccept((String)fromServer.username, (String)fromServer.IP, (Int32)fromServer.PORT);
                            break;

                        case "VoiceChatReject":
                            Console.WriteLine((String)fromServer.username + " rejected voicechat");
                            Edit.VoiceChatReject((String)fromServer.username);
                            break;
                        /*
                         case "":

                         break;
                        */

                        default:
                            Console.WriteLine("No match");
                            break;
                    }

                }


            }
        }
    }
}




