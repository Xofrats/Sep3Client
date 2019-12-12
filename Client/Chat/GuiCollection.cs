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
     Dictionary<String, UIGrupper> AllGroups = new Dictionary<string, UIGrupper>();
     Dictionary<String, WavPlayer.wfrm_Main> AllVoiceChats = new Dictionary<string, WavPlayer.wfrm_Main>();

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

    public void AddGUIGroup(String Name, UIGrupper GUIGroup)
    {
            Console.WriteLine("Got: " + Name + "and " + GUIGroup.Name);
      AllGroups.Add(Name, GUIGroup);
    }

    public ChatWindow GetGUI(String Name)
    {
      return AllChats[Name];
    }

    public UIGrupper GetGroupGUI(String Name)
    {
      Console.WriteLine("Hvad er {0}", Name);
      return AllGroups[Name];
    }

        public void AddVoiceChat(String Name, WavPlayer.wfrm_Main GUIVoiceChat)
        {
            AllVoiceChats.Add(Name, GUIVoiceChat);
        }

        public WavPlayer.wfrm_Main GetVoiceChatGUI(String Name)
        {
            Console.WriteLine("Hvad er {0}", Name);
            return AllVoiceChats[Name];
        }
    }
}
