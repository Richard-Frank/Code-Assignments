using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork.BusinessLayer1
{
    public class CStudentList
    {
        //List defaults to private.
        List<CStudent> oStudents;

        public List<CStudent> Students
        {
            get { return oStudents; }
            set { oStudents = value; }
        }

        //Default Constructor
        public CStudentList()
        {
            oStudents = new List<CStudent>();
        }

        public int Count
        {
            get { return oStudents.Count; }
        }

        public CStudent this[int index]
        {
            get { return oStudents[index]; }
        }

        public void Sort()
        {

        }

        public void Add(CStudent oStudent)
        {
            oStudents.Add(oStudent);
        }

        public void Remove(CStudent oStudent)
        {
            oStudents.Remove(oStudent);
        }

    }
}
