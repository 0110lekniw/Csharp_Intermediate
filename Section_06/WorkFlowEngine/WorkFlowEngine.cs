namespace WorkFlowEngine
{
    public class WorkFlowEngine
    {
        private readonly WorkFlow _workFlow;

        public WorkFlowEngine(WorkFlow workFlow)
        {
            _workFlow = workFlow;
        }

        public void Run()
        {
            foreach (var activity in _workFlow.Activities())
                activity.Execute(new Activity());
        }
    }
}