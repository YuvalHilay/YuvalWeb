using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalcWS
{
    /// <summary>
    /// Summary description for CalcService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int Add(int n1,int n2)
        {
            return n1 + n2;
           
        }
        [WebMethod]
          public int Sub(int n1,int n2)
        {
            return n1 - n2;
        }
        [WebMethod]
        public int Cefel(int n1, int n2)
        {
            return n1 * n2;
        }
        [WebMethod]
        public int Hilok(int n1, int n2)
        {
            return n1 / n2;
        }


    }
}
