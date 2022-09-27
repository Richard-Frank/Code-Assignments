using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.NetworkInformation;

namespace Banking.PL
{
    public class CDatabase
    {
        private string sCon = "Data Source=sd2rjgdf41.database.windows.net;Initial Catalog=Intermediate;User ID=FrankDB;Password=F55p08555";

        private SqlConnection oConn;

        public void Open()
        {
            try
            {
                if (oConn == null)
                    oConn = new SqlConnection();

                if (oConn.State != ConnectionState.Open)
                {
                    oConn.ConnectionString = sCon;
                    oConn.Open();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void Close()
        {
            try
            {
                if ((oConn != null) && (oConn.State == ConnectionState.Open))
                {
                    oConn.Close();
                    oConn.Dispose();
                    oConn = null;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insert(string sql)
        {
            try
            {
                Open();

                SqlCommand oCmd = new SqlCommand(sql, oConn);
                int iRows = oCmd.ExecuteNonQuery();
                Close();

                return (iRows == 0 ? false : true);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Delete(string sql)
        {
            try
            {
                Open();

                SqlCommand oCmd = new SqlCommand(sql, oConn);
                int iRows = oCmd.ExecuteNonQuery();
                Close();

                return iRows;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Update(string sql)
        {
            try
            {
                Open();

                SqlCommand oCmd = new SqlCommand(sql, oConn);
                int iRows = oCmd.ExecuteNonQuery();
                Close();

                return iRows;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable GetData(string sql)
        {
            try
            {
                Open();
                SqlCommand oCmd = new SqlCommand(sql, oConn);
                SqlDataAdapter oDa = new SqlDataAdapter(oCmd);
                DataTable oDT = new DataTable();

                // Get Data
                oDa.Fill(oDT);
                Close();
                return oDT;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
        public bool PingDatabase()
        {
            try
            {
                if (oConn == null)
                    oConn = new SqlConnection();

                if (oConn.State != ConnectionState.Open)
                {
                    oConn.ConnectionString = sCon;
                    oConn.Open();
                    return true;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
         
    }
}
