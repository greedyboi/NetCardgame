using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetworkCommsDotNet;

namespace Players
{
    class Connection
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the server IP and port in the format 192.168.0.1:10000 and press return:");
            string serverInfo = Console.ReadLine();

            string serverIP = serverInfo.Split(':').First();
            int serverPort = int.Parse(serverInfo.Split(':').Last());

            int loopCounter = 1;
            while (true)
            {
                string messageToSend = Console.ReadLine();
                Console.WriteLine("Sending message to server saying '" + messageToSend + "'");

                NetworkComms.SendObject("Message", serverIP, serverPort, messageToSend);

                Console.WriteLine("\nPress escape to quit or any other key to send another message.");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape) break;
                else loopCounter++;
            }

            NetworkComms.Shutdown();
        }
    }
}