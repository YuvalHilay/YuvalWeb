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
    public partial class wfViewOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ViewOrderList();
        }

        private void ViewOrderList()
        {
        
                 Entities.Order o = new Entities.Order();
                DataTable dt = o.GetOrdersList();
                gvOrder.DataSource = dt; // מקור הנתונים של הגריד וויו הוא הטבלה
                gvOrder.DataBind(); // כריכת נתונים  = תיאום מספר שורות ועמודות בגריד וויו לפי טבלת הנתונים שהתקבלה
            
                lblMsg.Text = "";
            }
        }
    }