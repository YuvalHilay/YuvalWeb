using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;

namespace MyWebApplication
{
    public class Admin
    {
        private int idadmin;
        private string firstname;
        private string lastname;

        private string Username;
        private string password;
        private bool mainAdmin;

        public Admin()
        {
        }

        public int IDAdmin
        {
            get { return idadmin; }
            set { idadmin = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public bool MainAdmin
        {
            get { return mainAdmin; }
            set { mainAdmin = value; }
        }
    
        public string UserName
        {
            get { return Username; }
            set { Username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool ExistUserName()
        {
            string strSqlName = "spAdminExistByUsername";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@UserName", this.Username));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING,strSqlName, prmList);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }




    }
}