namespace WebSocketManager.Common
{
    public enum MessageType
    {
        Text,
        MethodInvocation,
        ConnectionEvent,
        MethodReturnValue
    }

    public class Message
    {
        public string Data { get; set; }
    }
}