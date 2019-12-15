using Client.QueueIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
  public partial class Form1 : Form
  {
    //Kan gemme UIen i sig selv
    public static Form1 GUIinstance;
    public bool Valid;
    public bool Running = true;

    public Form1()
    {
      InitializeComponent();
      // gemmer sig selv
      GUIinstance = this;


    }
    private void BntOpretBrugerSide(object sender, EventArgs e)
    {
      UiOpretbruger m = new UiOpretbruger();
      m.Show();
      this.Hide();


    }

    private void BntLogin(object sender, EventArgs e)
    {
      //Laver json objekt
      Message JsonObject = new Message
      {
        Password = textBoxPassword.Text,
        Username = textBoxUsername.Text,
        Function = "Login"
      };

      //tømmer textbox
      textBoxUsername.Clear();
      textBoxPassword.Clear();

      ServerFunctions ServerFunctions = new ServerFunctions();
      ServerFunctions.AddToQueue(JsonObject);
      while (Running)
      {
        if (Valid)
        {
          Console.WriteLine("true loop");
          Running = false;
          UI ui = new UI();
          ui.Show();
          this.Hide();

        }
      }
    }

    public void LoginToChat()
    {
      Console.WriteLine("valid to equal true");
      Valid = true;
    }
  }
}
