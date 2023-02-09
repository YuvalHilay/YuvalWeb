using MyWebApplication.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace MyWebApplication.PagesForAdmins
{
    public partial class wfUpdateProduct : System.Web.UI.Page
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
                FillDdlManufacturers();
                ViewProduct();
            }
        }
        private void FillDdlManufacturers()
        {
            DataTable dt = Entities.Manufacturers.viewManufacturers();
            ddlManufacturer.DataSource = dt;
            ddlManufacturer.DataTextField = "ManufacturerName";
            ddlManufacturer.DataValueField = "IdManufacturer";
            ddlManufacturer.DataBind();
            ddlCategories.SelectedIndex = 0;
        }
        private void FillDdlCategories()
        {
            DataTable dt = Entities.Category.GetCategories();
            ddlCategories.DataSource = dt;
            ddlCategories.DataTextField = "CategoryName";
            ddlCategories.DataValueField = "IdCategory";
            ddlCategories.DataBind();
            ddlCategories.SelectedIndex = 0;
        }
        private void ViewProduct()
        {
            int idProduct = int.Parse(Request.QueryString["IDPRODUCT"].ToString());
            Entities.Product p = new Entities.Product();
            p.IDProduct = idProduct;
            DataTable dt = p.GetDetails();

            lblIdProduct.Text = idProduct.ToString();
            txtProductName.Text = dt.Rows[0]["ProductName"].ToString();
            txtDescription.Text = dt.Rows[0]["ProductDescription"].ToString();
            txtIdRequirement.Text = dt.Rows[0]["IdRequirement"].ToString();
            txtPegi.Text = dt.Rows[0]["IdPegi"].ToString();
            
            imgPicture.ImageUrl = @"/Images/Products/" + dt.Rows[0]["ProductImage"].ToString();
            ViewState["ImageName"] = dt.Rows[0]["ProductImage"].ToString();
            txtPrice.Text = dt.Rows[0]["Price"].ToString();
            ddlCategories.SelectedValue = dt.Rows[0]["IdCategory"].ToString();
            ddlManufacturer.SelectedValue = dt.Rows[0]["IdManufacturer"].ToString();
            cbxActive.Checked = bool.Parse(dt.Rows[0]["Active"].ToString());
        }

 

        protected void btnClear_Click1(object sender, EventArgs e)
        {
             ViewProduct();
        }

        protected void btnUpdate_Click1(object sender, EventArgs e)
        {
              //Upload picture
            string fn = ViewState["ImageName"].ToString();
            string saveLocation;

            if (FileUpload1.PostedFile != null && FileUpload1.PostedFile.ContentLength != 0)
            {
                try
                {
                    fn = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    saveLocation = Server.MapPath(@"../Images/Products/") + fn;

                    FileUpload1.PostedFile.SaveAs(saveLocation);
                    imgPicture.ImageUrl = @"../Images/Products/" + fn;
                }
                catch (Exception ex)
                {
                    lblMsg.Text = "Error:" + ex.Message;
                }
            }
            //יצירת אובייקט מוצר לצורך הפעלת פעולת עדכון
            Entities.Product p = new Entities.Product();
            p.IDProduct = int.Parse(lblIdProduct.Text);
            p.ProductName = txtProductName.Text;
            p.Price = decimal.Parse(txtPrice.Text);
            p.ProductImage = fn;
            p.ProductDescription = txtDescription.Text;
            p.idCategory = int.Parse(ddlCategories.SelectedValue);
            p.idRequirement= int.Parse(txtIdRequirement.Text);
            p.IdPegi = int.Parse(txtPegi.Text);
            p.idManufacturer = int.Parse(ddlManufacturer.SelectedValue);
            p.Active = cbxActive.Checked;
            try   //--Update
            {
                p.Update();
                lblMsg.Text = "העדכון בוצע";
                ViewProduct();
                //מילוי הפקדים מחדש, באמצעות הערכים החדשים שהוכנסו לבסיס הנתונים
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }

        }


        }
        }
    