using MyWebApplication.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace MyWebApplication.PagesForVisitors
{
    public partial class wfProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["IDPRODUCT"] == null)
            {
                Response.Redirect("wfCatalog.aspx");
            }
            else
            {
                ViewProduct();
                ViewReqProduct();
                ViewPegiforProduct();
            }

        }
        private void ViewProduct()
        {
            int idProduct = int.Parse(Request.QueryString["IDPRODUCT"].ToString());
            Entities.Product p = new Entities.Product();
            p.IDProduct = idProduct;
            DataTable dt = p.GetDetails();
            ViewState["dtProduct"] = dt;
            gvProductDetails.DataSource = dt;
            gvProductDetails.DataBind();
        }
        private void ViewReqProduct()
        {
            int idProduct = int.Parse(Request.QueryString["IDPRODUCT"].ToString());
            Entities.Product p = new Entities.Product();
            p.IDProduct = idProduct;
            DataTable dt = p.GetReqDetails();
            txtReq.Text = dt.Rows[0]["RequirementDetails"].ToString();

        }

        private void ViewPegiforProduct()
        {
            int idProduct = int.Parse(Request.QueryString["IDPRODUCT"].ToString());
            Entities.Product p = new Entities.Product();
            p.IDProduct = idProduct;
            DataTable dt = p.GetPegiImage();
            imgPicture.ImageUrl = @"/Images/Pegis/"+ dt.Rows[0]["PegiImage"].ToString();
          
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            DataTable cartTable;
            if (Session["Cart"] == null)
                cartTable = CreateCart();
            else
                cartTable = (DataTable)Session["Cart"];
            DataTable dtProduct = (DataTable)ViewState["dtProduct"];
            int idProduct = int.Parse(Request.QueryString["IDPRODUCT"].ToString());
            if (!ExistInCart(idProduct, cartTable))
            {
                //Insert To Cart==> 1 row
                DataRow dr = cartTable.NewRow();
                dr["IDProduct"] = int.Parse(dtProduct.Rows[0]["IDProduct"].ToString());
                dr["Name"] = dtProduct.Rows[0]["ProductName"].ToString();
                dr["Price"] = Decimal.Parse(dtProduct.Rows[0]["Price"].ToString());
                dr["NumOfUnits"] = ddlNumUnits.SelectedValue;
                cartTable.Rows.Add(dr);
                Session["Cart"] = cartTable;
            }
            Response.Redirect("wfCatalog.aspx");


        }
        private DataTable CreateCart()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("IDProduct", typeof(int)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Price", typeof(Decimal)));
            dt.Columns.Add(new DataColumn("NumOfUnits", typeof(int)));
            return dt;
        }
        private bool ExistInCart(int idProduct, DataTable cartTable)
        {
            bool exist = false;
            foreach (DataRow dr in cartTable.Rows)
                if (int.Parse(dr["IDProduct"].ToString()) == idProduct)
                {
                    dr["NumOfUnits"] = (int)dr["NumOfUnits"] + int.Parse(ddlNumUnits.SelectedValue);
                    Session["Cart"] = cartTable;
                    exist = true;
                }
            return exist;
        }



    

   
    }
}

