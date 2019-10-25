using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using WebSocketManager;
using WebSocketManager.Common;

namespace CommunicationCore
{
    public class GameCommunication : WebSocketHandler
    {
        public GameCommunication(WebSocketConnectionManager webSocketConnectionManager) : base(webSocketConnectionManager, new ControllerMethodInvocationStrategy())
        {
            ((ControllerMethodInvocationStrategy)MethodInvocationStrategy).Controller = this;
        }

        public override async Task OnConnected(WebSocket socket)
        {
            await base.OnConnected(socket);
            var socketId = WebSocketConnectionManager.GetId(socket);

            var message = new Message() 
            {
                Data = $"{socketId} you are connected Peter"
            };

            await SendMessageAsync(socketId, message);
        }

        // this method can be called from a client, add user.
        public async Task Move(WebSocket socket, string direction)
        {
            var socketId = WebSocketConnectionManager.GetId(socket);

            Message responseMessage = new Message()
            {
                Data = "good"
            };

            await SendMessageAsync(socketId, responseMessage);
        }
    }
}
