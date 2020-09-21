using System;

namespace _05_Method_Overriding
{
    public class OracleConnection : DbConnection
    {
        public override void CloseConnection()
        {
            Console.WriteLine("Close Oracle Connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open Oracle Connection");
        }
    }
}
