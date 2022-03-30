using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DataAccessLayer;

namespace UI.Controllers
{
    [Route("CustMaster/")]
    public class CustMasterController : Controller
    {
        // GET: CustMaster
        [HttpGet]
        [Route("GetAllCust")]
        public async Task<ActionResult> GetAll()
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:63196/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage responce =await client.GetAsync("GetCust");
                if(responce.IsSuccessStatusCode)
                {
                    var cust=await responce.Content.ReadAsAsync<CustomerMaster[]>();
                    return View(cust);
                }
                else
                {
                    return View("NO DATA");
                }
                


            }
        }
    }
}