using System;

namespace _05_Method_Overriding
{
    public class DbCommand
    {

        private readonly string _instruction;

        private readonly DbConnection _dbConnection;
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            _dbConnection = dbConnection;

            if (string.IsNullOrEmpty(instruction))
                throw new ArgumentException("Instruction cannot be Null or empty");
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.UseConnection();

            Console.WriteLine("Executing Instructions");
            Console.WriteLine(_instruction);

            _dbConnection.CloseConnection();
        }
    }
}
