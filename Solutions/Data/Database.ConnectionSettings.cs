namespace Solutions.Data
{
    partial class Database
    {
        public readonly struct ConnectionSettings
        {
            public static readonly ConnectionSettings Empty;

            public ConnectionSettings(string servername, string userId, string password, AuthentificationMethod authMethod)
            {
                ServerName = servername;
                UserId = userId;
                UserPassword = password;
                AuthMethod = authMethod;
            }

            public string ServerName { get; }
            public string UserId { get; }
            public string UserPassword { get; }
            public AuthentificationMethod AuthMethod { get; }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return base.ToString();
            }

            // Операторы
            public static bool operator ==(ConnectionSettings left, ConnectionSettings right)
            {
                return left.Equals(right);
            }
            public static bool operator !=(ConnectionSettings left, ConnectionSettings right)
            {
                return !left.Equals(right);
            }
        }
    }
}
