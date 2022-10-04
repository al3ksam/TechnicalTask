using System;
using System.Data.SqlClient;

namespace Solutions.Data
{
    partial class Database
    {
        /// <summary>
        ///     Имя базы данных.
        /// </summary>
        private const string _dbName = "MudDbTest";

        /// <summary>
        ///     Объект класса Database с поддержкой отложенной инициализации.
        ///     Необходим для реализации паттерна Singleton.
        /// </summary>
        private static readonly Lazy<Database> _lazyDb =
            new Lazy<Database>(() => new Database());

        /// <summary>
        ///     Объект соединения с базой данных MS SQL Server.
        /// </summary>
        public SqlConnection _sqlConnection = new SqlConnection();

        /// <summary>
        ///     Закрытый конструктор для предотвращения создания объектов за пределами класса.
        /// </summary>
        private Database()
        {
        }

        /// <summary>
        ///     Возвращает объект типа Database для работы с базой данных MS SQL Server.
        /// </summary>
        /// <returns>
        ///     Объект типа Database
        /// </returns>
        public static Database GetInstance()
        {
            return _lazyDb.Value;
        }
    }
}