using Client.Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
  public partial class ChatWindow : Form
  {
    public new String Name { get; set; }
    ServerFunctions Server = new ServerFunctions();
    GuiCollection AllGUIs = GuiCollection.GetCollectionsInstance;

    delegate void SetTextCallback(string text);

    public ChatWindow(String NewName)
    {
      InitializeComponent();
      Name = NewName;
      AllGUIs.AddGUI(NewName, this);
      Console.WriteLine(Name);
      TbChatTitle.Text = "Chat with " + Name;
      GetChatLog();
    }


    public void GetChatLog()
    {
      Message JsonObject = new Message
      {

        Function = "Get Chatlog",
        Username = Name,
        Count = 2

      };

      //Objektet tager ServerFunctions sig af
      Server.AddToQueue(JsonObject);
    }

    private void SendChat(object sender, EventArgs e)
    {

      //Tager teksten fra textbox message
      string input = TbMessage.Text;

      //tømmer textbox
      TbMessage.Clear();

      //Laver json objekt
      Message JsonObject = new Message
      {
        Chat = input,
        Function = "Chat",
        Username = Name
      };

      //Objektet tager ServerFunctions sig af
      Server.AddToQueue(JsonObject);
      TbChatWindow.Text += "You wrote: " + input + Environment.NewLine;

    }

    private void btnSendFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFile = new OpenFileDialog();

      if (openFile.ShowDialog() == DialogResult.OK)
      {
        try
        {
          if (openFile.FileName != null)
          {
            string readFile = File.ReadAllText(openFile.FileName);
            string fileName = Path.GetFileName(openFile.FileName);
            Message JsonObject = new Message();
            JsonObject.fileName = fileName;
            JsonObject.Chat = readFile;
            JsonObject.Username = Name;
            JsonObject.Function = "Send file";

            //Objektet tager ServerFunctions sig af
            Server.AddToQueue(JsonObject);
            TbMessage.Text += fileName + Environment.NewLine;
          }
        }
        catch (SecurityException ex)
        {
          MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
          throw;
        }
      }
    }

    public void ChangeChatWindow(String text)
    {

      if (TbChatWindow.InvokeRequired)
      {
        SetTextCallback d = new SetTextCallback(ChangeChatWindow);
        TbChatWindow.Invoke(d, new object[] { TbChatWindow.Text + text + Environment.NewLine });
      }
      else
      {
        this.TbChatWindow.Text = text;
      }

    }

        //private void BTNVoiceChat_Start(object sender, EventArgs e)
        //{
        //    Random RNG = new Random();

        //    int PortNumber = RNG.Next(2000, 9999);
        //    Message JsonObject = new Message
        //    {
        //        Function = "VoiceChat",
        //        Username = Name,
        //        Count = PortNumber
        //    };

        //    Server.AddToQueue(JsonObject);

        //    WavPlayer.wfrm_Main VoiceChat = new WavPlayer.wfrm_Main(PortNumber, null, 25000, false);

        //    AllGUIs.AddVoiceChat(Name, VoiceChat);
        //    VoiceChat.Show();
        //}
    }
}
