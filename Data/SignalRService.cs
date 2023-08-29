using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace PSN_Official.Data
{
    public class SignalRService
    {
        public HubConnection HubConnection { get; }
        private readonly NavigationManager navManager;

        public SignalRService(NavigationManager navigationManager)
        {
            navManager = navigationManager;
            string baseUri = navManager.BaseUri;
            string hubUrl = baseUri.Trim('/') + AppHub.HubUrl;
            HubConnection = new HubConnectionBuilder()
            .WithUrl(hubUrl)
            .Build();
            HubConnection.StartAsync();
        }
    }
}
