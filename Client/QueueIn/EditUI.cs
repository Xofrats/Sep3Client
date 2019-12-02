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

        public void AddToFriendWindow(String message)
        {
          //  UI.GUIinstance.ChangeFriendWindow(message);
        }
    }
}
