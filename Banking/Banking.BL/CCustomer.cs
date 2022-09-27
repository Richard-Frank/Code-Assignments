using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.BL
{
    public class CCustomer : CPerson
    {
        //Variables
        private int customerid;

        public int CustomerId
        {
            get { return customerid; }
            set { customerid = value; }
        }

        private double lastdeopositamount;

        public double LastDeopositAmount
        {
            get { return lastdeopositamount; }
            set { lastdeopositamount = value; }
        }

        private DateTime lastdepositdate;

        public DateTime LastDepositDate
        {
            get { return lastdepositdate; }
            set { lastdepositdate = value; }
        }

        private double lastwithdrawlamount;

        public double LastWithdrawlAmount
        {
            get { return lastwithdrawlamount; }
            set { lastwithdrawlamount = value; }
        }

        private DateTime lastwithdrawldate;

        public DateTime LastWithdrawlDate
        {
            get { return lastwithdrawldate; }
            set { lastwithdrawldate = value; }
        }

        //Generic Lists
        private List<CDeposit> depositlist;

        public List<CDeposit> Depositlist
        {
            get { return depositlist; }
            set { depositlist = value; }
        }

        private List<CWithdrawl> withdrawllist;

        public List<CWithdrawl> Withdrawllist
        {
            get { return withdrawllist; }
            set { withdrawllist = value; }
        }


        //Methods
        public void GetDeposits()
        {
            //Populates a generic list of Deposit objects.
            switch(Id)
            { 
                case 1:
            depositlist = new List<CDeposit>();

            CDeposit oDep = new CDeposit();

            oDep.DepositAmount = 213.32;
            oDep.DepositDate = Convert.ToDateTime("1988.01.3");
            oDep.DepositId = 1;

            depositlist.Add(oDep);

            oDep = new CDeposit();
            oDep.DepositAmount = 113;
            oDep.DepositDate = Convert.ToDateTime("1988.02.4");
            oDep.DepositId = 2;

            depositlist.Add(oDep);

            oDep = new CDeposit();
            oDep.DepositAmount = 500.21;
            oDep.DepositDate = Convert.ToDateTime("1988.05.6");
            oDep.DepositId = 3;

            depositlist.Add(oDep);

            break;
                case 2:
            depositlist = new List<CDeposit>();

            oDep = new CDeposit();
            oDep.DepositAmount = 7500;
            oDep.DepositDate = Convert.ToDateTime("1988.01.1");
            oDep.DepositId = 1;

            depositlist.Add(oDep);

            oDep = new CDeposit();
            oDep.DepositAmount = 3000;
            oDep.DepositDate = Convert.ToDateTime("1988.02.1");
            oDep.DepositId = 2;

            depositlist.Add(oDep);

            oDep = new CDeposit();
            oDep.DepositAmount = 8000;
            oDep.DepositDate = Convert.ToDateTime("1988.03.1");
            oDep.DepositId = 3;

            depositlist.Add(oDep);

            break;

                case 3:
            depositlist = new List<CDeposit>();

            oDep = new CDeposit();
            oDep.DepositAmount = 90.11;
            oDep.DepositDate = Convert.ToDateTime("1988.06.25");
            oDep.DepositId = 1;

            depositlist.Add(oDep);

            oDep = new CDeposit();
            oDep.DepositAmount = 85.78;
            oDep.DepositDate = Convert.ToDateTime("1988.07.12");
            oDep.DepositId = 2;

            depositlist.Add(oDep);

            oDep = new CDeposit();
            oDep.DepositAmount = 54.33;
            oDep.DepositDate = Convert.ToDateTime("1988.07.30");
            oDep.DepositId = 3;

            depositlist.Add(oDep);

            break;
        }
        }

        public void GetWithdrawls()
        {
            //Populates a generic list of Withdrawl objects.
            switch (Id)
            {
                case 1:
                    withdrawllist = new List<CWithdrawl>();

                    CWithdrawl oWith = new CWithdrawl();

                    oWith.WithdrawlAmount = 30.55;
                    oWith.WithdrawlDate = Convert.ToDateTime("1989.01.03");
                    oWith.WithdrawlId = 1;

                    Withdrawllist.Add(oWith);

                    oWith = new CWithdrawl();
                    oWith.WithdrawlAmount = 50.33;
                    oWith.WithdrawlDate = Convert.ToDateTime("1989.6.7");
                    oWith.WithdrawlId = 2;

                    Withdrawllist.Add(oWith);

                    oWith = new CWithdrawl();
                    oWith.WithdrawlAmount = 45.23;
                    oWith.WithdrawlDate = Convert.ToDateTime("1989.8.18");
                    oWith.WithdrawlId = 3;

                    Withdrawllist.Add(oWith);

                    break;
                case 2:
                    Withdrawllist = new List<CWithdrawl>();

                    oWith = new CWithdrawl();
                    oWith.WithdrawlAmount = 3000.21;
                    oWith.WithdrawlDate = Convert.ToDateTime("2001.04.4");
                    oWith.WithdrawlId = 1;

                    Withdrawllist.Add(oWith);

                    oWith = new CWithdrawl();
                    oWith.WithdrawlAmount = 1000.87;
                    oWith.WithdrawlDate = Convert.ToDateTime("2001.07.30");
                    oWith.WithdrawlId = 2;

                    Withdrawllist.Add(oWith);

                    oWith = new CWithdrawl();
                    oWith.WithdrawlAmount = 5000.66;
                    oWith.WithdrawlDate = Convert.ToDateTime("2001.12.8");
                    oWith.WithdrawlId = 3;

                    Withdrawllist.Add(oWith);

                    break;

                case 3:
                    Withdrawllist = new List<CWithdrawl>();

                    oWith = new CWithdrawl();
                    oWith.WithdrawlAmount = 53.65;
                    oWith.WithdrawlDate = Convert.ToDateTime("1999.8.12");
                    oWith.WithdrawlId = 1;

                    Withdrawllist.Add(oWith);

                    oWith = new CWithdrawl();
                    oWith.WithdrawlAmount = 20.11;
                    oWith.WithdrawlDate = Convert.ToDateTime("2000.01.15");
                    oWith.WithdrawlId = 2;

                    Withdrawllist.Add(oWith);

                    oWith = new CWithdrawl();
                    oWith.WithdrawlAmount = 40.32;
                    oWith.WithdrawlDate = Convert.ToDateTime("2002.07.27");
                    oWith.WithdrawlId = 3;

                    Withdrawllist.Add(oWith);

                    break;
            }
        }
    }
}


