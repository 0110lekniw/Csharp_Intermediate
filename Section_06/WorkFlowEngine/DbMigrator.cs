using System;

namespace WorkFlowEngine
{
    public class DbMigrator : IActivities
    {
        public void Execute(Activity activity)
        {
            Console.WriteLine("Connected to the server.");
        }
    }
}