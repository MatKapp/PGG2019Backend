using System;
using System.Collections.Generic;
using WindowsInput;

namespace GameEngine
{
    public class GameEngine
    {
        public readonly int PlayersNumber;
        public readonly int TeamsNumber;
        public bool GameStarted { get; set; }
        public string[] PlayerSocketIds { get; set; }
        private Dictionary<string, string> PlayerTeamRequest {get; set;}

        public GameEngine(int playersNumber)
        {
            PlayersNumber = playersNumber;
            TeamsNumber = PlayersNumber / 2;
            PlayerSocketIds = new string[PlayersNumber];
            PlayerTeamRequest = new Dictionary<string, string>();
        }

        public void AddPlayer(string socketId, string teamName)
        {

            if (PlayerTeamRequest.ContainsKey(teamName) 
                    && PlayerTeamRequest[teamName] != socketId)
            {
                for (int i = 0; i < TeamsNumber; i++)
                {
                    if (String.IsNullOrEmpty(PlayerSocketIds[2* i])
                            && String.IsNullOrEmpty(PlayerSocketIds[2 * i + 1]))
                    {
                        PlayerSocketIds[2 * i] = socketId;
                        PlayerSocketIds[2 * i + 1] = PlayerTeamRequest[teamName];
                        PlayerTeamRequest.Remove(teamName);

                        if (i == TeamsNumber -1)
                            GameStarted = true;
                    }
                }
            }
            else
            {
                PlayerTeamRequest.Add(teamName, socketId);
            }
        }

        public int FindPlayerId(string socketId)
        {
            for (int i = 0; i <= PlayerSocketIds.Length; i++)
            {
                if (PlayerSocketIds[i] == socketId)
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemovePlayer(string socketId)
        {
            int playerId = FindPlayerId(socketId);
            PlayerSocketIds[playerId] = String.Empty;
        }

        public void Move(string socketId, MoveDirection direction)
        {
            int playerId = FindPlayerId(socketId);
            var simulator = new InputSimulator();
            ClearKeysPressed(simulator, playerId);

            if (direction != MoveDirection.Forward)
            {
                var key = Globalnfo.PlayerKeyCodeMap[playerId][direction];
                simulator.Keyboard.KeyDown(key);
            }
        }

        private void ClearKeysPressed(InputSimulator simulator, int playerId)
        {
            var directions = Globalnfo.PlayerKeyCodeMap[playerId];

            foreach (var value in directions.Values)
            {
                simulator.Keyboard.KeyUp(value);
            }
        }
    }
}
