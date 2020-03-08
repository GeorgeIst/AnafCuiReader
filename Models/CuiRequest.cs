using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest01._03.Models
{
    public class CuiRequest
    {
/*        public long Id { get; set; }*/
        public string cui { get; set; }
        public string data { get; set; }

        public CuiRequest(string cui)
        {
            this.cui = cui.Substring(2);
            this.data = DateTime.Now.ToString("yyyy-MM-dd");
        }
    } 
}


