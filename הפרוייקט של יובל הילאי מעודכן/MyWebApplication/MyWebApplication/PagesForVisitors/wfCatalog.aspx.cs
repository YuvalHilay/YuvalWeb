using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;

namespace MyWebApplication.PagesForVisitors
{
    public partial class wfCatalog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView2.Visible = false;
                GridView1.Visible = true;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView1.SelectedDataKey == null) return;
            int IDProduct = int.Parse(GridView1.SelectedDataKey.Value.ToString());
            Response.Redirect("wfProductPage.aspx?IDPRODUCT=" + IDProduct);
        }

        protected void ImageSearch_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            GridView2.Visible = true;
            GridView1.Visible = false;
            string ProductName = txtSearch.Text;
            string filter = "";

            if (ProductName != "")
            {
                filter = filter + "ProductName like '%" + ProductName + "%' and ";
            }
            if (ProductName == "")
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Please type your product";
                GridView2.Visible = false;
            }
            if (filter.Length > 0)
            {

                string finalFilter = filter.Remove(filter.Length - 4, 3);
                SqlDataSource3.FilterExpression = finalFilter;

            }
            else
            {

                GridView2.DataBind();
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView2.SelectedDataKey == null) return;
            int IDProduct = int.Parse(GridView2.SelectedDataKey.Value.ToString());
            Response.Redirect("wfProductPage.aspx?IDPRODUCT=" + IDProduct);
        }












    }
}