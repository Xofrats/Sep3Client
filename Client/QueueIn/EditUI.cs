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
            if (AllGUIs.GetGUI(FromUsername) != null)
            {
                ChatWindow Chat = AllGUIs.GetGUI(FromUsername);
                Chat.ChangeChatWindow(Message);
            }
    }

    public void AddToGroupWindow(String FromUsername, String Message)
    {
      UIGrupper Group = AllGUIs.GetGroupGUI(FromUsername);
      Group.ChangeGroupWindow(Message);
    }

    public void AddingChatlogs(List<String> ChatLogs, String Username)
    {
      ChatWindow Chat = AllGUIs.GetGUI(Username);

      foreach (String log in ChatLogs)
      {
        Chat.ChangeChatWindow(log);
      }
    }

        public void AddLogsToGroupWindow(List<String> ChatLogs, String GroupID)
        {
            UIGrupper Group = AllGUIs.GetGroupGUI(GroupID);

            foreach (String log in ChatLogs)
            {
                Group.ChangeGroupWindow(log);
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

    public void CheckOnFriendRequest(String message)
    {
      UI.GUIinstance.ChangeMyFriendRequest(message);
    }

    public void ChangeFriendRequest(String message)
    {
      UI.GUIinstance.ChangeFriendRequest(message);
    }

    public void AddToFriendWindow(List<String> Names)
      {
        UI.GUIinstance.AddToFriendWindow(Names);
      }

    public void AddToGroupWindow(List<String> Names)
    {
      UI.GUIinstance.AddToGroupWindow(Names);
    }

    public void Login()
    {
      Form1.GUIinstance.LoginToChat();
    }

        public void OpenVoiceChat(String FromUser, String IP, int PORT)
        {

            UI.GUIinstance.OpenVoiceChat(FromUser, IP, PORT);
        }

        public void VoiceChatAccept(String Username, String IP, int PORT)
        {
            WavPlayer.wfrm_Main VoiceChat = AllGUIs.GetVoiceChatGUI(Username);
            VoiceChat.SetIP(IP);
            VoiceChat.SetPort(PORT);
        }
    }
}
