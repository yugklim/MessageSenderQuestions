namespace MessageSenderQuestions.SenderAbstractions
{
    public interface IMessageSender
    {
        public Task<string> SendAsync(string message);
    }
}