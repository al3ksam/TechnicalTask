namespace Solutions
{
    /// <summary>
    ///     Представляет подключение к базе данных MS SQL Server.
    /// </summary>
    public interface IDatabase
    {
        /// <summary>
        ///     Отображает состояние подключения к базе данных.
        /// </summary>
        /// <returns>
        ///     Объект типа bool (System.Boolean)
        /// </returns>
        bool IsConnected { get; }
        /// <summary>
        ///     Открывает соединение с базой данных, используя проверку подлинности
        ///     пользователя Windows.
        /// </summary>
        void Connect(string serverName);
        /// <summary>
        ///     Открывает соединение с базой данных, используя проверку подлинности
        ///     пользователя SQL Server (логин и пароль).
        /// </summary>
        void Connect(string serverName, string userId, string password);
        /// <summary>
        ///     Закрывает соединение с базой данных.
        /// </summary>
        void Disconnect();
    }
}
