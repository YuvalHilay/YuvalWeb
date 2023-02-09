using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DeliveriesWS
{
    /// <summary>
    /// Summary description for WSDeliveries
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Deliveries : System.Web.Services.WebService
    {

        [WebMethod]
        public int InsertDelivery(Delivery d)
        {
            return d.Insert();
        }                                                                               
                                                        
        [WebMethod]     
        public int GetDeliveryStatus(Delivery d)                                                    
        {
            return d.GetDeliveryStatus();                                                                                                                                                                                                                                                    
        }

        [WebMethod]
        public DataSet GetStoreDeliveriesByStatus(int idStore, int status)
        {
            DataTable dt = Delivery.GetStoreDeliveriesByStatus(idStore, status);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}

