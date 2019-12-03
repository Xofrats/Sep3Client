using Client;
using Client.QueueIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        //Laver de objekter der styr køerne
        OutConsumer outConsumer = new OutConsumer();
        InConsumer inConsumer = new InConsumer();
        InProducer inProducer = new InProducer();

        Thread outConsume = new Thread(new ThreadStart(outConsumer.TakeFromQueue));
        outConsume.Start();

        Thread inConsume = new Thread(new ThreadStart(inConsumer.FromServer));
        inConsume.Start();

        Thread inProduce = new Thread(new ThreadStart(inProducer.ListenToServer));
        inProduce.Start();

        Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
}

