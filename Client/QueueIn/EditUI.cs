using Client.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.QueueIn
{
    class EditUI
    {
        GuiCollection AllGUIs = GuiCollection.GetCollectionsInstance;

        public EditUI()
    {
    }

    public void AddToChatWindow(String FromUsername, String Message)
    {
            ChatWindow Chat = AllGUIs.GetGUI(FromUsername);
            Chat.ChangeChatWindow(Message);
    }

        public void AddingChatlogs(List<String> ChatLogs, String Username)
        {
            ChatWindow Chat = AllGUIs.GetGUI(Username);

            foreach (String log in ChatLogs)
            {
                Chat.ChangeChatWindow(log);
            }
        }

        public void GetAllFriendRequest(String message)
    {
      UI.GUIinstance.ChangeAllFriendList(message);
    }

    public void GetOneFriendRequest(String message)
    {
      UI.GUIinstance.ChangeOneFriendList(message);
    }

     

        public void AddToFriendWindow(List<String> Names, int count)
        {
           UI.GUIinstance.AddToFriendWindow(Names, count);
        }

        public void Login()
        {
            Form1.GUIinstance.LoginToChat();
        }
    }
}
