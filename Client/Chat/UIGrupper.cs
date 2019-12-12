using Client.Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
  public partial class UIGrupper : Form
  {

    public String GroupName { get; set; }
    public static UIGrupper GUI;
    ServerFunctions Server = new ServerFunctions();
    GuiCollection AllGUIs = GuiCollection.GetCollectionsInstance;
    delegate void SetTextCallback(string text);

    public UIGrupper(String NewGroup)
    {
      InitializeComponent();
      GroupName = NewGroup;
      GUI = this;
      AllGUIs.AddGUIGroup(NewGroup, this);
      Console.WriteLine(GroupName);
      GetChatLog();
    }

    public void GetChatLog()
    {
      Message JsonObject = new Message
      {
        Function = "Get Chatlog",
        GroupID = Int32.Parse(GroupName)

      };

      Server.AddToQueue(JsonObject);
    }

    private void BntTilføj_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message
      string input = tbMember.Text;
      //tømmer textbox
      tbMember.Clear();

      //Laver json objekt
      Message JsonObject = new Message
      {
        Username = input,
        Function = "Add user"

      };
      Server.AddToQueue(JsonObject);
    }

    private void bntFjern_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message
      string input = tbMember.Text;
      //tømmer textbox
      tbMember.Clear();

      //Laver json objekt
      Message JsonObject = new Message
      {
        Username = input,
        Function = "Remove user"

      };
      Server.AddToQueue(JsonObject);
    }

    private void bntSendChat_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message
      string input = tbMessage.Text;

      //tømmer textbox
      tbMessage.Clear();

      //Laver json objekt
      Message JsonObject = new Message
      {
        Chat = input,
        Function = "Group chat",
        Group = GroupName
      };

      //Objektet tager ServerFunctions sig af
      Server.AddToQueue(JsonObject);
      tbChat.Text += "You wrote: " + input + Environment.NewLine;
    }

    public void ChangeGroupWindow(String text)
    {
      Console.WriteLine(text);
      Console.WriteLine("GM er {0}", GroupName);

      if (tbChat.InvokeRequired)
      {
        SetTextCallback d = new SetTextCallback(ChangeGroupWindow);
        tbChat.Invoke(d, new object[] { tbChat.Text + text + Environment.NewLine });
      }
      else
      {
        this.tbChat.Text = text;
      }

    }

    public void ChangeMemberWindow(String text)
    {
      if (tbMember.InvokeRequired)
      {
        SetTextCallback d = new SetTextCallback(ChangeMemberWindow);
        tbMember.Invoke(d, new object[] { tbMember.Text + text + Environment.NewLine });
      }
      else
      {
        this.tbMember.Text = text;
      }

    }
  }
}
