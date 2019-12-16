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
  public partial class UiOpretbruger : Form
  {
    ServerFunctions server = new ServerFunctions();
    public static UiOpretbruger GUIinstance;
    delegate void SetTextCallback(string text);
    public UiOpretbruger()
    {
      InitializeComponent();
      GUIinstance = this;
    }

    private void BntOpretBruger_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message

      string input1 = textBoxUsername.Text;
      string input2 = textBoxPassword.Text;

      //tømmer textbox
      ;
      textBoxUsername.Clear();
      textBoxPassword.Clear();

      //Laver json objekt
      Message JsonObject = new Message
      {
        Password = input2,
        Username = input1,
        Function = "create user"
      };


      server.AddToQueue(JsonObject);
    }

    public void ChangeUser(String text)
    {
      if (tbStatus.InvokeRequired)
      {
        SetTextCallback d = new SetTextCallback(ChangeUser);
        tbStatus.Invoke(d, new object[] { tbStatus.Text + text + Environment.NewLine });
      }
      else
      {
        this.tbStatus.Text = text;
      }
    }
  }
}
