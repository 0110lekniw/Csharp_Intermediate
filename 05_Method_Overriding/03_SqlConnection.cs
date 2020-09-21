using System;

namespace _05_Method_Overriding
{
    public class SqlConnection : DbConnection
    {

        public override void CloseConnection()
        {
            Console.WriteLine("Close Sql Connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open Sql Connection");
        }
    }
}
