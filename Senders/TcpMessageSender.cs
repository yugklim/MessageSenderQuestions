using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MessageSenderQuestions.SenderAbstractions;

/// Task: you should 

namespace MessageSenderQuestions.Senders
{
    public class TcpMessageSender : IMessageSender
    {
        public async Task<string> SendAsync(string message)
        {
            IPHostEntry ipHostInfo = await Dns.GetHostEntryAsync("host.contoso.com");
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint ipEndPoint = new(ipAddress, 11000);
            using (Socket client = new(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp))
            {
                await client.ConnectAsync(ipEndPoint);
                var messageBytes = Encoding.UTF8.GetBytes(message);
                await client.SendAsync(messageBytes, SocketFlags.None);
                var buffer = new byte[1024];
                var received = await client.ReceiveAsync(buffer, SocketFlags.None);
                var response = Encoding.UTF8.GetString(buffer, 0, received);
                return response;
            }
        }
    }
}
