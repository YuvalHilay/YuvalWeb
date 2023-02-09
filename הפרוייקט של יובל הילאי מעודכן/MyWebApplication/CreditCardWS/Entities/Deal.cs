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
    public class Deal
    {
 
        
        private int idDeal;        
        private string cardNum;
        private DateTime dealDate;
        private decimal totalSum;
        private int idSite;
        
    
        public Deal()
        {
        }
        public int IdDeal
        {
            get { return idDeal; }
            set { idDeal = value; }
        }

        public string CardNum
        {
            get { return cardNum; }
            set { cardNum = value; }
        }

        public DateTime DealDate
        {
            get { return dealDate; }
            set { dealDate = value; }
        }
        public decimal TotalSum
        {
            get { return totalSum; }
            set { totalSum = value; }
        }
        public int IdSite
        {
            get { return idSite; }
            set { idSite = value; }
        }

        public int Insert()
        {
            string strSQLName = "spInsertDeal";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@CardNum", this.CardNum));
            prmList.Add(new OleDbParameter("@TotalSum", this.TotalSum));
            prmList.Add(new OleDbParameter("@IdSite", this.IdSite));
            ClassLibraryLibDoQuerise.DoQueries.ExecuteSPNonQuery(Connect.CONNECTION_STRING, strSQLName, prmList);
            return this.GetIdDeal();
        }

        private int GetIdDeal()
        {

            string strSqlName = "spGetMaxIdDeal";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IdSite", this.IdSite));
            prmList.Add(new OleDbParameter("@CardNum", this.CardNum));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            if (dt.Rows.Count > 0)
                return int.Parse(dt.Rows[0]["MaxIdDeal"].ToString());
            else
                return -1;
       
        }
    }
}