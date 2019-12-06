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
        
       
    public EditUI()
    {
    }

    public void AddToChatWindow(String FromUsername, String Message)
    {
            GuiCollection AllGUIs = GuiCollection.GetCollectionsInstance;
            ChatWindow Chat = AllGUIs.GetGUI(FromUsername);
            Chat.ChangeChatWindow(Message);




    }

    public void GetAllFriendRequest(String message)
    {
      UI.GUIinstance.ChangeAllFriendList(message);
    }

    public void GetOneFriendRequest(String message)
    {
      UI.GUIinstance.ChangeOneFriendList(message);
    }

    public void CheckOnFriendRequest(String message)
    {
      UI.GUIinstance.ChangeMyFriendRequest(message);
    }

    public void ChangeFriendRequest(String message)
    {
      UI.GUIinstance.ChangeFriendRequest(message);
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
