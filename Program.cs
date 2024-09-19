using MessageSenderQuestions;
using MessageSenderQuestions.Senders;

string senderType = args[0];

switch (senderType)
{
    case "tcp":
        var tcpMessageSender = new TcpMessageSender();
        await tcpMessageSender.SendAsync("Something");
        break;
    case "http":
        var httpMessageSender = new HttpMessageSender();
        await httpMessageSender.SendAsync("Something");
        break;
    case "file":
        var fileMessageSender = new FileMessageSender();
        await fileMessageSender.SendAsync("Something");
        break;
    default:
        break;
}       




