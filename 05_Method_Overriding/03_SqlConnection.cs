using System;

namespace _05_Method_Overriding
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection() : base() { }
        public SqlConnection(string connectionString) : base(connectionString) { }


        public override void CloseConnection()
        {
            Console.WriteLine("Close Sql Connection: {0}", _connectionString);
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open Sql Connection: {0}", _connectionString);
        }

    }
}
