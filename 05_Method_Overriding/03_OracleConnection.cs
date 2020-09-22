using System;

namespace _05_Method_Overriding
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection() : base() { }
        public OracleConnection(string connectionString) : base(connectionString) { }

        public override void CloseConnection()
        {
            Console.WriteLine("Close Oracle Connection: {0}", _connectionString);
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open Oracle Connection: {0}", _connectionString);
        }


    }
}
    