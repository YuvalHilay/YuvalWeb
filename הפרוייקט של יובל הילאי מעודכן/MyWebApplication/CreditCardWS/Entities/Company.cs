using ClassLibraryLibDoQuerise;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace CreditCardWS.Entities
{
    public class Company
    {
        private int idCompany;
        private string companyName;
        public int IdCompany
        {
            get { return idCompany; }
            set { idCompany = value; }
        }
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public Company()
        {

        }
        public static DataTable GetCompanies()
        {
            string strSqlName = "spViewCompanies";
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName);
            return dt;
        }

    }
}