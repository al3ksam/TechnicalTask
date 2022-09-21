namespace Solutions
{
    public interface IDatabase
    {
        bool IsConnected { get; }
        void Connect();
        void Disconnect();
    }
}
