using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

/// <summary>
/// Source: https://docs.microsoft.com/en-us/aspnet/core/tutorials/signalr?tabs=visual-studio&view=aspnetcore-2.2
/// </summary>
namespace TestSignalR.Hubs
{
    /// <summary>
    /// A hub is a class that serves as a high-level pipeline that handles client-server communication.
    /// </summary>
    public class MessageHub : Hub
    {
        /// <summary>
        /// The SendMessage method can be called by a connected client (JavaScript client) to send a message to all clients.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
