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
            //Laver objektet om til en string
            String json = JsonConvert.SerializeObject(bruger);
            //Laver json string om til bytes og sender dem
            client.network.Write(Encoding.ASCII.GetBytes(json), 0, json.Length);
            //13 er et linje skift og aflutter linjen
            client.network.WriteByte(13);
            //tømmer streamen
            client.network.Flush();

            //Venter på svar
            int recv = client.network.Read(data, 0, data.Length);
            //laver svaret om fra byte til string
            stringData = Encoding.ASCII.GetString(data, 0, recv);
            //Laver string om et json objekt
            dynamic test = JsonConvert.DeserializeObject(stringData);

            foreach (string ven in test.data)
            {
                //skriver venner
                TbFriends.Text += ven + Environment.NewLine;
               
            }

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

            //venter på svar
            int recv = client.network.Read(data, 0, data.Length);
            stringData = Encoding.ASCII.GetString(data, 0, recv);
            dynamic test = JsonConvert.DeserializeObject(stringData);
            TbChatWindow.Text += test.name + Environment.NewLine;
        }

    private void btnAddFriend_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message
      string input = textBoxUsername.Text;
      //tømmer textbox
      textBoxUsername.Clear();

      byte[] data = new byte[1024];
      string stringData;

      //Laver json objekt
      Bruger bruger = new Bruger();
      bruger.Username = input;
      bruger.Function = "Add friend";
      //Laver objektet om til en string
      String json = JsonConvert.SerializeObject(bruger);
      //Laver string om til bytes og sender det
      client.network.Write(Encoding.ASCII.GetBytes(json), 0, json.Length);
      //13 er et linje skrift og afslutter linjen.
      client.network.WriteByte(13);
      client.network.Flush();

      //venter på svar
      int recv = client.network.Read(data, 0, data.Length);
      stringData = Encoding.ASCII.GetString(data, 0, recv);
      dynamic test = JsonConvert.DeserializeObject(stringData);
      textBoxFriendRequest.Text += test.name + Environment.NewLine;
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

      byte[] data = new byte[1024];

      //Laver json objekt
      Bruger bruger = new Bruger();
      bruger.Username = input;
      bruger.Function = "Accepted";
      //Laver objektet om til en string
      String json = JsonConvert.SerializeObject(bruger);
      //Laver string om til bytes og sender det
      client.network.Write(Encoding.ASCII.GetBytes(json), 0, json.Length);
      //13 er et linje skrift og afslutter linjen.
      client.network.WriteByte(13);
      client.network.Flush();
    }

    private void btnReject_Click(object sender, EventArgs e)
    {

    }

    private void btnDeleteFriend_Click(object sender, EventArgs e)
    {
      //Tager teksten fra textbox message
      string input = textBoxUsername.Text;
      //tømmer textbox
      textBoxUsername.Clear();

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
