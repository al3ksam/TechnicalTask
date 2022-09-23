using System;
using System.Data.SqlClient;

namespace Solutions.Data
{
    /// <summary>
    ///     Представляет механизм работы с базой данных MS SQL Server 
    ///     с явно заданной таблицей. Этот класс не наследуется.
    /// </summary>
    public sealed partial class Database : IDatabase, IDisposable
    {
        /// <summary>
        ///     Настройки соединения (имя сервера, имя пользователя и его пароль, метод аутентификации)
        /// </summary>
        public ConnectionSettings Settings { get; set; }

        /// <summary>
        ///     Отображает состояние подключения к базе данных.
        /// </summary>
        /// <returns>
        ///     Возвращает значение True в случае успешного соединения с базой данных,
        ///     False - в противном случае.
        /// </returns>
        public bool IsConnected
        {
            get
            {
                // Синхронизируем доступ к объекту SqlConnection между потоками
                lock (_sqlConnection)
                {
                    return _sqlConnection.State == System.Data.ConnectionState.Open;
                }
            }
        }

        /// <summary>
        ///     Открывает соединение с базой данных, используя проверку подлинности
        ///     пользователя Windows или SQL Server (логин и пароль).
        /// </summary>
        /// <exception cref="SqlException">
        ///     При открытии подключения произошла ошибка на уровне подключения.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     Исключение, которое выдается при вызове метода, 
        ///     недопустимого для текущего объекта.
        /// </exception>
        public void Connect()
        {
            // Если уже подключены, выходим из метода
            if (IsConnected) return;

            // Синхронизируем доступ к объекту SqlConnection между потоками
            lock (_sqlConnection)
            {

                _sqlConnection.ConnectionString = $@"Data Source ='{Settings.ServerName}';Timeout=5;";

                // Подключение через пользователя Windows
                if (Settings.AuthMethod == AuthentificationMethod.Windows)
                {
                    _sqlConnection.ConnectionString += @"Integrated Security=True;";
                }
                // Подключение через пользователя SQL Server
                else
                {
                    _sqlConnection.ConnectionString +=
                        $@"Integrated Security=false;User ID='{Settings.UserId}';Password='{Settings.UserPassword}';";
                }                    

                _sqlConnection.Open();

                // TODO:
                Console.WriteLine(_sqlConnection.ConnectionString);
            }
        }

        /// <summary>
        ///     Закрывает соединение с базой данных
        /// </summary>
        /// <exception cref="SqlException">
        ///     При открытии подключения произошла ошибка на уровне подключения.
        /// </exception>
        public void Disconnect()
        {
            // Если подключены, закрываем соединение
            if (IsConnected)
            {
                // Синхронизируем доступ к объекту SqlConnection между потоками
                lock (_sqlConnection)
                {
                    _sqlConnection.Close();
                }
            }
        }

        /// <summary>
        ///     Освобождает все неуправляемые ресурсы
        /// </summary>
        public void Dispose()
        {
            // Синхронизируем доступ к объекту SqlConnection между потоками
            lock (_sqlConnection)
            {
                _sqlConnection.Dispose(); // Освобождаем ресурсы
            }
        }
    }
}
