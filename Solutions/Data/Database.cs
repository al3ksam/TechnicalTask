using System;
using System.Security;
using System.Data.SqlClient;
using Solutions.Components;

namespace Solutions.Data
{
    /// <summary>
    ///     Представляет механизм работы с базой данных MS SQL Server 
    ///     с явно заданной таблицей. Этот класс не наследуется.
    /// </summary>
    public sealed partial class Database : IDatabase, IDisposable
    {
        /// <summary>
        ///     Настройки соединения (имя сервера, ID пользователя и пароль)
        /// </summary>
        public ConnectionSettings ConnectionSettingsData { get; set; } = null;
        

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
                Console.WriteLine("IsConnected");
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
            // Если отсутствуют настройки соединения или уже подключены, выходим из метода
            if (ConnectionSettingsData == null || IsConnected) return; 

            // Синхронизируем доступ к объекту SqlConnection между потоками
            lock (_sqlConnection)
            {
                _sqlConnection.ConnectionString = $@"Data Source ='{ConnectionSettingsData.ServerName}';";

                _sqlConnection.ConnectionString += ConnectionSettingsData.UserId == null ?
                    @"Integrated Security=True;" // Подключение через пользователя Windows
                    :
                    // Подключение через пользователя SQL Server
                    $@"Integrated Security=false;User ID='{ConnectionSettingsData.UserId}';Password='{ConnectionSettingsData.UserPassword}';";

                //_sqlConnection.Open();
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
