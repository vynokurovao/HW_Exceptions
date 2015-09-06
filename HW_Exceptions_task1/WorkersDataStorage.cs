using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions_task1
{
    class WorkersDataStorage
    {
        private SortedSet<Worker> _workers = new SortedSet<Worker>(new WorkerNameComparer());

        public List<Worker> FindAllWhosExperienceIsBigger(uint experience)
        {
            int currentYear = DateTime.Now.Year;

            List<Worker> workers = new List<Worker>();
            foreach (Worker worker in _workers)
            {
                if ((currentYear - worker.JobPlacementYear) > experience)
                {
                    workers.Add(worker);
                }
            }
            return workers;
        }

        public void AddWorker(Worker worker)
        {
            _workers.Add(worker);
        }
    }
}
