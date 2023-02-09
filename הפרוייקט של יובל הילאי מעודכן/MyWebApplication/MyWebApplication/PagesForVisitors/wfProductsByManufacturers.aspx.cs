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
    public partial class wfProductsByManufacturers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["IdManufacturer"] == null)
                Response.Redirect("wfManufacturers.aspx"); 
            ViewProduct();
           
        }
        private void ViewProduct()
        {
            int IdManufacturer = int.Parse(Request.QueryString["IdManufacturer"].ToString());
            DataTable dt = Entities.Product.GetProductByManufacturer(IdManufacturer);
            gvProductByManufacturer.DataSource = dt;
            gvProductByManufacturer.DataBind();
        }

        protected void gvProductByManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDProduct = int.Parse(gvProductByManufacturer.SelectedDataKey.Value.ToString());
            Response.Redirect("wfProductPage.aspx?IDPRODUCT=" + IDProduct);
        }
        }

    }
