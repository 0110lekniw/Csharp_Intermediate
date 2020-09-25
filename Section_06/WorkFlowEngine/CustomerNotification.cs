using System;

namespace WorkFlowEngine
{
    public class CustomerNotification : IActivities
    {
        public void Execute(Activity activity)
        {
            Console.WriteLine("Data is being processed.");
        }
    }
}