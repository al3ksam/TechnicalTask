using System;
using System.Data.SqlClient;

namespace Solutions
{
    /// <summary>
    ///     Представляет механизм работы с базой данных MS SQL Server 
    ///     с явно заданной таблицей. Этот класс не наследуется.
    /// </summary>
    public sealed class Database : IDatabase, IDisposable
    {
        /// <summary>
        ///     Имя таблицы.
        /// </summary>
        private const string s_tableName = "MudDbTest";

        /// <summary>
        ///     Объект класса Database с поддержкой отложенной инициализации.
        ///     Необходим для реализации паттерна Singleton.
        /// </summary>
        private static readonly Lazy<Database> _lazyDb =
            new Lazy<Database>(() => new Database());

        /// <summary>
        ///     Объект соединения с базой данных MS SQL Server.
        /// </summary>
        private SqlConnection _sqlConnection = new SqlConnection();

        /// <summary>
        ///     Закрытый конструктор для предотвращения создания объектов за пределами класса.
        /// </summary>
        private Database()
        {
        }

        /// <summary>
        ///     Отображает состояние подключения к базе данных.
        /// </summary>
        /// <returns>
        ///     Возвращает True в случае успешного соединения с базой данных,
        ///     False - в противном случае.
        /// </returns>
        public bool IsConnected => _sqlConnection.State == System.Data.ConnectionState.Open;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Database GetInstance()
        {
            return _lazyDb.Value;
        }

        /// <summary>
        ///     Открывает соединение с базой данных, используя проверку подлинности
        ///     пользователя Windows.
        /// </summary>
        /// <param name="serverName">Имя сервера</param>
        /// <exception cref="SqlException">
        ///     При открытии подключения произошла ошибка на уровне подключения.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     Исключение, которое выдается при вызове метода, 
        ///     недопустимого для текущего объекта.
        /// </exception>
        public void Connect(string serverName)
        {
            if (IsConnected == false)
            {
                Connect(serverName, null, null);
            }
        }

        /// <summary>
        ///     Открывает соединение с базой данных, используя проверку подлинности
        ///     пользователя SQL Server (логин и пароль).
        /// </summary>
        /// <param name="serverName">Имя сервера</param>
        /// <param name="userId">Имя пользователя SQL-сервера</param>
        /// <param name="password">Пароль пользователя SQL-сервера</param>
        /// <exception cref="SqlException">
        ///     При открытии подключения произошла ошибка на уровне подключения.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     Исключение, которое выдается при вызове метода, 
        ///     недопустимого для текущего объекта.
        /// </exception>
        public void Connect(string serverName, string userId, string password)
        {
            if (IsConnected) return; // мы уже подключены


            if (userId == null) // подключение через пользователя Windows
            {
                _sqlConnection.ConnectionString = 
                    $@"Data Source={serverName};Initial Catalog={s_tableName};Integrated Security=True";
            }
            else // подключение через пользователя SQL Server
            {
                _sqlConnection.ConnectionString = 
                    $@"Data Source={serverName};Initial Catalog={s_tableName};Integrated Security=false;User ID='{userId}';Password='{password}'";
            }

            _sqlConnection.Open();
        }

        /// <summary>
        ///     Закрывает соединение с базой данных
        /// </summary>
        /// <exception cref="SqlException">
        ///     При открытии подключения произошла ошибка на уровне подключения.
        /// </exception>
        public void Disconnect()
        {
            if (IsConnected)
            {
                _sqlConnection.Close();
            }
        }

        /// <summary>
        ///     Освобождает все неуправляемые ресурсы
        /// </summary>
        public void Dispose()
        {
            _sqlConnection.Dispose();
        }
    }
}
