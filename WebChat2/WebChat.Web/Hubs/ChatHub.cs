using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebChat.Web.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string message)
        {
            Clients.All.getMessage(message);

        }
        public override System.Threading.Tasks.Task OnConnected()
        {
            Clients.All.getMessage("Server > yeni bir kullanıcı bağlandı");
            return base.OnConnected();
        }
    } 
}