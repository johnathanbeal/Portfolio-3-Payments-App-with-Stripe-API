using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StripeWebAPICore.Services
{
    public interface IChargeCreationService
    {
        void CreateCharge(string stripeEmail, string stripeToken);
    }

    public class ChargeCreationService : IChargeCreationService
    {
        private CustomerService _customers;
        private ChargeService _charges;

        public ChargeCreationService()
        {
            _customers = new CustomerService();
            _charges = new ChargeService();
        }

        public void CreateCharge(string stripeEmail, string stripeToken)
        {

            var customer = _customers.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                SourceToken = stripeToken
            });

            _charges.Create(new ChargeCreateOptions
            {
                Amount = 2000,
                Description = "TShirts from Monogram Mama",
                Currency = "usd",
                CustomerId = customer.Id
            });
        }
    }
}
