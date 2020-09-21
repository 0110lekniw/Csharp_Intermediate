using System.Collections.Generic;

namespace _05_Method_Overriding
{
    public class Connection
    {
        public void OpenConnection(List<DbConnection> dataBases)
        {
            foreach(var dataBase in dataBases)
            {
                dataBase.OpenConnection();
            }

        }
        public void CloseConnection(List<DbConnection> dataBases)
        {
            foreach (var dataBase in dataBases)
            {
                dataBase.CloseConnection();
            }

        }
    }
}
