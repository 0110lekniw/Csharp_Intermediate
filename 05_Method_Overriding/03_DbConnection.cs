using System;

namespace _05_Method_Overriding
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        private readonly TimeSpan _timeout = TimeSpan.FromSeconds(30);
        public DbConnection()
        {
            ConnectionString = "Some Strings";
        }

        public DbConnection(string connectionString)
            : this()
            
        {
            if (connectionString == null)
                throw new ArgumentException("Wrong value of the Connection String");
            else if (ConnectionString.Length == 0)
                throw new ArgumentException("Connection String cannot be empty");
            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();

    }
}
