using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;
using System.Web.UI.WebControls;

namespace MyWebApplication.PagesForClients
{
    public partial class wfOrderList : System.Web.UI.Page
    {
        // my orders list
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewOrderList();

        }
        private void ViewOrderList()
        {
            Entities.Client c = new Entities.Client();
            
            int idClient = int.Parse(Session["IDCLIENT"].ToString());
           
            c.IDClient = idClient;
            DataTable dt = c.GetMyOrders();

            gvMyOrders.DataSource = dt;
            gvMyOrders.DataBind();
        }




        protected void gvMyOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idOrder = int.Parse(gvMyOrders.SelectedDataKey.Value.ToString());
            Response.Redirect("wfOrderDetails.aspx?IDORDER=" + idOrder);
        }


   
        }
    }
