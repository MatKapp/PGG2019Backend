using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using WebSocketManager;
using WebSocketManager.Common;
using WindowsInput;
using GameEngine;

namespace CommunicationCore
{
    public class GameCommunication : WebSocketHandler
    {
        const int PlayersNumber = 1;
        public GameEngine.GameEngine GameEngine { get; set; }

        public GameCommunication(WebSocketConnectionManager webSocketConnectionManager) : base(webSocketConnectionManager, new ControllerMethodInvocationStrategy())
        {
            ((ControllerMethodInvocationStrategy)MethodInvocationStrategy).Controller = this;
            GameEngine = new GameEngine.GameEngine(PlayersNumber);
        }

        public override async Task OnConnected(WebSocket socket)
        {
            await base.OnConnected(socket);
            var socketId = WebSocketConnectionManager.GetId(socket);
            GameEngine.AddPlayer(socketId);

            var message = new Message()
            {
                Data = $"{socketId} you are connected Peter"
            };

            await SendMessageAsync(socketId, message);
        }

        public override async Task OnDisconnected(WebSocket socket)
        {
            var socketId = WebSocketConnectionManager.GetId(socket);
            GameEngine.RemovePlayer(socketId);

            await base.OnDisconnected(socket);
        }

        // this method can be called from a client, add user.
        public async Task Move(WebSocket socket, string direction)
        {
            var socketId = WebSocketConnectionManager.GetId(socket);
            Message responseMessage;

            if (GameEngine.FindPlayerId(socketId) != -1)
            {
                Enum.TryParse(typeof(MoveDirection), direction, true, out var moveDirection);
                GameEngine.Move(socketId, (MoveDirection)moveDirection);
                var simulator = new InputSimulator();
                responseMessage = new Message()
                {
                    Data = "OK"
                };
            }
            else
            {
                responseMessage = new Message()
                {
                    Data = "You are not connected"
                };
            }

            await SendMessageAsync(socketId, responseMessage);
        }
    }
}
