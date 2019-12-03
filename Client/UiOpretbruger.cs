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
        public UiOpretbruger()
        {
            InitializeComponent();
        }

        private void BntOpretBruger_Click(object sender, EventArgs e)
        {
            //Tager teksten fra textbox message
            string input = textBoxEmail.Text;
            string input1 = textBoxUsername.Text;
            string input2 = textBoxPassword.Text;
            
            //tømmer textbox
            textBoxEmail.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();

            //Laver json objekt
            Message JsonObject = new Message
            {
                Password = input2,
                Username = input1,
                Email = input,
                Function = "Opret bruger"
            };

            ServerFunctions ServerFunctions = new ServerFunctions();
            ServerFunctions.AddToQueue(JsonObject);
        }

        private void UiOpretbruger_Load(object sender, EventArgs e)
        {

        }
    }
}
