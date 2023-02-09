using ClassLibraryLibDoQuerise;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;


namespace CreditCardWS
{
    public class Card
    {
    
            private string cardNum;
            private int idCompany;
            private int expireMonth;
            private int expireYear;
            private bool isLock;
            private string tz;

            public Card()
            {
            }
            public string CardNum
            {
                get { return cardNum; }
                set { cardNum = value; }
            }

            public int IdCompany
            {
                get { return idCompany; }
                set { idCompany = value; }
            }
            public int ExpireMonth
            {
                get { return expireMonth; }
                set { expireMonth = value; }
            }
            public int ExpireYear
            {
                get { return expireYear; }
                set { expireYear = value; }
            }
            public bool IsLock
            {
                get { return isLock; }
                set { isLock = value; }
            }
            public string TZ
            {
                get { return tz; }
                set { tz = value; }
            }
            public static DataTable GetCompanies()
            {
                string strSqlName = "spViewCompanies";
                DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName);
                return dt;
            }

            public bool IsValid()
            {
                string strSqlName = "spViewVaildCard";
                ArrayList prmList = new ArrayList();
                prmList.Add(new OleDbParameter("@CardNum", this.cardNum));
                prmList.Add(new OleDbParameter("@IdCompany", this.IdCompany));
                prmList.Add(new OleDbParameter("@ExpireMonth", this.expireMonth));
                prmList.Add(new OleDbParameter("@ExpireYear", this.expireYear));
                prmList.Add(new OleDbParameter("@TZ", this.tz));
                DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
                return dt.Rows.Count > 0;
            }
        }
    }
