using System.Diagnostics;

namespace WorkFlowEngine
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //creating workFlow order
            var workFlow = new WorkFlow();
            workFlow.AddActivity(new DbMigrator());
            workFlow.AddActivity(new CustomerNotification());
            workFlow.AddActivity(new DataSender());
            workFlow.AddActivity(new DataReceiver());

            var workFlowEngine = new WorkFlowEngine(workFlow);
            workFlowEngine.Run();

            workFlow.RemoveActivity(new DataSender());
            var workFlowEngine2 = new WorkFlowEngine(workFlow);
            workFlowEngine2.Run();

        }
    }
}


