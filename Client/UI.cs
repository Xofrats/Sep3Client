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
    public List<String> AllFriends { get; set; }
    public List<String> AllGroups { get; set; }
    delegate void SetTextCallback(string text);
    public Boolean Running { get; set; }
    public Boolean Valid { get; set; }



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

      HiddenGroups.FlatStyle = FlatStyle.Flat;
      HiddenGroups.FlatAppearance.BorderColor = BackColor;
      HiddenGroups.FlatAppearance.MouseOverBackColor = BackColor;
      HiddenGroups.FlatAppearance.MouseDownBackColor = BackColor;

      Running = true;
      Valid = false;



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

    private void GetGroups(object sender, EventArgs e)
    {
      //For at hente sine grupper. Der laves et JsonObjekt
      Message JsonObject = new Message
      {
        Function = "Get groups"
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
      Message JsonObject = new Message();

      //Tager teksten fra textbox message
      string input = textBoxFriendRequest.Text.Trim();
      //tømmer textbox
      textBoxFriendRequest.Clear();
      JsonObject.Username = input;
      JsonObject.Function = "Accepted";

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

    public void AddToFriendWindow(List<String> Names)
    {
      AllFriends = Names;
      if (TbFriends.InvokeRequired)
      {
        TbFriends.Invoke(new Action(() => { HiddenFriends.PerformClick(); }));
      }
    }

    public void AddToGroupWindow(List<String> Names)
    {
      AllGroups = Names;
      if (TbFriends.InvokeRequired)
      {
        TbFriends.Invoke(new Action(() => { HiddenGroups.PerformClick(); }));
      }
    }




    private void BTNHiddenFriends_Click(object sender, EventArgs e)
    {
      Console.WriteLine("making buttons");
      for (int i = 0; i < AllFriends.Count; i++)
      {
        Button btn = new Button
        {
          Location = new Point(0, i * 25),
          Name = AllFriends[i],
          Text = AllFriends[i]
        };
        btn.Click += new EventHandler(Start_Chat);
        TbFriends.Controls.Add(btn);
      }
    }

    private void btnGroupChat_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < AllGroups.Count; i++)
      {
        Button btn = new Button
        {
          Location = new Point(0, i * 25),
          Name = AllGroups[i],
          Text = AllGroups[i]

        };
        btn.Click += new EventHandler(Start_Group_Chat);

        TbFriends.Controls.Add(btn);
      }
    }

    private void Start_Chat(object sender, EventArgs e)
    {
      ChatWindow chatWindow = new ChatWindow((sender as Button).Text);
      chatWindow.Show();
    }

    private void Start_Group_Chat(object sender, EventArgs e)
    {
      UIGrupper UI = new UIGrupper((sender as Button).Text);
      UI.Show();
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

    public void ChangeNoFriends(string text)
    {

      if (TbFriends.InvokeRequired)
      {
        SetTextCallback d = new SetTextCallback(ChangeNoFriends);
        TbFriends.Invoke(d, new object[] { TbFriends.Text + text + Environment.NewLine });
      }
      else
      {
        this.TbFriends.Text = text;
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



    private void Get_Chatlogs(object sender, EventArgs e)
    {


      //Laver json objekt
      Message JsonObject = new Message
      {
        Function = "Get Chatlog"
      };

      ServerFunctions.AddToQueue(JsonObject);
    }



    private void bntOpretGruppe(object sender, EventArgs e)
    {
      Message JsonObject = new Message();
      //Tager teksten fra textbox message
      string input = tbCreateGroup.Text;
      //tømmer textbox
      tbCreateGroup.Clear();
      JsonObject.Group = input;
      JsonObject.Function = "Create group";

      ServerFunctions.AddToQueue(JsonObject);
    }

    //public void OpenVoiceChat(String FromUser, String IP, int PORT)
    //{
    //  var message = "Accept Voicechat from " + FromUser;
    //  var title = "Accept Voicechat";
    //  var result = MessageBox.Show(
    //      message,                  // the message to show
    //      title,                    // the title for the dialog box
    //      MessageBoxButtons.YesNo,  // show two buttons: Yes and No
    //      MessageBoxIcon.Question); // show a question mark icon

    //  Random RNG = new Random();

    //  int MyPort = RNG.Next(2000, 9999);

    //  // the following can be handled as if/else statements as well
    //  switch (result)
    //  {
    //    case DialogResult.Yes:   // Yes button pressed

    //    WavPlayer.wfrm_Main VoiceChat = new WavPlayer.wfrm_Main(MyPort, IP, PORT, true);
    //    new Thread(() => VoiceChat.ShowDialog()).Start();

    //    Message JsonObject = new Message
    //    {
    //      Function = "VoiceChatAccept",
    //      Username = FromUser,
    //      Count = MyPort
    //    };
    //    ServerFunctions.AddToQueue(JsonObject);



    //    break;

    //    case DialogResult.No:    // No button pressed
    //    Message JsonObject1 = new Message
    //    {
    //      Function = "VoiceChatReject",
    //      Username = FromUser
    //    };
    //    ServerFunctions.AddToQueue(JsonObject1);

    //    break;

    //    default:                 // Neither Yes nor No pressed (just in case)
    //    MessageBox.Show("What did you press?");
    //    break;
    //  }
    //}
    
    public void ChangeGroupCreated(String text)
    {
      if (tbCreateGroup.InvokeRequired)
      {
        SetTextCallback d = new SetTextCallback(ChangeGroupCreated);
        tbCreateGroup.Invoke(d, new object[] { tbCreateGroup.Text + text + Environment.NewLine });
      }
      else
      {
        this.tbCreateGroup.Text = text;
      }
    }
  }
}
