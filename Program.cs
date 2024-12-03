using MessageSenderQuestions;
using MessageSenderQuestions.Factories;
using MessageSenderQuestions.SenderAbstractions;
using MessageSenderQuestions.Senders;

string message = args[0];
string senderType = args[1];
IMessageSender sender = new SenderFactory().CreateMessageSender(senderType);
await sender.SendAsync(message);





