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
    public class Manufacturers
    {
        private int IdManufacturer;
        private string ManufacturerName;
        private Image ManufacturerLogo;

        public Manufacturers()
        {
        }

        public int idManufacturer
        {
            get { return IdManufacturer; }
            set { IdManufacturer = value; }
        }
        public string manufacturerName
        {
            get { return ManufacturerName; }
            set { ManufacturerName = value; }
        }
        public Image manufacturerLogo
        {
            get { return ManufacturerLogo; }
            set { ManufacturerLogo = value; }
        }
        public static DataTable viewManufacturers()
        {
            string strSqlName = "spViewManufacturers";
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName);
            return dt;
        }
        public static DataTable GetManufacturerList()
        {
            string strSqlName = "spViewManufacturers";
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName);
            return dt;
        }
    }
}