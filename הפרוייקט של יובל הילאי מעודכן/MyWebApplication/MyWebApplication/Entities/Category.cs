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
    public class Category
    {
        private int idCategory;
        private string CategoryName;
        private Image Catagorylogo;

        public int IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }

        public string categoryName
        {
            get { return CategoryName; }
            set { CategoryName = value; }
        }
        public Image CatagoryLogo
        {
            get { return Catagorylogo; }
            set { Catagorylogo = value; }
        }

        public static DataTable GetCategories()
        {
            string strSQLName = "spViewCategories";
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSQLName);
            return dt;
        }

    }
}