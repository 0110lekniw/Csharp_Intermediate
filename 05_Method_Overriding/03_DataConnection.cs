using System.Collections.Generic;
using System.Text;

namespace _05_Method_Overriding
{
    class _03_DataConnection
    {
        public static void Testing()
        {
            var dataBases = new List<DbConnection>
            {
                new OracleConnection(),
                new SqlConnection()
            };

            var conect = new Connection();

            conect.OpenConnection(dataBases);
            conect.CloseConnection(dataBases);
        }
    }
}
