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
    public class Requirements
    {


        private int IdRequirement;
        private string RequirementName;
        private string RequirementDetails;

        public Requirements()
        {
        }

        public int idRequirement
        {
            get { return IdRequirement; }
            set { IdRequirement = value; }
        }
        public string requirementName
        {
            get { return RequirementName; }
            set { RequirementName = value; }
        }
        public string requirementDetails
        {
            get { return RequirementDetails; }
            set { RequirementDetails = value; }
        }

        public static DataTable RequirementsList()
        {
            string strSqlName = "spViewRequirements";
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName);
            return dt;
        }
        /*
        public DataTable GetReqDetails()
        {
            string strSqlName = "spGetReqDetailsByIDProduct";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDProduct", this.requirementDetails));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return dt;
        }
         */

    }
}