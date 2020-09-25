using System;

namespace WorkFlowEngine
{
    public class DataSender : IActivities
    {
        public void Execute(Activity activity)
        {
            Console.WriteLine("Obtained data delivered.");
        }
    }
}