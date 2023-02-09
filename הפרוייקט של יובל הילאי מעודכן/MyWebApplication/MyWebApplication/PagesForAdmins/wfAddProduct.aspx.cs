using MyWebApplication.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;//עבור קלט פלט
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;



namespace MyWebApplication.PagesForAdmins
{
    public partial class wfAddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

         
            int idAdmin = int.Parse(Session["IDADMIN"].ToString());
            Entities.Admin a = new Entities.Admin();
            a.IDAdmin = idAdmin;
            DataTable dt = a.GetDetails();
            bool b = bool.Parse(dt.Rows[0]["MainAdmin"].ToString());
            if (!b)
                Response.Redirect("wfAdminDetails.aspx?NoMainAdmin=1");
                
            if (!IsPostBack)
            {
                FillDdlCategories();
                FillDdlManuFactureres();
                ProductImage.ImageUrl = @"../Images/Products/NoPic.png";
            }
        }
        
        private void FillDdlCategories()
        {
            DataTable dt = Category.GetCategories();
            ddlCategory.DataSource = dt;
            ddlCategory.DataTextField = "CategoryName";
            ddlCategory.DataValueField = "IdCategory";
            ddlCategory.DataBind();
            ddlCategory.SelectedIndex = 0;
        }
        private void FillDdlManuFactureres()
        {
            DataTable dt = Entities.Manufacturers.viewManufacturers();
            ddlManufacturers.DataSource = dt;
            ddlManufacturers.DataTextField = "ManufacturerName";
            ddlManufacturers.DataValueField = "IdManufacturer";
            ddlManufacturers.DataBind();
            ddlManufacturers.SelectedIndex = 0;
            

        }

       


        protected void btnInsert_Click1(object sender, EventArgs e)
        {
                        //Upload picture
            string fn = "noImage.png";
            string saveLocation;

            if (FileUpload1.PostedFile != null && FileUpload1.PostedFile.ContentLength != 0)
            {
                try
                {
                    fn = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    saveLocation = Server.MapPath(@"../Images/Products/") + fn;

                    FileUpload1.PostedFile.SaveAs(saveLocation);
                    ProductImage.ImageUrl = @"../Images/Products/" + fn;
                }
                catch (Exception ex)
                {
                    lblMsg.Text = "Error:" + ex.Message;
                }
            }
            
            Product p = new Product();
            p.ProductName = txtProductsName.Text;
            p.Price = decimal.Parse(txtPrice.Text);
            p.ProductImage = fn;
            p.ProductDescription = txtProductsDescription.Text;
            p.idCategory = int.Parse(ddlCategory.SelectedValue);
            p.idRequirement = int.Parse(txtIdRequirement.Text);
            p.IdPegi = int.Parse(txtIdPegi.Text);
            p.idManufacturer = int.Parse(ddlManufacturers.SelectedValue);
            p.Active = cbxActive.Checked;

            try   //--Add
            {
                p.InsertProduct();
                lblMsg.Text = "המוצר נוסף בהצלחה";
                btnInsert.Enabled = false;
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        protected void btnClear_Click1(object sender, EventArgs e)
        {
                    lblMsg.Text = "";
            txtProductsName.Text = "";
            txtPrice.Text = "";
            txtIdRequirement.Text = "";
            txtIdPegi.Text = "";
            txtProductsDescription.Text = "";
            ddlCategory.SelectedIndex = 0;
            ddlManufacturers.SelectedIndex = 0;
            ProductImage.ImageUrl = @"../Images/Products/noImage.png";
            btnInsert.Enabled = true;

        }

        }
    }
