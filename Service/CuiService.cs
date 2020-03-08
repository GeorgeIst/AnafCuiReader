using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApplicationTest01._03.Models;

namespace WebApplicationTest01._03.Service
{
    public class CuiService
    {
        public Models.CuiResponse[] ProccessCui(string cui)
        {
            if (!Models.CuiValidator.IsValid(cui))
            {
                Models.CuiResponse[] invalid = { };
                return invalid;
            }
            List<Models.CuiRequest> req = new List<Models.CuiRequest>() { new Models.CuiRequest(cui) }; 
           
            var json = JsonConvert.SerializeObject(req);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://webservicesp.anaf.ro/PlatitorTvaRest/api/v4/ws/tva";
            using var client = new HttpClient();

            var response = client.PostAsync(url, data).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var d = JsonConvert.DeserializeObject<JsonResponse>(result);
            return d.found;
            
        }
    }
}
