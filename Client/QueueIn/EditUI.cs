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

    public void AddToChatWindow(String message)
    {
      UI.GUIinstance.ChangeChatWindow(message);
    }

    public void GetAllFriendRequest(String message)
    {
      UI.GUIinstance.ChangeAllFriendList(message);
    }

    public void GetOneFriendRequest(String message)
    {
      UI.GUIinstance.ChangeOneFriendList(message);
    }

    public void AcceptFriendRequest(String message)
    {
      UI.GUIinstance.ChangeFriendRequest(message);
    }
  }
}
