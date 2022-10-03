using System;

namespace Solutions.Data
{
    /// <summary>
    ///     Представляет настройки подключения к базе данных MS SQL Server
    /// </summary>
    public sealed class ConnectionSettings
    {
        private const byte _maxLengthServerName = 128; // Максимальная длина имени сервера
        private const byte _maxLengthUsername = 128; // Максимальная длина имени пользователя
        private const byte _maxLengthPassword = 128; // Максимальная длина пароля

        private string _serverName; // Имя сервера
        private string _userId; // Имя пользователя
        private string _password; // Пароль пользователя

        /// <summary>
        /// Инициализирует новый экземпляр класса ConnectionSettings 
        /// с методом аутентификации Windows.
        /// </summary>
        /// <param name="servername">Имя сервера (не более 128 символов)</param>
        public ConnectionSettings(string servername)
            : this(servername, null, null, AuthentificationMethod.Windows) { }

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
            get => _serverName;
            private set
            {
                if (value == null)
                {
                    _serverName = string.Empty;
                }
                else
                {
                    if (value.Length > _maxLengthServerName)
                    {
                        throw new ArgumentException($"Server name exceeds {_maxLengthServerName} characters.");
                    }

                    _serverName = value;
                }
            }
        }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string UserId
        {
            get => _userId;
            private set
            {
                if (value == null)
                {
                    _userId = string.Empty;
                }
                else
                {
                    if (value.Length > _maxLengthUsername)
                    {
                        throw new ArgumentException($"Username exceeds {_maxLengthUsername} characters.");
                    }

                    _userId = value;
                }
            }
        }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string UserPassword
        {
            get => _password;
            private set
            {
                if (value == null)
                {
                    _password = string.Empty;
                }
                else
                {
                    if (value.Length > _maxLengthPassword)
                    {
                        throw new ArgumentException($"User password exceeds {_maxLengthPassword} characters.");
                    }
                }

                _password = value;
            }
        }
        /// <summary>
        /// Метод аутентификации
        /// </summary>
        public AuthentificationMethod AuthMethod { get; }
    }
}
