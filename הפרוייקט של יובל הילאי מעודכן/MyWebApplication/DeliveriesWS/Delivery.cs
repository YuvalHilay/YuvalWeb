using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;
using System.Drawing;



namespace DeliveriesWS
{
    
     public class Delivery
    {
        private int idDelivery;
        private int idStore;
        private int idOrder;
        private DateTime statusDate;
        private string custName;
        private string custAddress;
        private string custPhone;
        private int status;

        public Delivery()
        {
        }

        public int IDDelivery
        {
            get { return this.idDelivery; }
            set { this.idDelivery = value; }
        }

        public int IDStore
        {
            get { return this.idStore; }
            set { this.idStore = value; }
        }

        public int IDOrder
        {
            get { return this.idOrder; }
            set { this.idOrder = value; }
        }

        public DateTime StatusDate
        {
            get { return this.statusDate; }
            set { this.statusDate = value; }
        }

        //Customer Name
        public string CustName
        {
            get { return this.custName; }
            set { this.custName = value; }
        }

        //Customer Address
        public string CustAddress
        {
            get { return this.custAddress; }
            set { this.custAddress = value; }
        }

        //Customer Phone
        public string CustPhone
        {
            get { return this.custPhone; }
            set { this.custPhone = value; }
        }

        public int Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public int Insert()
        {
            // מוסיפה פרטי עסקה חדשה עפ"י קלט
            string strSQLName = "spInsertDelivery";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDStore", this.IDStore));
            prmList.Add(new OleDbParameter("@IDOrder", this.IDOrder));
            prmList.Add(new OleDbParameter("@CustName", this.CustName));
            prmList.Add(new OleDbParameter("@CustAddress", this.CustAddress));
            prmList.Add(new OleDbParameter("@CustPhone", this.CustPhone));
            ClassLibraryLibDoQuerise.DoQueries.ExecuteSPNonQuery(Connect.CONNECTION_STRING, strSQLName, prmList);
            
            return this.GetLastDelivery();
        }

        private int GetLastDelivery()
        {
            string strSqlName = "spGetLastIDDelivery";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDStore", this.IDStore));
            prmList.Add(new OleDbParameter("@IDOrder", this.IDOrder));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return int.Parse(dt.Rows[0]["IDDelivery"].ToString());
        }

        public int GetDeliveryStatus()
        {
            string strSqlName = "spGetDeliveryStatus";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDDelivery", this.IDDelivery));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return int.Parse(dt.Rows[0]["Status"].ToString());
        }

        public static DataTable GetStoreDeliveriesByStatus(int idStore, int status)
        {
            string strSqlName = "spGetStoreDeliveriesByStatus";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDStore", idStore));
            prmList.Add(new OleDbParameter("@Status", status));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return dt;
        }

        public DataTable UpdateDelivery()
        {
            string strSqlName = "spUpdateDelivery";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDDelivery", this.IDDelivery));
            prmList.Add(new OleDbParameter("@IDOrder", this.IDOrder));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return dt;
        }       
    }
}