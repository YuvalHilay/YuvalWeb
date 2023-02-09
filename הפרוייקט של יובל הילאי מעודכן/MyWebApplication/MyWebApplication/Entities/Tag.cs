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
    public class Tag
    {
              private string tagName;

        //Constructor
        public Tag()
        {

        }

        //Properties

        public string TagName
        {
            get { return tagName; }
            set { tagName = value; }
        }

        public DataTable GetAllTags()
        {
            string strSqLName = "spGetAllTags";
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqLName);
            return dt;
        }
    }
}
           
