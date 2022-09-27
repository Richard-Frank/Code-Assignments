using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.BL
{
    public class CPerson
    {
        //Variables
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string ssn;

        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }

        private string firstname;

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string lastname;

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        private int age;

        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - birthdate.Year;
                if (birthdate > today.AddYears(-age)) age--;
                return age; }
        }

        private DateTime birthdate;
        public DateTime BirthDate
        {
            get { return birthdate; }
            set { birthdate = value; }
            
        }

        public CPerson()
        {//Default Constructor

        }

        public CPerson(int _id, string _ssn, string _firstname, string _lastname, int _age, DateTime _birthdate)
        {//Custom Constructor
            id = _id;
            ssn = _ssn;
            firstname = _firstname;
            lastname = _lastname;
            age = _age;
            birthdate = _birthdate;
        }
    }
}
