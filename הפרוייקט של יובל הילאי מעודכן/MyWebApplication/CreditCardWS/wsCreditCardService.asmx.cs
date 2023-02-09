using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CreditCardWS
{
    /// <summary>
    /// Summary description for wsCreditCardService
    /// </summary>

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsCreditCardService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public bool IsValidCard(Card c)
        {
            return c.IsValid();
        }

        [WebMethod]
        public int InsertDeal(Deal d)
        {
            return d.Insert();
        }

        [WebMethod]
        public DataSet GetCompanies()
        {
            DataTable dt = Card.GetCompanies();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
       
    }
}
