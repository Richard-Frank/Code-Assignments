using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.PL;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Data;
using System.Net.NetworkInformation;

namespace Banking.BL
{
    public class CCustomerList
    {

        List<CCustomer> oCustomers;

        public List<CCustomer> Customers
        {
            get { return oCustomers; }
            set { oCustomers = value; }
        }

        //Default Constructor
        public CCustomerList()
        {
            oCustomers = new List<CCustomer>();
        }

        public int Count
        {
            get { return oCustomers.Count; }
        }

        public CCustomer this[int index]
        {
            get { return oCustomers[index]; }
        }

        public void Sort()
        {

        }

        public void GetData()
        {
            try
            {
                CDatabase oDb = new CDatabase();

                DataTable oDataTable = new DataTable();

                oDataTable = oDb.GetData("SELECT * FROM tblCustomers");

                oCustomers = new List<CCustomer>();

                foreach (DataRow odr in oDataTable.Rows)
                {
                    CCustomer oCustomer = new CCustomer();
                    oCustomer.Id = Convert.ToInt32(odr["CustomerId"]);
                    oCustomer.Ssn = odr["Ssn"].ToString();
                    oCustomer.FirstName = odr["FirstName"].ToString();
                    oCustomer.LastName = odr["LastName"].ToString();
                    oCustomer.BirthDate = Convert.ToDateTime(odr["BirthDate"]);
                    oCustomer.GetDepositData();
                    oCustomer.GetWithdrawlData();

                    oCustomers.Add(oCustomer);
                }
                oDb = null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /* public void Populate()
         {//Populates a generic list of Customer objects.

             oCustomers = new List<CCustomer>();

             // Adds a new customer.
             CCustomer oC = new CCustomer();

             oC.Id = 1;
             oC.Ssn = "123-12-2134";
             oC.FirstName = "Barney";
             oC.LastName = "Fife";
             oC.CustomerId = 1;
             oC.BirthDate = Convert.ToDateTime("1957.3.28");
             oC.Age = DateTime.Today.Year - oC.BirthDate.Year;
             oC.GetDeposits();
             oC.GetWithdrawls();

             oCustomers.Add(oC);

             // Adds a new customer.
             oC = new CCustomer();
             oC.Id = 2;
             oC.Ssn = "524-33-8651";
             oC.FirstName = "Andy";
             oC.LastName = "Griffith";
             oC.CustomerId = 2;
             oC.BirthDate = Convert.ToDateTime("1948.7.11");
             oC.Age = DateTime.Today.Year - oC.BirthDate.Year;
             oC.GetDeposits();
             oC.GetWithdrawls();

             oCustomers.Add(oC);

             // Adds a new customer.
             oC = new CCustomer();
             oC.Id = 3;
             oC.Ssn = "734-78-8235";
             oC.FirstName = "Gomer";
             oC.LastName = "Pyle";
             oC.BirthDate = Convert.ToDateTime("1949.10.14");
             oC.Age = DateTime.Today.Year - oC.BirthDate.Year;
             oC.CustomerId = 3;
             oC.GetDeposits();
             oC.GetWithdrawls();

             oCustomers.Add(oC);

        
         }
         */

        public void Add(CCustomer oCustomer)
        {
            //Adds a customer to the list.
            oCustomers.Add(oCustomer);
        }

        public void Remove(CCustomer oCustomer)
        {
            //Removes a customer from the list.
            oCustomers.Remove(oCustomer);
        }

        public void SaveAllXML()
        {
            try
            {
                CFileAcess oFileAcess = new CFileAcess("Customers.xml");

                oFileAcess.Delete();

                XmlSerializer oSerializer = new XmlSerializer(typeof(List<CCustomer>));
                TextWriter otw = new StreamWriter("Customers.xml");

                oSerializer.Serialize(otw, oCustomers);

                otw.Close();
                otw.Dispose();
                otw = null;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void LoadAllXML()
        {
            try
            {
                CFileAcess oFileAcess = new CFileAcess("Customers.xml");

                XmlSerializer oSerializer = new XmlSerializer(typeof(List<CCustomer>));
                TextReader otr = new StreamReader("Customers.xml");

                oCustomers = (List<CCustomer>)oSerializer.Deserialize(otr);

                otr.Close();
                otr.Dispose();
                otr = null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int GetID()
        {
            {
                // If there are no customers in the list, ID is set to 1.
                if (oCustomers.Count == 0)
                {
                    return 1;
                }
                else
                {
                    // Sets NewId to be larger than the highest current customer Id number
                    int NewId = oCustomers.Max(oC => oC.Id) + 1;

                    return NewId;
                }
            }

        }


        public bool PingServer(bool Result)
        {
            CDatabase oDatabase = new CDatabase();

            Result = oDatabase.PingDatabase();

            return Result;
        }
    }
}
