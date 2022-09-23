namespace Solutions.Data
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
        ///     Открывает соединение с базой данных
        /// </summary>
        void Connect();
        /// <summary>
        ///     Закрывает соединение с базой данных.
        /// </summary>
        void Disconnect();
    }
}
