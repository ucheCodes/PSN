using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Hosting;

namespace PSN_Official.Data
{
    public class AppHub : Hub
    {
        public const string HubUrl = "/signalr";
        public async void SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("Send", user, message);
        }
        public async void Notify(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                await Clients.All.SendAsync("Notification", message);
            }
        }
        public async void AddComment(BlogComment comment)
        {
            if (comment.Id != "" && comment.BlogId != "")
            {
                await Clients.All.SendAsync("AddComment", comment);
            }
        }
    }
}
