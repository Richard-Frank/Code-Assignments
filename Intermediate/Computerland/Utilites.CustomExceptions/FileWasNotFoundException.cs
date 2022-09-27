using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilites.CustomExceptions
{
    //FileWasNotFoundException is inheriting from Exception. 
    //Thus becoming a custom Exception.
    public class FileWasNotFoundException : Exception
    {

        //Default constructor, with default error message.
        public FileWasNotFoundException() : base("File dosn't exist dummy...")
        {

        }


        //This is a custom Constructor.
        public FileWasNotFoundException(string message) : base(message)
        {
            //Do Nothing
        }

    }
}
