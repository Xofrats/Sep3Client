using Client.QueueIn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
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
        delegate void SetTextCallback(string text);



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

    private void btnAddFriend_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message
      string input = textBoxUsername.Text;
      //tømmer textbox
      textBoxUsername.Clear();

            //Laver json objekt
            Message JsonObject = new Message
            {
                Username = input,
                Function = "Add friend"
            };

      //Objektet tager ServerFunctions sig af
      ServerFunctions.AddToQueue(JsonObject);
    }

    private void TextBoxUsername_Click(object sender, EventArgs e)
    {
      textBoxUsername.Clear();
    }

    private void BtnAccept_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message
      string input = textBoxFriendRequest.Text.Trim();
      //tømmer textbox
      textBoxFriendRequest.Clear();

            //Laver json objekt
            Message JsonObject = new Message
            {
                Username = input,
                Function = "Accepted"
            };

      ServerFunctions.AddToQueue(JsonObject);
    }

    private void BtnReject_Click(object sender, EventArgs e)
    {
      string input = textBoxFriendRequest.Text.Trim();
      //tømmer textbox
      textBoxFriendRequest.Clear();

      //Laver json objekt
      Message JsonObject = new Message();
      JsonObject.Username = input;
      JsonObject.Function = "Rejected";

      ServerFunctions.AddToQueue(JsonObject);
    }

    private void BtnDeleteFriend_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message
      string input = textBoxUsername.Text;
      //tømmer textbox
      textBoxUsername.Clear();

      //Laver json objekt
      Message JsonObject = new Message
      {
        Username = input,
        Function = "Delete friend"
      };

      //Objektet tager ServerFunctions sig af
      ServerFunctions.AddToQueue(JsonObject);
    }

    private void btnGetFriendRequest_Click(object sender, EventArgs e)
    {
      Message JsonObject = new Message();
      JsonObject.Function = "friend request";
      ServerFunctions.AddToQueue(JsonObject);
    }

        

 

        public void AddToFriendWindow(List<String> Names, int Count)
        {
            NumberOfFriends = Count;
            NamesOfFriends = Names;
            if (TbFriends.InvokeRequired)
            {
                TbFriends.Invoke(new Action(() => { HiddenFriends.PerformClick(); }));
            }
          

        }


       

        private void BTNtest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumberOfFriends; i++)
            {
                Button btn = new Button
                {
                    Location = new Point(0, i * 25),
                    Name = NamesOfFriends[i],
                    Text = NamesOfFriends[i]
                };
                btn.Click += new EventHandler(Start_Chat);

                TbFriends.Controls.Add(btn);
            }
        }

        private void Start_Chat(object sender, EventArgs e)
        {
            ChatWindow chatWindow = new ChatWindow((sender as Button).Text);
            chatWindow.Show();
        }

    public void ChangeGetAllFriendList(string text)
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

    public void ChangeMyFriendRequest(String text)
    {

      if (textBoxUsername.InvokeRequired)
      {
        SetTextCallback d = new SetTextCallback(ChangeMyFriendRequest);
        textBoxUsername.Invoke(d, new object[] { textBoxUsername.Text + text + Environment.NewLine });
      }
      else
      {
        this.textBoxUsername.Text = text;
      }
    }

    public void ChangeFriendRequest(String text)
    {
      if (textBoxStatus.InvokeRequired)
      {
        SetTextCallback d = new SetTextCallback(ChangeFriendRequest);
        textBoxStatus.Invoke(d, new object[] { textBoxStatus.Text + text + Environment.NewLine });
      }
      else
      {
        this.textBoxStatus.Text = text;
      }
    }
  }
}
