using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Icy_7
{

    public class MessagingService
    {

        public event MessageHandler MessageReceivedEvent;
        public event MessageHandler MessageSentEvent;
        public event MessageHandler MessageFailedEvent;

        public void ReceivedMessage(string message)
        {
            MessageReceivedEvent?.Invoke(message);
        }
        public void SendMessage(string message)
        {
            MessageSentEvent?.Invoke(message);
        }
        public void FailMessage(string message)
        {
            MessageFailedEvent?.Invoke(message);
        }
    }
}
