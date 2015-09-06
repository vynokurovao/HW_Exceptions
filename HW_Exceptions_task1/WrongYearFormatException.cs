using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions_task1
{
    class WrongYearFormatException : Exception
    {
        public WrongYearFormatException(string message) : base(message)
        {
            
        }
    }
}
