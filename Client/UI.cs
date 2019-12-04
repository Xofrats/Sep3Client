using Client.QueueIn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public int NumberOfFriends { get; set; }
        public List<String> NamesOfFriends { get; set; }



        public UI()
        {
            //Laver UI'en
            InitializeComponent();
            // gemmer sig selv
           GUIinstance = this;
            HiddenFriends.FlatStyle = FlatStyle.Flat;
            HiddenFriends.FlatAppearance.BorderColor = BackColor;
            HiddenFriends.FlatAppearance.MouseOverBackColor = BackColor;
            HiddenFriends.FlatAppearance.MouseDownBackColor = BackColor;

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

      //Objektet tager ServerFunctions sig af
      ServerFunctions.AddToQueue(JsonObject);
      textBoxUsername.Text += input;
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

      textBoxFriendRequest.Clear();

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

        public void AddToFriendWindow(List<String> Names, int Count)
        {
            NumberOfFriends = Count;
            NamesOfFriends = Names;
            if (TbChatWindow.InvokeRequired)
            {  
                TbChatWindow.Invoke(new Action(() => { HiddenFriends.PerformClick(); }));
            }
          

        }


       

        private void BTNtest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumberOfFriends; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(0, i * 25);
                btn.Name = NamesOfFriends[i];
                btn.Text = NamesOfFriends[i];
                btn.Click += new EventHandler(Start_Chat);

                TbFriends.Controls.Add(btn);
            }
        }

        private void Start_Chat(object sender, EventArgs e)
        {
            ChatWindow chatWindow = new ChatWindow((sender as Button).Text);
            chatWindow.Show();
        }

        public void ChangeGetAllFriendList(String text)
        {

          if (textBoxAllRequest.InvokeRequired)
          {
            SetTextCallback d = new SetTextCallback(ChangeGetAllFriendList);
            textBoxAllRequest.Invoke(d, new object[] { textBoxAllRequest.Text + text + Environment.NewLine });
          }
          else
          {
            this.textBoxAllRequest.Text = text;
          }

        }

    public void ChangeAllFriendList(String text)
    {

      if (textBoxAllRequest.InvokeRequired)
      {
        SetTextCallback d = new SetTextCallback(ChangeAllFriendList);
        textBoxAllRequest.Invoke(d, new object[] { textBoxAllRequest.Text + text + Environment.NewLine });
      }
      else
      {
        this.textBoxAllRequest.Text = text;
      }

    }

    public void ChangeOneFriendList(String text)
        {

          if (textBoxFriendRequest.InvokeRequired)
          {
            SetTextCallback d = new SetTextCallback(ChangeOneFriendList);
        textBoxFriendRequest.Invoke(d, new object[] { textBoxFriendRequest.Text + text + Environment.NewLine });
          }
          else
          {
            this.textBoxFriendRequest.Text = text;
          }
        }

    public void ChangeFriendRequest(String text)
        {

          if (textBoxFriendRequest.InvokeRequired)
          {
            SetTextCallback d = new SetTextCallback(ChangeFriendRequest);
            textBoxFriendRequest.Invoke(d, new object[] { textBoxFriendRequest.Text + text + Environment.NewLine });
          }
          else
          {
            this.textBoxFriendRequest.Text = text;
          }

        }

       
    }
}
