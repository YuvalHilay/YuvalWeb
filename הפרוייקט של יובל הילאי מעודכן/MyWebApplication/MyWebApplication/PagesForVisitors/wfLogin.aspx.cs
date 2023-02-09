using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MyWebApplication
{
    public partial class wfLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Entities.Client c = new Entities.Client();
            Entities.Admin a = new Entities.Admin();
            c.UserName = Login1.UserName;
            a.UserName = Login1.UserName;
            c.Password = Login1.Password;
            a.Password = Login1.Password;
            int idClient = c.ExistByUserNamePassword();
            int idAdmin = a.ExistByUserNamePassword();
            if (idClient != -1)
            {
                Response.Write(idClient);
                Session["IDCLIENT"] = idClient;
                Response.Redirect("../Default.aspx");
            }
            else if (idAdmin != -1)
            {
                Response.Write(idAdmin);
                Session["IDADMIN"] = idAdmin;
                Response.Redirect("../Default.aspx");
            }
            else
            {
                Response.Write("one or more of the identification specifications you provided are false ");
            }
        }

        protected void btnRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PagesForVisitors/wfRegistration.aspx");
        }
    }
}