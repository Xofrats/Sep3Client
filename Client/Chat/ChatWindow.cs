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
    public partial class ChatWindow : Form
    {
        public new String Name { get; set; }
        ServerFunctions Server = new ServerFunctions();
      
        delegate void SetTextCallback(string text);

        public ChatWindow(String NewName)
        {
            InitializeComponent();
            Name = NewName;
            Console.WriteLine(Name);
            TbChatTitle.Text = "Chat with " + Name;
            GuiCollection AllGUIs = GuiCollection.GetCollectionsInstance;
            AllGUIs.AddGUI(Name, this);



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
                TbChatWindow.Text += "You wrote: "+ input + Environment.NewLine;
            
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
    }
}
