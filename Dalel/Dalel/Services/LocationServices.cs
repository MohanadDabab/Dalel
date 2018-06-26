using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Dalel.Model;
using Newtonsoft.Json;

namespace Dalel.Services
{
    public class LocationServices
    {
        private const string webServicUrl = "http://mohanaddabab-001-site1.atempurl.com/api/locations";

        public async Task<List<LocationInfo>> GetLocation()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(webServicUrl);

            var taskModel = JsonConvert.DeserializeObject<List<LocationInfo>>(json);

            return taskModel;
        }
    }
}
