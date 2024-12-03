using MessageSenderQuestions;
using MessageSenderQuestions.Factories;
using MessageSenderQuestions.SenderAbstractions;
using MessageSenderQuestions.Senders;

string message = args[0];
string senderType = args[1];
var senderFactory = new SenderFactory();
IMessageSender sender = senderFactory.CreateMessageSender(senderType);
await sender.SendAsync(message);





