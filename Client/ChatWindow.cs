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
        public String Name { get; set; }
        ServerFunctions Server = new ServerFunctions();

        public ChatWindow(String NewName)
        {
            InitializeComponent();
            Name = NewName;
            TbChatTitle.Text = "Chat with " + Name;
            
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
    }
}
