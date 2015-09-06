using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions_task1
{
    public class Worker
    {
        private const uint MinYear = 1920;

        private string _name;
        private string _position;
        private uint _jobPlacementYear;
        private static readonly uint _maxYear = (uint)DateTime.Now.Year;

        public Worker(string name, string position, uint jobPlacementYear)
        {
            _name = name;
            _position = position;

            if (jobPlacementYear < MinYear || jobPlacementYear > _maxYear)
            {
                throw new WrongYearFormatException(String.Format("Year can not be less then {0} and more then {1}", MinYear, _maxYear));
            }
            else
            {
                _jobPlacementYear = jobPlacementYear;
            }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Position
        {
            get { return _position; }
        }

        public uint JobPlacementYear
        {
            get { return _jobPlacementYear; }
        }
    }
}
