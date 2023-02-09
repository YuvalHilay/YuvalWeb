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
    public partial class wfClientList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                      if (Session["IDADMIN"] == null)
            {
                Response.Redirect("../PagesForVisitors/wfLogin.aspx");
            }
            ClientList();
        }
        private void ClientList()
        {
            DataTable dt = Entities.Client.ClientList();
            gvClientList.DataSource = dt;
            gvClientList.DataBind();
        }

        protected void GvClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idClient = int.Parse(gvClientList.SelectedDataKey.Value.ToString());
            Response.Redirect("@/PagesForClients/wfClientDetails.aspx?IDCLIENT=" + idClient);
        }
    }
}

