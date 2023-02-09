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
    public partial class wfProductsByCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["IDCATEGORY"] == null)
                Response.Redirect("Categories.aspx");
            else
                ViewProductsByCategories();
        }
        private void ViewProductsByCategories()
        {
            int idCategory = int.Parse(Request.QueryString["IDCATEGORY"].ToString());
            DataTable dt = Entities.Product.GetProductByCategory(idCategory);
            gvProductByCategories.DataSource = dt;
            gvProductByCategories.DataBind();

        }

        protected void gvProductByCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDProduct = int.Parse(gvProductByCategories.SelectedDataKey.Value.ToString());
            Response.Redirect("wfProductPage.aspx?IDPRODUCT=" + IDProduct);
        }


    }
}