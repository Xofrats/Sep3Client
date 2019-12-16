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
        public bool Valid = false;
        public bool Running;

        //Laver de objekter der styr køerne
        OutConsumer outConsumer = new OutConsumer();
        InConsumer inConsumer = new InConsumer();
        InProducer inProducer = new InProducer();

        delegate void SetTextCallback(string text);



        public Form1()
        {
            InitializeComponent();
            // gemmer sig selv
            GUIinstance = this;
            startThreads();

        }

        public void startThreads()
        {
            Thread outConsume = new Thread(new ThreadStart(outConsumer.TakeFromQueue));
            outConsume.Start();

            Thread inConsume = new Thread(new ThreadStart(inConsumer.FromServer));
            inConsume.Start();

            Thread inProduce = new Thread(new ThreadStart(inProducer.ListenToServer));
            inProduce.Start();
        }
        private void BntOpretBrugerSide(object sender, EventArgs e)
        {
            UiOpretbruger m = new UiOpretbruger();
            m.Show();
            this.Hide();


    }

        private void BntLogin(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text) || string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                return;
            }
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

            Running = true;
            while (Running)
            {
                if (Valid)
                {
                    Running = false;
                    UI ui = new UI();          
                    ui.Show();
                    this.Hide();

        }
      }
    }

        public void LoginToChat()
        {
            Valid = true;
        }

        public void ErrorChat(String text)
        {
            Running = false;

            if (textBoxPassword.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(ErrorChat);
                textBoxPassword.Invoke(d, new object[] {text});
                textBoxUsername.Invoke(d, new object[] {text});
            }
            else
            {
                this.textBoxPassword.Text = text;
                this.textBoxUsername.Text = text;
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
        }
    }
}
