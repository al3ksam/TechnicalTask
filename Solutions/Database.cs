using System;
using System.Data.SqlClient;

namespace Solutions
{
    internal sealed class Database : IDisposable, IDatabase
    {
        private static readonly Lazy<Database> _lazyDb =
            new Lazy<Database>(() => new Database());

        private AuthMethodEnum _authMethod = AuthMethodEnum.Windows;
        private SqlConnection _sqlConnection = new SqlConnection();

        private Database()
        {
        }

        public enum AuthMethodEnum : Byte
        {
            Windows = 1,
            SQL = 2
        }

        public bool IsConnected => _sqlConnection.State == System.Data.ConnectionState.Open;

        public static Database GetInstance()
        {
            return _lazyDb.Value;
        }

        public void Connect()
        {
            // SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NIGHT;Initial Catalog=MudDbTest;Integrated Security=True");
            //_sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NIGHT;Initial Catalog=MudDbTest;Integrated Security=false;User ID='sa';Password='0000'");

            Console.WriteLine(IsConnected);
            Dispose();

            //sqlConnection.Open();
            //Console.WriteLine(sqlConnection.State.ToString());
        }

        public void Disconnect()
        {

        }

        public void Dispose()
        {
            if (IsConnected)
            {
                _sqlConnection.Close();
            }

            _sqlConnection.Dispose();

            Console.WriteLine("Dispose()");
        }
    }
}
