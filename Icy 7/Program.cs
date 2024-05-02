using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icy_7
{
    public delegate void MessageHandler(string Msg);

    internal class Program
    {
        static void Main(string[] args)
        {
            CallingClass();
            Console.ReadLine();
        }
        //calling methods
        static void CallingClass()
        {
            MessagingService ms = new MessagingService();
            ms.MessageReceivedEvent += UpdateUI;
            ms.MessageReceivedEvent += LogMessage;
            ms.MessageSentEvent += UpdateChatHistory;
            ms.MessageSentEvent += NotifyRecipient;
            ms.MessageFailedEvent += DisplayErrorMessage;
            ms.MessageFailedEvent += LogError;
            
            ms.ReceivedMessage("Recieved message");
            ms.SendMessage("This message was sent");
            ms.FailMessage("Failed message");

            ms.MessageReceivedEvent -= UpdateUI;
            ms.MessageSentEvent -= LogMessage;
            ms.MessageSentEvent -= UpdateChatHistory;
            ms.MessageSentEvent -= NotifyRecipient;
            ms.MessageFailedEvent -= DisplayErrorMessage;
            ms.MessageSentEvent -= LogError;
        }

        //Event Handlers 
        static void UpdateUI(string message)
        {
            Console.WriteLine("New UI updated message:\t" + message);
        }
        static void LogMessage(string message)
        {
            Console.WriteLine("Logged Message:\t\t" + message);
        }
        static void UpdateChatHistory(string message)
        {
            Console.WriteLine("\nUpdated Chat:\t\t" + message);
        }
        static void NotifyRecipient(string message)
        {
            Console.WriteLine("New notification\t" + message);
        }
        static void DisplayErrorMessage(string message)
        {
            Console.WriteLine("\nAn Error has occured:\t" + message);
        }
        static void LogError(string message)
        {
            Console.WriteLine($"Error:\t\t\t{message}");
        }

    }
}
