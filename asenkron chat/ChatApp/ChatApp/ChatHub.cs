using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace ChatApp
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public override Task OnConnected()
        { 
            return Clients.All.joined(Context.ConnectionId);
        }

        public void Send(string name,string message)
        {

            Clients.All.addNewMessageToPage(name, message);

        }

        public void SendPrivateMessage(string toUserId,string toUserName,string fromUserId,string fromUserName, string message)
        {
  

        }

    }
}