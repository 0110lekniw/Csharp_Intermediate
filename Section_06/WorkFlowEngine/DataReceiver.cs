using System;

namespace WorkFlowEngine
{
    public class DataReceiver : IActivities
    {
        public void Execute(Activity activity)
        {
            Console.WriteLine("Data successfully processed");
        }
    }
}