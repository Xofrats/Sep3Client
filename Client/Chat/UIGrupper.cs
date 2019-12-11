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

    public String GroupMembers { get; set; }
    ServerFunctions Server = new ServerFunctions();
    GuiCollection AllGUIs = GuiCollection.GetCollectionsInstance;
    delegate void SetTextCallback(string text);

    public UIGrupper(String NewGroup)
    {
      InitializeComponent();
      GroupMembers = NewGroup;
      AllGUIs.AddGUIGroup(NewGroup, this);
      Console.WriteLine(GroupMembers);
    }

    private void BntTilføj_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message
      string input = textBoxTilføj.Text;
      //tømmer textbox
      textBoxTilføj.Clear();

      //Laver json objekt
      Message JsonObject = new Message
      {
        Username = input,
        Function = "addGroupMemeber"

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
        Group = GroupMembers
      };

      //Objektet tager ServerFunctions sig af
      Server.AddToQueue(JsonObject);
      tbChat.Text += "You wrote: " + input + Environment.NewLine;
    }

    public void ChangeGroupWindow(String text)
    {
      Console.WriteLine(text);
      Console.WriteLine("GM er {0}", GroupMembers);
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
  }
}
