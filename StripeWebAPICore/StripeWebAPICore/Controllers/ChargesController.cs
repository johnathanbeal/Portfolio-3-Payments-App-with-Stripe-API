using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace StripeWebAPICore.Controllers
{
    [ApiController]
    public class ChargesController : ControllerBase
    {
        [Route("api/charges")]
        public IEnumerable<string> Get()
        {
            return new string[] { "5.00", "20.00" };
        }

        

        
    }
}