using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;
using System.Drawing;

namespace MyWebApplication.PagesForAdmins
{
    public partial class wfListOfRequirements : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
   
            vReqList();
        }
        private void vReqList()
        {
           DataTable dt = Entities.Requirements.RequirementsList();
           gvViewRequirements.DataSource = dt;
           gvViewRequirements.DataBind();
        }
        }
    }
