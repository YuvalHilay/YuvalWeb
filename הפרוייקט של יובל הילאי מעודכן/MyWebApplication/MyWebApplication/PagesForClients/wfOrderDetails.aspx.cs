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
    public partial class wfOrderDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["IDORDER"] == null)
                Response.Redirect("wfMyOrders.aspx");
            
            ViewOrderDetails();
            ViewItemsInOrder();
            if (Session["IDADMIN"] != null)
                btnOrderDelivery.Visible = true;
           


        }
        private void ViewOrderDetails()
        {
            int idOrder = int.Parse(Request.QueryString["IDORDER"].ToString());
            Entities.Order order = new Entities.Order();
            order.idOrder = idOrder;
            DataTable dt = order.GetDetails();
            ViewState["dtOrder"] = dt;
            if (dt.Rows[0]["IdDelivery"].ToString() != "-1") //A request for a delivery was submitted
            {
                btnOrderDelivery.Enabled = false;
                int idDelivery = int.Parse(dt.Rows[0]["idDelivery"].ToString());
                ProxyDeliveries.Delivery d = new ProxyDeliveries.Delivery();
                d.IDDelivery = idDelivery;
                ProxyDeliveries.DeliveriesWS service = new ProxyDeliveries.DeliveriesWS();
                int status = service.GetDeliveryStatus(d);
                if (status == 1)
                    lblStatus.Text = "Request has been acknowledged";
                else if (status == 2)
                    lblStatus.Text = "Waiting for delivery";
                else if (status == 3)
                    lblStatus.Text = "Package has been collected by a delivery man";
                else if (status == 4)
                    lblStatus.Text = "Package has been given to the customer";
            }
            gvOrderDetails.DataSource = dt;
            gvOrderDetails.DataBind();
        }
        private void ViewItemsInOrder()
        {
            int idOrder = int.Parse(Request.QueryString["IDORDER"].ToString());
            Entities.ShoppingBags item = new Entities.ShoppingBags();
            item.idOrder = idOrder;
            DataTable dt = item.GetDetails();
            gvItemsInOrder.DataSource = dt;
            gvItemsInOrder.DataBind();

        }

        protected void btnOrderDelivery_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["dtOrder"];

            ProxyDeliveries.Delivery d = new ProxyDeliveries.Delivery();
            d.IDStore = 1;
            d.IDOrder = int.Parse(Request.QueryString["IDORDER"].ToString());
            d.CustName = dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString();
            d.CustPhone = dt.Rows[0]["MobilePhone"].ToString();
            d.CustAddress = dt.Rows[0]["Address"].ToString();

            ProxyDeliveries.DeliveriesWS service = new ProxyDeliveries.DeliveriesWS();
            int idDelivery = service.InsertDelivery(d);
            Entities.Order o = new Entities.Order();
            o.idOrder = int.Parse(Request.QueryString["IDORDER"].ToString());
            o.idDelivery = idDelivery;
            o.UpdateIDOrderByIDDelivery();
            Response.Redirect("../PagesForAdmins/wfOrdersByDeliveryStatus.aspx");
        }

   
    }
}

