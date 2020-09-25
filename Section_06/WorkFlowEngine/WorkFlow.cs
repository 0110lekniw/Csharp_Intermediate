using System;
using System.Collections.Generic;

namespace WorkFlowEngine
{
    public class WorkFlow
    {
        private readonly IList<IActivities> _activities;

        public WorkFlow()
        {
            _activities = new List<IActivities>();
        }

        public IList<IActivities> Activities()
        {
            if (_activities.Count <= 0)
                throw new InvalidOperationException("No activities reported");
            return _activities;
        }

        public void AddActivity(IActivities activity)
        {
            _activities.Add(activity);
        }

        public void RemoveActivity(IActivities activity)
        {
            _activities.Remove(activity);
        }
    }
}