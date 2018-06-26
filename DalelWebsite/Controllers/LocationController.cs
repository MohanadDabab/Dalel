using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DalelWebsite.Models;


namespace DalelWebsite.Controllers
{
    public class LocationController : ApiController
    {
        List<LocationInfo> list = new List<LocationInfo>()
            {
                new LocationInfo{

                    Name = "mohanad", BrefDescraption="HR sfef wsew"
                }
                ,
                new LocationInfo
                {
                    Name="ali", BrefDescraption= "HR feef wwe"
                }
                ,
                new LocationInfo
                {
                    Name = "Omaran" , BrefDescraption ="Markten rrer qwe "
                }

            };

        [AcceptVerbs("Get")]
        [Route("WebApi/GetLocationInfo")]
        public List<LocationInfo> GetLocationInfo()
        {

            return list;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}