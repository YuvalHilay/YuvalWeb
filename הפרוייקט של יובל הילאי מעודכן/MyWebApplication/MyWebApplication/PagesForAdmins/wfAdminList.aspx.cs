using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;
using System.Drawing;


namespace MyWebApplication.PagesForAdmins
{
    public partial class wfAdminList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        
            if (Session["IDADMIN"] == null)
            {
                Response.Redirect("../PagesForVisitors/wfLogin.aspx");
            }
            vAdminList();
        }
        private void vAdminList()
        {
           DataTable dt = Entities.Admin.AdminList();
           gvAdminList.DataSource = dt;
           gvAdminList.DataBind();
        }

   

        protected void gvAdminList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idAdmin = int.Parse(gvAdminList.SelectedDataKey.Value.ToString());
            Response.Redirect("wfAdminPage.aspx?IDADMIN=" + idAdmin);
        }

      }
    }
