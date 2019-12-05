using Client.QueueIn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
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
                Message JsonObject = new Message();
                JsonObject.File = readFile;
                JsonObject.Function = "Send file";

                //Objektet tager ServerFunctions sig af
                ServerFunctions.AddToQueue(JsonObject);
          }
            }
            catch (SecurityException ex)
            {
              MessageBox.Show("Error: Could not read file from disk. Original error: " +
                ex.Message);
              throw;
            }
          }
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

      ServerFunctions.AddToQueue(JsonObject);
    }

    private void BtnReject_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message
      string input = textBoxFriendRequest.Text;
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
      Message JsonObject = new Message();
      JsonObject.Username = input;
      JsonObject.Function = "Delete friend";
      


      textBoxFriendRequest.Text += input + Environment.NewLine;
      ServerFunctions.AddToQueue(JsonObject);

    }

    private void btnGetFriendRequest_Click(object sender, EventArgs e)
    {
      Message JsonObject = new Message();
      JsonObject.Function = "friend request";
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
