using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions_task1
{
    public class WorkerNameComparer : Comparer<Worker>
    {
        public override int Compare(Worker worker1, Worker worker2)
        {
            if (!worker1.Name.Equals(worker2.Name))
            {
                return worker1.Name.CompareTo(worker2.Name);
            }
            else if (!worker1.Position.Equals(worker2.Position))
            {
                return worker1.Position.CompareTo(worker2.Position);
            }
            else if (!worker1.JobPlacementYear.Equals(worker2.JobPlacementYear))
            {
                return worker1.JobPlacementYear.CompareTo(worker2.JobPlacementYear);
            }
            else
            {
                return worker1.GetHashCode().CompareTo(worker2.GetHashCode());
            }
        }
    }
}
