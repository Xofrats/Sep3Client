using Client.QueueIn;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class UI : Form
    {

        //laver det objekt der har de funkioner UIen skal bruge
        ServerFunctions ServerFunctions = new ServerFunctions();
        //Kan gemme UIen i sig selv
        public static UI GUIinstance;

        public UI()
        {
            //Laver UI'en
            InitializeComponent();
            // gemmer sig selv
           GUIinstance = this;
          
        }

        private void GetFriends(object sender, EventArgs e)
        {
            //For at hente sin venne liste. Der laves et JsonObjekt
            Message JsonObject = new Message
            {
                Function = "GetFriends"
            };

            //Objektet tager ServerFunctions sig af
            ServerFunctions.AddToQueue(JsonObject);
        }

        private void WriteToServer(object sender, EventArgs e)
        {
            //Tager teksten fra textbox message
            string input = TextBoxMessage.Text;

            //tømmer textbox
            TextBoxMessage.Clear();

            //Laver json objekt
            Message JsonObject = new Message
            {
                Chat = input,
                Function = "Chat",
                Username = "Sitch"
            };

            //Objektet tager ServerFunctions sig af
            ServerFunctions.AddToQueue(JsonObject);
            TbChatWindow.Text += input + Environment.NewLine;
        }

    private void btnAddFriend_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message
      string input = textBoxUsername.Text;
      //tømmer textbox
      textBoxUsername.Clear();

      //Laver json objekt
      Message JsonObject = new Message();
      JsonObject.Username = input;
      JsonObject.Function = "Add friend";
    }

    private void textBoxUsername_Click(object sender, EventArgs e)
    {
      textBoxUsername.Clear();
    }

    private void btnAccept_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message
      string input = textBoxFriendRequest.Text;
      //tømmer textbox
      textBoxFriendRequest.Clear();

      //Laver json objekt
      Message JsonObject = new Message();
      JsonObject.Username = input;
      JsonObject.Function = "Accepted";
    }

    private void BtnReject_Click(object sender, EventArgs e)
    {

    }

    private void BtnDeleteFriend_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message
      string input = textBoxUsername.Text;
      //tømmer textbox
      textBoxUsername.Clear();

      //Laver json objekt
      Message JsonObject = new Message();
      JsonObject.Username = input;
      JsonObject.Function = "Delete friend";
      


      textBoxFriendRequest.Text += input + Environment.NewLine;
            ServerFunctions.AddToQueue(JsonObject);

        }

        delegate void SetTextCallback(string text);

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

        public void ChangeFriendWindow(String text)
        {

            if (TbFriends.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(ChangeFriendWindow);
                TbFriends.Invoke(d, new object[] { TbFriends.Text + text + Environment.NewLine });
            }
            else
            {
                this.TbFriends.Text = text;
            }

        }
    }
}
