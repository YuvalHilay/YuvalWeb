using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication
{
    public partial class Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSelectedDates_Click(object sender, EventArgs e)
        {
            foreach (DateTime date in Calendar1.SelectedDates)
                lblSelectedDates.Text += date.ToShortDateString() + "<br/>";

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if(e.Day.IsWeekend || e.Day.IsOtherMonth)
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Day.IsSelectable = false;
            }
        }
        
    }
}