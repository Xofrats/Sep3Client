using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class loading : Form
    {
     

        public loading()
        {
            InitializeComponent();

        }

        private void ConnectToServer()
        {
          
            try
            {
                Client client = Client.Instance;
                

            }
            catch (SocketException e)
            {
                Console.WriteLine("Unable to connect to server");

                    System.Threading.Thread.Sleep(2000);
    
                ConnectToServer();
               
            }
        }

        private void loading_Shown(object sender, EventArgs e)
        {
            Task connect = Task.Factory.StartNew(() =>
            {
                ConnectToServer();
            });

            connect.Wait();


            Form1 Login = new Form1();
            Login.Show();

            this.Hide();
        }
    }
}
