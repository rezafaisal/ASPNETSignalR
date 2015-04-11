using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace HelloSignalR
{
    public class HelloWorld : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void Send(string user, string pesan)
        {
            Clients.All.show(user, pesan);
        }

        public override Task OnConnected()
        {
            return Clients.All.connected();
        }
    }
}