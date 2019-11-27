using Client.QueueIn;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class UI : Form
    {

        //laver det objekt der har de funkioner UIen skal bruge
        ServerFunctions ServerFunctions = new ServerFunctions();

        //LAver de objekter der styr køerne
        OutConsumer outConsumer = new OutConsumer();
        InConsumer inConsumer = new InConsumer();
        InProducer inProducer = new InProducer();

        //Kan gemme UIen i sig selv
        public static UI GUIinstance;

        public UI()
        {
            //Laver UI'en
            InitializeComponent();
            // gemmer sig selv
            GUIinstance = this;
            // starter alle tråde
            startThreads();
        }

     

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void startThreads()
        {

            //starter køerne ind og ud
            Thread outConsume = new Thread(new ThreadStart(outConsumer.TakeFromQueue));
            outConsume.Start();

            Thread inConsume = new Thread(new ThreadStart(inConsumer.FromServer));
            inConsume.Start();

            Thread inProduce = new Thread(new ThreadStart(inProducer.ListenToServer));
            inProduce.Start();
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
                Function = "Chat"
            };

            ServerFunctions.AddToQueue(JsonObject);
  

            TbChatWindow.Text += input + Environment.NewLine;

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
    }
}
