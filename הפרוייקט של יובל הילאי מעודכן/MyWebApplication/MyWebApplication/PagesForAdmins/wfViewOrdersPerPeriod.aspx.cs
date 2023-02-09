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
    public partial class wfViewOrdersPerPeriod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

               if (Session["IDADMIN"] == null)
            {
                Response.Redirect("../PagesForVisitors/wfLogin.aspx");
            }
                if (!IsPostBack)
                {
                    cld1.SelectedDate = DateTime.Today;
                    cld2.SelectedDate = DateTime.Today.AddDays(7);
                    ViewOrders();
                }
        }

        protected void btnBetweenDates_Click(object sender, EventArgs e)
        {
            ViewOrders();
        }

        protected void ViewOrders()
        {

            Entities.Order o = new Entities.Order();

            DataTable dt = o.GetOrdersBetweenDates(cld1.SelectedDate, cld2.SelectedDate);
        	gvBetweenOrders.DataSource = dt;
        	gvBetweenOrders.DataBind();
      
           lblMsg.Text = "";
         }
}
    }
