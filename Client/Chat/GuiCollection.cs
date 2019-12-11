using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Chat
{
    class GuiCollection
    {
        Dictionary<String, ChatWindow> AllChats = new Dictionary<string, ChatWindow>();

        private static GuiCollection CollectionsInstance = null;

        private GuiCollection()
        {
        }

        public static GuiCollection GetCollectionsInstance
        {
            get
            {
                if (CollectionsInstance == null)
                {
                    CollectionsInstance = new GuiCollection();
                }
                return CollectionsInstance;
            }
        }

        public void AddGUI(String Name, ChatWindow GUI)
        {
            AllChats.Add(Name, GUI);
            
        }

        public ChatWindow GetGUI(String Name)
        {
            if(AllChats.ContainsKey(Name))
            return AllChats[Name];
            return null;
        }
    }
}
