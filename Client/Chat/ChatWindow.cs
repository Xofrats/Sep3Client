using Client.Chat;
using System;
using System.Collections.Generic;
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
