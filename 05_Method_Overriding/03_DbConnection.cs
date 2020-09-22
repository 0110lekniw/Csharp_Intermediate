using System;

namespace _05_Method_Overriding
{
    public abstract class DbConnection
    {

        public readonly TimeSpan _timeout = TimeSpan.FromMilliseconds(new Random().Next(3000));
        protected readonly string _connectionString;
        public DbConnection()
        {
            _connectionString = "Connection_Default";
        }

        public DbConnection(string connectionString)
            : this()
            
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Wrong value of the Connection String");
            _connectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public void UseConnection()
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();

            OpenConnection();

            timer.Stop();

            var elapsedTime = timer.Elapsed;

            if (elapsedTime > _timeout)
                throw new ArgumentException("Time Overlapsed");
            Console.WriteLine("Connection opened sucessfully. Time: {0}", elapsedTime);
        }
    }
}
