namespace SignalR
{
    public interface IChatClient
    {
        Task ReceiveMessage(string message);
    }
}
