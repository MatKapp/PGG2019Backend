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
        const int PlayersNumber = 4;
        public GameEngine.GameEngine GameEngine { get; set; }

        public GameCommunication(WebSocketConnectionManager webSocketConnectionManager) : base(webSocketConnectionManager, new ControllerMethodInvocationStrategy())
        {
            ValidatePlayersNumber();

            ((ControllerMethodInvocationStrategy)MethodInvocationStrategy).Controller = this;
            GameEngine = new GameEngine.GameEngine(PlayersNumber);
        }

        private void ValidatePlayersNumber()
        {
            if (PlayersNumber % 2 == 1)
                throw new Exception("Please change number of players to a even number");
        }

        public override async Task OnConnected(WebSocket socket)
        {
            await base.OnConnected(socket);
            var socketId = WebSocketConnectionManager.GetId(socket);

            var message = new Message()
            {
                MessageType = MessageType.Connected,
                Data = $"Hello! Add a player BRO."
            };

            await SendMessageAsync(socketId, message);
        }

        // this method can be called from a client, add user.
        public async Task AddPlayer(WebSocket socket, string teamName)
        {
            var socketId = WebSocketConnectionManager.GetId(socket);
            GameEngine.AddPlayer(socketId, teamName);
            SendTeamIdToPlayers();
            if (GameEngine.GameStarted)
            {
                Message responseMessage = new Message()
                {
                    MessageType = MessageType.GameStarted,
                    Data = "Lets play a game"
                };

                await SendMessageToAllAsync(responseMessage);
            }
            //else
            //{
            //    SendTeamIdToPlayers();
            //}
        }

        private async void SendTeamIdToPlayers()
        {
            for (int i = 0; i < GameEngine.PlayerSocketIds.Length; i++)
            {
                if (!String.IsNullOrEmpty(GameEngine.PlayerSocketIds[i]))
                {
                    int teamId = i / 2;

                    Message teamIdMessage = new Message()
                    {
                        MessageType = MessageType.Joined,
                        Data = i.ToString()
                    };

                await SendMessageAsync(GameEngine.PlayerSocketIds[i], teamIdMessage);

                }
            }
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
