using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computerland.BL
{
    public class CHuman
    {
        // Ctrl+R+E to refactor.

        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }


        private string firstname;
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Fullname
        {
            get { return firstname + " " + lastname; }
        }

        public void Breath()
        {

        }
    }
}
