using System;
using System.Data;
using System.Web.UI.WebControls;

namespace MyWebApplication.PagesForVisitors
{
    public partial class wfCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cart"] == null)
            {
                lblMsg.Text = "Your Cart Is Empty";
                btnOrder.Enabled = false;
            }
            else
                ViewCart();
        }

        protected void ViewCart()
        {
            //חשיפת העגלה 
            DataTable cartTable = (DataTable)Session["Cart"];

            //  הצמדת מקור הנתונים לגריד
            gvCart.DataSource = cartTable;

            // "שידוך" הנתונים למבנה הגריד
            gvCart.DataBind();

            // חישוב סכום העגלה: עלות פריט*מספר היחידות שהוזמנו
            decimal sum = 0;

            foreach (DataRow dr in cartTable.Rows)
                sum += decimal.Parse(dr["Price"].ToString()) * int.Parse(dr["NumOfUnits"].ToString());

            lblTotal.Text = sum.ToString();
        }




        protected void btnOrder_Click(object sender, EventArgs e)
        {
            if (Session["IDCLIENT"] != null)
                Response.Redirect("../PagesForClients/wfPayment.aspx");
            Response.Redirect("wfLogin.aspx");
        }

        protected void gvCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable cartTable = (DataTable)Session["Cart"];
            DataRow dr = cartTable.Rows[e.RowIndex];
            cartTable.Rows.Remove(dr);
            ViewCart();
        }

        protected void btnOrder_Click1(object sender, EventArgs e)
        {
            if (Session["IDCLIENT"] != null)
                Response.Redirect("../PagesForClients/wfPayment.aspx");
                Response.Redirect("wfLogin.aspx");
        }

        protected void LevelDiscount_Click(object sender, EventArgs e)
        {
            decimal discount = 0;
            Entities.Levels l = new Entities.Levels();

            int idClient = (int)(Session["IDCLIENT"]);
            Entities.Client c = new Entities.Client();
            c.IDClient = idClient;
            DataTable rt = c.GetDiscountByIdClient();
           DataTable cartTable = (DataTable)Session["Cart"];

            discount = Decimal.Parse(rt.Rows[0]["DiscountType"].ToString());
            //  הצמדת מקור הנתונים לגריד
            gvCart.DataSource = cartTable;

            // "שידוך" הנתונים למבנה הגריד
            gvCart.DataBind();
            decimal sum = 0;
            // חישוב סכום העגלה: עלות פריט*מספר היחידות שהוזמנו
            foreach (DataRow dr in cartTable.Rows)

            

            sum += (decimal.Parse(dr["Price"].ToString()) * discount) * int.Parse(dr["NumOfUnits"].ToString());

            lblTotal.Text = sum.ToString();

            if (Session["IDCLIENT"] == null)
        
            Response.Redirect("wfLogin.aspx");
        }
    }
}

