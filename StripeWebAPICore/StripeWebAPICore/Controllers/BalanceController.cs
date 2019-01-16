using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using StripeWebAPICore.Models;

namespace StripeWebAPICore.Controllers
{
    [ApiController]
    public class BalanceController : ControllerBase
    {
        [Route("api/balance")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("api/balance/{id}")]
        public BalanceModel Get(int id)
        {
            var service = new BalanceService();
            var balance = service.Get();

            return new BalanceModel
            {
                availableBalance = balance.Available.First().Amount
            };
        }
    }

    
}