using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace MyWebApplication
{
    public partial class mpMain : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            MenuVisitors.Visible = false;
            MenuClients.Visible = false;
            MenuAdmins.Visible = false;
            txtFirstName.Visible = false;
            txtLevelName.Visible = false;


            if (Session["IDCLIENT"] != null)
                MenuClients.Visible = true;

            else
                if (Session["IDADMIN"] != null)
                    MenuAdmins.Visible = true;
                else
                    MenuVisitors.Visible = true;

            if (Session["IDCLIENT"] != null)
            {
                func();

            }
            if (Session["IDADMIN"] != null)
            {
                func2();
            }
        }

        

        public void func()
        {
            int idClient = (int)(Session["IDCLIENT"]);
            Entities.Client c = new Entities.Client();
            c.IDClient = idClient;
            DataTable dt = c.GetDetails();
            DataTable rt = c.GetLevel();
     
                txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
                txtFirstName.Visible = true;
                txtLastName.Text = dt.Rows[0]["LastName"].ToString();
                txtLastName.Visible = true;
                txtLevelName.Text = rt.Rows[0]["LevelName"].ToString();
                txtLevelName.Visible = true;

     

            }
        

        public void func2()
        {
            int idAdmin = (int)(Session["IDADMIN"]);
            Entities.Admin c = new Entities.Admin();
            c.IDAdmin = idAdmin;

            DataTable dt = c.GetDetails();
        
                txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
                txtLastName.Text = dt.Rows[0]["LastName"].ToString();
                txtLastName.Visible = true;
                txtFirstName.Visible = true;
                txtLevelName.Visible = true;
                txtLevelName.Text = "Administrator";
           



            }

        }
    }

