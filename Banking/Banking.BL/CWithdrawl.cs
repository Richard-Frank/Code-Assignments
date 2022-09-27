using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.BL
{
    public class CWithdrawl
    {
        //Variables
        private int withdrawlid;

        public int WithdrawlId
        {
            get { return withdrawlid; }
            set { withdrawlid = value; }
        }

        private double withdrawlamount;

        public double WithdrawlAmount
        {
            get { return withdrawlamount; }
            set { withdrawlamount = value; }
        }

        private DateTime withdrawldate;

        public DateTime WithdrawlDate
        {
            get { return withdrawldate; }
            set { withdrawldate = value; }
        }


        public CWithdrawl()
        {//Default Constructor

        }

        public CWithdrawl(int _withdrawlid, double _withdrawlamount, DateTime _widrawldate)
        {//Custom Constructor

            withdrawlid = _withdrawlid;
            withdrawlamount = _withdrawlamount;
            withdrawldate = _widrawldate;

        }
    }
}
