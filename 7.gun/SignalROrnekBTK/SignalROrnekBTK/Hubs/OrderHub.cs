﻿using Microsoft.AspNetCore.SignalR;

namespace SignalROrnekBTK.Hubs
{
    public class OrderHub : Hub
    {

        public override Task OnConnectedAsync()
        {

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
