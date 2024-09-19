using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MessageSenderQuestions.SenderAbstractions;

namespace MessageSenderQuestions.Senders
{
    internal class HttpMessageSender : IMessageSender
    {
        public async Task<string> SendAsync(string message)
        {
            var requestData = new StringContent(
                JsonSerializer.Serialize(new { message }),
                Encoding.UTF8,
                "application/json"
            );

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("Address");
                var response = await httpClient.PostAsync("send", requestData);
                return response.Content.ToString() ?? "Special value";
            }
        }
    }
}
