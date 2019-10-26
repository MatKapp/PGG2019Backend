namespace WebSocketManager.Common
{
    public enum MessageType
    {
        GameStarted,
        Connected
    }

    public class Message
    {
        public MessageType MessageType { get; set; }
        public string Data { get; set; }
    }
}