using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Method_Overriding
{
    class _04_Ex_2
    {
        public static void Test()
        {
            var orcCS = new OracleConnection();
            var dbOracleCommand = new DbCommand(orcCS, "asdasdasd");
            dbOracleCommand.Execute();

            var sqlCS = new SqlConnection();
            var dbSqlCommand = new DbCommand(sqlCS, "asdasda fasfasf");
            dbSqlCommand.Execute();

            Console.ReadLine();
        }
        
    }
}
