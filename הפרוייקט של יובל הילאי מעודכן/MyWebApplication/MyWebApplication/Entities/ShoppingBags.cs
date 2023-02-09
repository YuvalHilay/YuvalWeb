using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;
using System.Drawing;


namespace MyWebApplication.Entities
{
    public class ShoppingBags
    {
        private int IdOrder;
        private int IdProduct;
        private int NumOFUnits;
        private decimal UnitPrice;

        public ShoppingBags()
        {
        }

        public int idOrder
        {
            get { return IdOrder; }
            set { IdOrder = value; }
        }

        public int idProduct
        {
            get { return IdProduct; }
            set { IdProduct = value; }
        }
        public int numOFUnits
        {
            get { return NumOFUnits; }
            set { NumOFUnits = value; }
        }
        public decimal unitPrice
        {
            get { return UnitPrice; }
            set { UnitPrice = value; }

        }
        public void Insert()
        {
            string strSQLName = "spNewSHproduct";
            ArrayList prmList = new ArrayList();

            prmList.Add(new OleDbParameter("@IdOrder", this.IdOrder));
            prmList.Add(new OleDbParameter("@IDProduct", this.IdProduct));
            prmList.Add(new OleDbParameter("@NumOfUnits", this.NumOFUnits));
            prmList.Add(new OleDbParameter("@UnitPrice", this.UnitPrice));
            ClassLibraryLibDoQuerise.DoQueries.ExecuteSPNonQuery(Connect.CONNECTION_STRING, strSQLName, prmList);
        }
        public DataTable GetDetails()
        {
            string strSqlName = "spViewOrders";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDOrder", this.idOrder));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return dt;
        }
    }
}