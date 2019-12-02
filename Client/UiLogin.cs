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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void bntOpretBrugerSide(object sender, EventArgs e)
        {
            UiOpretbruger m = new UiOpretbruger();
            m.Show();
        }

        private void bntLogin(object sender, EventArgs e)
        {
            //Tager teksten fra textbox message
            string input = textBoxUsername.Text;
            string input1 = textBoxPassword.Text;

            //tømmer textbox
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            //Laver json objekt
            Message JsonObject = new Message();
            JsonObject.Password = input1;
            JsonObject.Username = input;
            JsonObject.Function = "Login";

            ServerFunctions ServerFunctions = new ServerFunctions();
            ServerFunctions.AddToQueue(JsonObject);
        }

      
    }
}
