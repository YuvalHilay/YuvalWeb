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
    public class Product
    {
        public Product()
        {
        }
        private int iDProduct;
        private int idPegi;
        private string Productname;
        private string Productdescription;
        private string Productimage;
        private decimal price;
        private int IdManufacturer;
        private string Manufauctername;
        private Image Manufaucterlogo;
        private string Catagoryname;
        private Image Catagorylogo;
        private int IdCategory;
        private bool active;
        private int IdRequirement;
        private string tag;


        public int IDProduct
        {
            get { return iDProduct; }
            set { iDProduct = value; }
        }
        public int IdPegi
        {
            get { return idPegi; }
            set { idPegi = value; }
        }
        public string ProductName
        {
            get { return Productname; }
            set { Productname = value; }
        }
        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }
        public string ProductDescription
        {
            get { return Productdescription; }
            set { Productdescription = value; }
        }
        public string ProductImage
        {
            get { return Productimage; }
            set { Productimage = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public int idManufacturer
        {
            get { return IdManufacturer; }
            set { IdManufacturer = value; }
        }
        public string ManufaucterName
        {
            get { return Manufauctername; }
            set { Manufauctername = value; }
        }
        public Image ManufaucterLogo
        {
            get { return Manufaucterlogo; }
            set { Manufaucterlogo = value; }
        }
        public string CatagoryName
        {
            get { return Catagoryname; }
            set { Catagoryname = value; }
        }

        public Image CatagoryLogo
        {
            get { return Catagorylogo; }
            set { Catagorylogo = value; }
        }
        public int idCategory
        {
            get { return IdCategory; }
            set { IdCategory = value; }
        }
        public int idRequirement
        {
            get { return IdRequirement; }
            set { IdRequirement = value; }
        }
      
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public void InsertProduct()
        {
            string strSQLName = "spNewProduct";
            ArrayList prmList = new ArrayList();

            prmList.Add(new OleDbParameter("@ProductName", this.ProductName));
            prmList.Add(new OleDbParameter("@ProductDescription", this.ProductDescription));
            prmList.Add(new OleDbParameter("@ProductImage", this.ProductImage));
            prmList.Add(new OleDbParameter("@Price", this.Price));
            prmList.Add(new OleDbParameter("@IdCategory", this.idCategory));
            prmList.Add(new OleDbParameter("@IdManufacturer", this.idManufacturer));
            prmList.Add(new OleDbParameter("@Active", this.active));
            prmList.Add(new OleDbParameter("@IdRequirement", this.idRequirement));
            prmList.Add(new OleDbParameter("@IdPegi", this.idPegi));
            ClassLibraryLibDoQuerise.DoQueries.ExecuteSPNonQuery(Connect.CONNECTION_STRING, strSQLName, prmList);
        }
                public DataTable GetReqDetails()
        {
            string strSqlName = "spGetReqDetailsByIDProduct";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDProduct", this.iDProduct));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return dt;
        }
                public DataTable GetDetailsByName()
                {
                    string strSqlName = "spPbyN";
                    ArrayList prmList = new ArrayList();
                    prmList.Add(new OleDbParameter("@ProductName", this.iDProduct));
                    DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
                    return dt;
                }

                        public DataTable GetPegiImage()
        {
            string strSqlName = "spGetPegiImageByIdProduct";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDProduct", this.iDProduct));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return dt;
        }
        
       
        public void Update()
        {
            string strSQLName = "spUpdateProduct";
            ArrayList prmList = new ArrayList();

            prmList.Add(new OleDbParameter("@ProductName", this.ProductName));
            prmList.Add(new OleDbParameter("@ProductDescription", this.ProductDescription));
            prmList.Add(new OleDbParameter("@ProductImage", this.ProductImage));
            prmList.Add(new OleDbParameter("@Price", this.Price));
            prmList.Add(new OleDbParameter("@IdCategory", this.idCategory));
            prmList.Add(new OleDbParameter("@IdManufacturer", this.idManufacturer));
            prmList.Add(new OleDbParameter("@Active", this.active));
            prmList.Add(new OleDbParameter("@IDProduct", this.iDProduct));
            prmList.Add(new OleDbParameter("@IdRequirement", this.idRequirement));
            prmList.Add(new OleDbParameter("@IdPegi", this.idPegi));
            ClassLibraryLibDoQuerise.DoQueries.ExecuteSPNonQuery(Connect.CONNECTION_STRING, strSQLName, prmList);
        }

        public DataTable GetDetails()
        {

            string strSQlName = "spGetProductByIdProduct";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDProduct", this.iDProduct));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSQlName, prmList);
            return dt;
        }


        public static DataTable GetCatalog()
        {
            string strSqlName = "spViewActiveProducts";
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName);
            return dt;
        }

        public static DataTable GetAllCatalog()
        {
            string strSqlName = "spAllProduct";
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName);
            return dt;
        }

        public static DataTable GetProductList()
        {
            string strSqlName = "spViewProduct";
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName);
            return dt;
        }
        public static DataTable GetProductByCategory(int idCategory)
        {
            string strSqlName = "spViewProductByCategory";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IdCategory", idCategory));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return dt;
        }
        public static DataTable GetProductByManufacturer(int idManufacturer)
        {
            string strSqlName = "spProductByManufacturer";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDManufacturer", idManufacturer));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return dt;
        }
        public void UpdatePrice()
        {
            string strSQLName = "spUpdateProductPrice";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@Price", this.Price));
            prmList.Add(new OleDbParameter("@IDProduct", this.iDProduct));
            ClassLibraryLibDoQuerise.DoQueries.ExecuteSPNonQuery(Connect.CONNECTION_STRING, strSQLName, prmList);
        }

        public DataTable GetProductsByTag()
        {
            string strSqlName = "spProductsByTag";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@Tag", this.tag));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return dt;
        }

        public DataTable GetTagsByProduct()
        {
            string strSqlName = "spGetTagsByProduct";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDProduct", this.iDProduct));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return dt;
        }

    }
}