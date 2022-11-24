using System;
using System.Data.SqlClient;

namespace Solutions.Data
{
    /// <summary>
    /// Представляет механизм работы с базой данных MS SQL Server 
    /// с явно заданной таблицей. Этот класс не наследуется.
    /// </summary>
    public sealed partial class Database : IDisposable
    {
        /// <summary>
        /// Настройки соединения (имя сервера, имя пользователя и его пароль, метод аутентификации)
        /// </summary>
        public ConnectionSettings Settings { get; set; }

        /// <summary>
        /// Отображает состояние подключения к базе данных.
        /// </summary>
        /// <returns>
        /// Возвращает значение True в случае успешного соединения с базой данных,
        /// False - в противном случае.
        /// </returns>
        public bool IsConnected => sqlConnection.State == System.Data.ConnectionState.Open;

        /// <summary>
        /// Открывает соединение с базой данных, используя проверку подлинности
        /// пользователя Windows или SQL Server (логин и пароль).
        /// </summary>
        /// <exception cref="SqlException">
        /// При открытии подключения произошла ошибка на уровне подключения.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Исключение, которое выдается при вызове метода, 
        /// недопустимого для текущего объекта.
        /// </exception>
        public void Connect()
        {
            // Если нет объекта с настройками соединения или уже подключены, выходим из метода
            if (Settings == null || IsConnected) return;

            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                ConnectTimeout = 3,
                DataSource = Settings.ServerName
            };
            
            // Подключение через пользователя Windows
            if (Settings.AuthMethod == AuthentificationMethod.Windows)
            {
                sqlConnectionStringBuilder.IntegratedSecurity = true;
            }
            // Подключение через пользователя SQL Server
            else
            {
                sqlConnectionStringBuilder.IntegratedSecurity = false;
                sqlConnectionStringBuilder.UserID = Settings.UserId;
                sqlConnectionStringBuilder.Password = Settings.UserPassword;
            }

            sqlConnection.ConnectionString = sqlConnectionStringBuilder.ConnectionString;

            try
            {
                sqlConnection.Open(); // Открываем соединение
            }
            catch (Exception)
            {
                throw;
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
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Создает базу данных в MS SQL Server
        /// </summary>
        /// <returns></returns>
        public bool CreateDatabase()
        {
            // Если подключены, закрываем соединение
            if (IsConnected)
            {
                try
                {
                    //SqlCommand sqlCommandCreateDb = new SqlCommand(s_sqlStringCreateDb, _sqlConnection);
                    //sqlCommandCreateDb.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Освобождает все неуправляемые ресурсы
        /// </summary>
        public void Dispose()
        {
            // Очищаем ссылку на объект с настройками соединения
            Settings = null;
            sqlConnection.Dispose(); // Освобождаем ресурсы
        }
    }
}
