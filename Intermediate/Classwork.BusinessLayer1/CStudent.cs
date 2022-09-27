using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork.BusinessLayer1
{

    //Remember to add 'public'
    public class CStudent
    {
        // Private fields
        private string firstname;
        private string lastname;
        private int id;

        //This is the default constructor.
        public CStudent()
        {

        }

        //You need to have a default constructor in order to create a custom constructor.
        //Remember this.

        //Custom Constructor.
        public CStudent(int _id, string _Firstname, string _Lastname)
        {
            id = _id;
            firstname = _Firstname;
            lastname = _Lastname;
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }


        // Create a calculated property
        public string Fullname
        {
            get { return firstname + " " + lastname; }
        }

        public void Study()
        {
            // Code this.


        }

        public void CalcArea(double sideA, double sideB, out double area)
        {
            area = .5 * sideA * sideB;

        }

        public bool Enroll(string name, out string message)
        {
            // Implement
            message = "here";
            return true;
        }
    }
}
