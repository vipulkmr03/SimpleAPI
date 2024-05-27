using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleApi
{
    [ApiController]
    [Route("api/[controller]")]
   public class ValuesController : ControllerBase
    {
        // GET: api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "Temp1", "Temp2" };
        }

        // GET: api/values/5
        public string Get(int id)
        {
            return "Temp";
        }

    }
}