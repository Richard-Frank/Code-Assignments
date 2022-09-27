using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computerland.Interfaces
{
    public interface IComputerType
    {
        // Property signatures.

        string ID { get; set; }
        string Description { get; set; }

        //Method Siganture
        void LoadAll();
        void SaveAll();
    }
}
