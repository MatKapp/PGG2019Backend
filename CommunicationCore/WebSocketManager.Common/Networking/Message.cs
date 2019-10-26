﻿namespace WebSocketManager.Common
{
    public enum MessageType
    {        
        Connected,
        Joined,
        GameStarted,
        Name,
    }

    public class Message
    {
        public MessageType MessageType { get; set; }
        public string Data { get; set; }
    }
}