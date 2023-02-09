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
    public partial class wfOrdersByDeliveryStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopOrders(0);
        }

        // Pop = populate
        private void PopOrders(int idStatus)
        {
           
            Entities.Order o = new Entities.Order();

            DataTable dt = null;

     
            if (idStatus == 0) //כל ההזמנות
            {

             
               dt = o.GetOrdersList();
            }
            else
                if (idStatus == -1) //הזמנות ללא משלוח
                {
                    Entities.Order oR = new Entities.Order();
                    oR.idDelivery = idStatus;
                    dt = oR.GetOrdersByDeliveryStatus(true);
                }
                else
                    if (idStatus == 1) //הזמנות במשלוח
                    {
                        Entities.Order oRd = new Entities.Order();
                        oRd.idDelivery = -1;
                        dt = oRd.GetOrdersByDeliveryStatus(false);
                    }

            gvOrders.DataSource = dt;
            gvOrders.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopOrders(int.Parse(ddlStatus.SelectedValue));
        }

        protected void gvOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idOrder = int.Parse(gvOrders.SelectedDataKey.Value.ToString());
            Response.Redirect("../PagesForClients/wfOrderDetails.aspx?IDORDER=" + idOrder);
        }
    }
}