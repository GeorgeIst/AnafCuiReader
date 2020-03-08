using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest01._03.Models
{
    public class JsonResponse
    {
        public int code { get; set; }
        public string status { get; set; }
        public CuiResponse[] found { get; set; }
        public CuiResponse[] notFound { get; set; }

        public JsonResponse()
        {
        }

        public JsonResponse(int code, string status, CuiResponse[] found, CuiResponse[] notFound)
        {
            this.code = code;
            this.status = status;
            this.found = found;
            this.notFound = notFound;
        }
    }
}
