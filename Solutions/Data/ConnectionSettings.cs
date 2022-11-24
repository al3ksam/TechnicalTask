using System;

namespace Solutions.Data
{
    /// <summary>
    ///     Представляет настройки подключения к базе данных MS SQL Server
    /// </summary>
    public sealed class ConnectionSettings
    {
        private const byte MaxLengthServerName = 128; // Максимальная длина имени сервера
        private const byte MaxLengthUsername = 128; // Максимальная длина имени пользователя
        private const byte MaxLengthPassword = 128; // Максимальная длина пароля

        private string serverName; // Имя сервера
        private string userId; // Имя пользователя
        private string password; // Пароль пользователя

        /// <summary>
        /// Инициализирует новый экземпляр класса ConnectionSettings 
        /// с методом аутентификации Windows.
        /// </summary>
        /// <param name="servername">Имя сервера (не более 128 символов)</param>
        public ConnectionSettings(string servername)
            : this(servername, string.Empty, string.Empty, AuthentificationMethod.Windows) { }

        /// <summary>
        /// Инициализирует новый экземпляр класса ConnectionSettings 
        /// с методом аутентификации SQL Server.
        /// </summary>
        /// <param name="servername">Имя сервера (не более 128 символов)</param>
        /// <param name="userId">Имя пользователя (не более 128 символов)</param>
        /// <param name="password">Пароль пользователя (не более 128 символов)</param>
        public ConnectionSettings(string servername, string userId, string password)
            : this(servername, userId, password, AuthentificationMethod.SQLServer) { }

        private ConnectionSettings(string servername, string userId, string password, AuthentificationMethod authMethod)
        {
            ServerName = servername;
            UserId = userId;
            UserPassword = password;
            AuthMethod = authMethod;
        }

        /// <summary>
        /// Имя сервера
        /// </summary>
        public string ServerName
        {
            get => serverName;
            private set
            {
                CheckValidValue(value, MaxLengthServerName, "Server name");
                serverName = value;
            }
        }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string UserId
        {
            get => userId;
            private set
            {
                CheckValidValue(value, MaxLengthUsername, "Username");
                userId = value;
            }
        }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string UserPassword
        {
            get => password;
            private set
            {
                CheckValidValue(value, MaxLengthPassword, "User password");
                password = value;
            }
        }

        /// <summary>
        /// Метод аутентификации
        /// </summary>
        public AuthentificationMethod AuthMethod { get; }

        private static void CheckValidValue(string value, in int maxSize, string name)
        {
            if (value.Length > maxSize)
            {
                throw new ArgumentException($"{name} exceeds {maxSize} characters.");
            }
        }
    }
}
