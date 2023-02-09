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
    public class Admin
    {
        private int iDAdmin;
        private string firstName;
        private string lastName;
        private string tz;
        private string userName;
        private string password;
        public bool mainAdmin;
        public Admin()
        {
        }
        public int IDAdmin
        {
            get { return iDAdmin; }
            set { iDAdmin = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string TZ
        {
            get { return tz; }
            set { tz = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool MainAdmin
        {
            get { return mainAdmin; }
            set { mainAdmin = value; }
        }
        public bool ExistUserName()
        {
            string strSqlName = "spAdminExistByUsername";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@Username", this.userName));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }


        public DataTable GetDetails()
        {
            string strSqlName = "spAdminDetailsByIdAdmin";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDAdmin", this.iDAdmin));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return dt;
        }
        public int ExistByUserNamePassword()
        {
            string strSqlName = "spAdminByPassWordUserName";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@UserName", this.UserName));
            prmList.Add(new OleDbParameter("@Password", this.Password));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            if (dt.Rows.Count > 0)
                return int.Parse(dt.Rows[0]["IDAdmin"].ToString());
            else
                return -1;
        }
 
        public bool ExistAnotherUserName()
        {
            string strSqlName = "spExistAnotherAdminByUserName";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@UserName", this.userName));
            prmList.Add(new OleDbParameter("@IDClient", this.iDAdmin));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public bool ExistAnotherTZ()
        {
            string strSqlName = "spExistAnotherAdminByTZ";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@TZ", this.tz));
            prmList.Add(new OleDbParameter("@IDClient", this.iDAdmin));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static DataTable AdminList()
        {
            string strSqlName = "spAdminList";
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName);
            return dt;
        }
        public void Update()
        {
            string strSQLName = "spAdminUpdate";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@FirstName", this.FirstName));
            prmList.Add(new OleDbParameter("@LastName", this.LastName));
            prmList.Add(new OleDbParameter("@TZ", this.TZ));
            prmList.Add(new OleDbParameter("@UserName", this.UserName));
            prmList.Add(new OleDbParameter("@Password", this.Password));
            prmList.Add(new OleDbParameter("@MainAdmin", this.MainAdmin));
            prmList.Add(new OleDbParameter("@IDAdmin", this.IDAdmin));
            ClassLibraryLibDoQuerise.DoQueries.ExecuteSPNonQuery(Connect.CONNECTION_STRING, strSQLName, prmList);
        }
        public bool IsMainAdmin()
        {
            string strSqlName = "spIsMainAdmin";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IDAdmin", this.iDAdmin));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return bool.Parse(dt.Rows[0]["MainAdmin"].ToString());
        }
    }
}