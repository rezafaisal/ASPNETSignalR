using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading;

namespace HelloSignalR
{
    public class TimerHub : Hub
    {
        public void Knock()
        {
            while (true)
            {
                Thread.Sleep(5000);
                string waktu = DateTime.Now.ToString();
                Clients.All.doknock(waktu);
            }
        }
    }
}