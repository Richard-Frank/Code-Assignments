using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computerland.BL
{
    public class CSoftware
    {
        // Ctrl+R+E to refactor.

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public CSoftware()
        {
            //Default constructor.
        }

        public CSoftware(int _id, string _description)
        {
            //Custom constructor.

            id = _id;
            description = _description;
        }
    }
}
