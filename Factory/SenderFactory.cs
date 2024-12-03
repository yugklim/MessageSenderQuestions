using MessageSenderQuestions.SenderAbstractions;
using MessageSenderQuestions.Senders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSenderQuestions.Factories
{
    public class SenderFactory
    {
        public IMessageSender CreateMessageSender(string senderType)
        {
            switch (senderType)
            {
                case "tcp":
                    return new TcpMessageSender();
                case "http":
                    return new HttpMessageSender();
                case "file":
                    return new FileMessageSender();
                default:
                    throw new ArgumentException("Wrong sender type.");
            }
        }
    }
}
