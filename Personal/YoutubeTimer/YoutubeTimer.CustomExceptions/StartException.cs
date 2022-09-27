using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeTimer.CustomExceptions
{
    public class StartException : Exception
    {
        public StartException()
            : base("The clock is already running!")
        {

        }

        public StartException(string message)
            : base(message)
        {
            //Do Nothing
        }
    }
}
