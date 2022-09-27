using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTimer.CustomExceptions
{
    public class StopException : Exception
    {

        public StopException() : base("The clock has already stopped!")
    {

    }

        public StopException(string message) : base(message)
    {
            //Do Nothing
    }


    }
}
