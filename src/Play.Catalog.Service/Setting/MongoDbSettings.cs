namespace Play.Catalog.Service.Setting
{
    public class MongoDbSettings
    {
        public string Host { get; init; }
        public int Port { get; init; }

        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}
