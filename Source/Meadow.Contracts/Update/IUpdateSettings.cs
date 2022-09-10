namespace Meadow.Update
{
    public interface IUpdateSettings
    {
        public bool Enabled { get; }
        public string UpdateServer { get; }
        public int UpdatePort { get; }
        public string ClientID { get; }
        public string RootTopic { get; }
        public int CloudConnectRetrySeconds { get; }
    }
}