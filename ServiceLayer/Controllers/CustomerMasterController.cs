using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;
namespace ServiceLayer.Controllers
{
    [Route("api/CustomerMaster/")]
    public class CustomerMasterController : ApiController
    {
        [Route("GetCust")]
          public HttpResponseMessage GetAllCust()
        {
            CustomerMasterImpliment customerMasterImpliment = new CustomerMasterImpliment();
            var cust = customerMasterImpliment.GetAllCustomer();
            return Request.CreateResponse(HttpStatusCode.OK, cust);
        }
    }
}
