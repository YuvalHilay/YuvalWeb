using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;

namespace MyWebApplication.PagesForAdmins
{
    public partial class wfAdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["IDAdmin"] == null)
                Response.Redirect("wfAdminList.aspx");
            else
                ViewAdmin();
        }

        private void ViewAdmin()
        {
            int idAdmin = int.Parse(Request.QueryString["IDADMIN"].ToString());
            Entities.Admin a = new Entities.Admin();
            a.IDAdmin = idAdmin;
            DataTable dt = a.GetDetails();
            gvAdminPage.DataSource = dt;
            gvAdminPage.DataBind();


        }

      
    }
}