using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Client
{
    public partial class UI : Form
    {
        Client client = new Client();

        public UI()
        {
            //Laver UI'en
            InitializeComponent();
            //Kører funktion til at lave en forbindelse til serveren
            CreateConnection();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateConnection()
        {
            byte[] data = new byte[1024];
            string stringData;

            //Forbinder til server
          client.TCPClient = client.connect();
          client.network = client.TCPClient.GetStream();

            //Modtager test besked
            int recv = client.network.Read(data, 0, data.Length);
            stringData = Encoding.ASCII.GetString(data, 0, recv);
            dynamic test = JsonConvert.DeserializeObject(stringData);
            TbChatWindow.Text = test.name + Environment.NewLine;

            //virker ikke
          //  Task Reading = Task.Run(() => InFromServer());
        }

        //virker ikke
        /*private void InFromServer()
        {
            byte[] data = new byte[1024];
            string stringData;

            while (true)
            {
                int recv = client.network.Read(data, 0, data.Length);
                stringData = Encoding.ASCII.GetString(data, 0, recv);
                dynamic test = JsonConvert.DeserializeObject(stringData);
                TbChatWindow.Text += test.name + "\n";
                
            }
        }*/



        private void GetFriends(object sender, EventArgs e)
        {
            
            byte[] data = new byte[1024];
            string stringData;

            //Laver JSON objekt
            Bruger bruger = new Bruger
            {
                Function = "Venner"
            };
            //Laver objektet om til en string
            String json = JsonConvert.SerializeObject(bruger);
            //Laver json string om til bytes og sender dem
            client.network.Write(Encoding.ASCII.GetBytes(json), 0, json.Length);
            //13 er et linje skrift og aflutter linjen
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

        }

        private void WriteToServer(object sender, EventArgs e)
        {
            //Tager teksten fra textbox message
            string input = TextBoxMessage.Text;
            //tømmer textbox
            TextBoxMessage.Clear();

            byte[] data = new byte[1024];
            string stringData;

            //Laver json objekt
            Bruger bruger = new Bruger();
            bruger.Chat = input;
            bruger.Function = "Chat";
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
            TbChatWindow.Text += test.name + Environment.NewLine;




        }
    }
}
