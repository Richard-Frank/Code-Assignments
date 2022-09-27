using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.BL
{
    public class CDeposit
    {
        //Variables
        private int depositid;

        public int DepositId
        {
            get { return depositid; }
            set { depositid = value; }
        }

        private double depositamount;

        public double DepositAmount
        {
            get { return depositamount; }
            set { depositamount = value; }
        }

        private DateTime depositdate;

        public DateTime DepositDate
        {
            get { return depositdate; }
            set { depositdate = value; }
        }


        public CDeposit()
        {//Default Constructor

        }

        public CDeposit(int _depositid, double _depositamount, DateTime _depositdate)
        {//Custom Constructor

            depositid = _depositid;
            depositamount = _depositamount;
            depositdate = _depositdate;

        }
    }
}
