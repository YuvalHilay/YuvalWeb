using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;
using System.Data;

namespace MyWebApplication.Entities
{
    public class Order
    {
  
            private int IdOrder;
            private DateTime OrderDate;
            private int IdClient;
            private int IdAdmin;
            private int IdDeal;
            private int IdDelivery;
            private decimal TotalSum;

            public Order()
            {
            }

            public int idOrder
            {
                get { return IdOrder; }
                set { IdOrder = value; }
            }
            public DateTime orderDate
            {
                get { return OrderDate; }
                set { OrderDate = value; }
            }
            public int idClient
            {
                get { return IdClient; }
                set { IdClient = value; }
            }
            public int idAdmin
            {
                get { return IdAdmin; }
                set { IdAdmin = value; }
            }

            public int idDeal
            {
                get { return IdDeal; }
                set { IdDeal = value; }
            }
            public int idDelivery
            {
                get { return IdDelivery; }
                set { IdDelivery = value; }
            }
            public decimal totalsum
            {
                get { return TotalSum; }
                set { TotalSum = value; }
            }
            public int Insert()
            {
                string strSQLName = "spAddNewOrder";
                ArrayList prmList = new ArrayList();


               
                prmList.Add(new OleDbParameter("@IdClient", this.IdClient));
                
                prmList.Add(new OleDbParameter("@IdDeal", this.IdDeal));
                
                prmList.Add(new OleDbParameter("@TotalSum", this.TotalSum));
                ClassLibraryLibDoQuerise.DoQueries.ExecuteSPNonQuery(Connect.CONNECTION_STRING, strSQLName, prmList);
                return this.GetMaxIdOrder();
            }
            public DataTable UpdateIDOrderByIDDelivery()
            {
                string strSqlName = "spUpdateIDOrderByIDDelivery";
                ArrayList prmList = new ArrayList();
                prmList.Add(new OleDbParameter("@IDDelivery", this.IdDelivery));
                prmList.Add(new OleDbParameter("@IDOrder", this.idOrder));
                DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
                return dt;
            }
            private int GetMaxIdOrder()
            {

                string strSqlName = "spGetIdOrderByIdDeal";
                ArrayList prmList = new ArrayList();
                prmList.Add(new OleDbParameter("@IdDeal", this.IdDeal));
                DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
                if (dt.Rows.Count > 0)
                    return int.Parse(dt.Rows[0]["IdOrder"].ToString());
                else
                    return -1;
            }

            public DataTable GetDetails()
            {
                string strSqlName = "spViewOrderByIdOrder";
                ArrayList prmList = new ArrayList();
                prmList.Add(new OleDbParameter("@IDOrder", this.idOrder));
                DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
                return dt;
            }
            public DataTable GetOrdersList()
            {
                string strSqlName = "spViewOrdersList";
                DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName);
                return dt;
            }

            public DataTable GetOrdersBetweenDates(DateTime startDate, DateTime endDate)
            {
            string strSqlName = "spViewOrdersPerPeriod";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@StartDate", startDate));
            prmList.Add(new OleDbParameter("@EndDate", endDate));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return dt;
        }
            public DataTable GetOrdersByDeliveryStatus(bool isDelivered)
            {

                string strSqlName = "spGetOrdersByDeliveryStatus";
                if (isDelivered)
                {
                    strSqlName = "spGetOrdersByNotDelivery";
                }
                ArrayList prmList = new ArrayList();
                prmList.Add(new OleDbParameter("@IdDelivery", this.IdDelivery));
                DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
                return dt;
            }

            }

            }
        
    