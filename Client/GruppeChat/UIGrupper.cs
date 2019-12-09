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
    public partial class UIGrupper : Form
    {

        //laver det objekt der har de funkioner UIen skal bruge
        ServerFunctions ServerFunctions = new ServerFunctions();
       
        public UIGrupper(string text)
        {
            InitializeComponent();
        }

        private void BntTilføj_Click(object sender, EventArgs e)
        {
            //Tager teksten fra textbox message
            string input = textBoxTilføj.Text;
            //tømmer textbox
            textBoxTilføj.Clear();

            //Laver json objekt
            Message JsonObject = new Message
            {
                Username = input,
                Function = "addGroupMemeber"
                
        };
            ServerFunctions.AddToQueue(JsonObject);
    }
    } 
}
