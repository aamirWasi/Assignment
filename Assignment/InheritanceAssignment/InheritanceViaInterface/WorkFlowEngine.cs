using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment.InheritanceViaInterface
{
    public class WorkFlowEngine
    {
        private List<IActivity> _activities;

        public WorkFlowEngine()
        {
            _activities = new List<IActivity>();
        }
        public void AddActivities(IActivity activity)
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
        
    }

}
