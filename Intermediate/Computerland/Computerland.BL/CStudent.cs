using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computerland.BL
{
    //CStudent is inheriting from the CHuman class.
    public class CStudent : CHuman
    {
        // Ctrl+R+E to refactor.

        private string program;

        public string Program
        {
            get { return program; }
            set { program = value; }
        }



        private double gpa;

        public double Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }


        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public void Study()
        {

        }
    }
}
