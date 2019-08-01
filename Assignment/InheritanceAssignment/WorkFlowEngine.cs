using System.Collections.Generic;

namespace InheritanceAssignment
{
    public class WorkFlowEngine
    {
        private List<WorkFlowEngine> _activities;

        public WorkFlowEngine()
        {
            _activities = new List<WorkFlowEngine>();
        }
        public void AddActivities(WorkFlowEngine activity)
        {
            _activities.Add(activity);
        }
        public void Run()
        {
            foreach (var act in _activities)
            {
                act.Execute();
            }
        }
        public virtual void Execute()
        {

        }
    }
}
