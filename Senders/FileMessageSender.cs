using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageSenderQuestions.SenderAbstractions;

namespace MessageSenderQuestions.Senders
{
    internal class FileMessageSender : IMessageSender
    {
        public async Task<string> SendAsync(string message)
        {
            string docPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TextMessage.txt");
            using (StreamWriter outputFile = new StreamWriter(docPath))
            {
                await outputFile.WriteAsync(message);
            }

            using (StreamReader readtext = new StreamReader(docPath))
            {
                return await readtext.ReadToEndAsync();
            }
        }
    }
}
