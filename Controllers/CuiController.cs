using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationTest01._03.Models;
using WebApplicationTest01._03.Models.TodoApi.Models;
using WebApplicationTest01._03.Service;

namespace WebApplicationTest01._03.Controllers
{
    [Route("api/anaf")]
    [ApiController]
    public class CuiController : ControllerBase
    {
        private CuiService service = new CuiService();

        [HttpGet("{cui}", Name = "Get")]
        public string Get(string cui)
        {
            CuiResponse[] cuiResponse = service.ProccessCui(cui);
            return cuiResponse[0].ToString();
        }
    }
}