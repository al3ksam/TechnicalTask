namespace Solutions.Data
{
    partial class Database
    {
        public readonly struct ConnectionSettings
        {
            public static readonly ConnectionSettings Empty;

            public ConnectionSettings(string servername) 
                : this(servername, null, null, AuthentificationMethod.Windows) { }

            public ConnectionSettings(string servername, string userId, string password)
                : this(servername, userId, password, AuthentificationMethod.SQLServer) { }

            private ConnectionSettings(string servername, string userId, string password, AuthentificationMethod authMethod)
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

            // Переопределение базовых методов
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
