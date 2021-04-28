using System;
using System.Timers;

namespace EventsHandlr
{
    class Program
    {
        static int counter = 0;
        static string displayString = "This ";
        static void Main(string[] args)
        {
            //Timer myTimer = new Timer(10);
            //myTimer.Elapsed += new ElapsedEventHandler(WriteChar);
            //myTimer.Start();


            Connection myConnection = new Connection();
            Display myDisplay = new Display();
            myConnection.MessageArrived += new MessageHandler(myDisplay.DisplayMessage);
            myConnection.Connect();
            Console.ReadLine();
        }
        static void WriteChar(object source, ElapsedEventArgs e)
        {
            Console.Write(displayString[counter++ % displayString.Length]);
        }

    }
}
