using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class CustomersService : Customer.CustomerBase
    {
        private readonly ILogger<CustomersService> _logger;

        public CustomersService(ILogger<CustomersService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomersInfo(CustomerLookupModel request, ServerCallContext context)
        {
            CustomerModel output = new CustomerModel();

            if(request.UserId == 1)
            {
                output.FirstName = "John";
                output.Lastname = "Wick";
            }
            else if (request.UserId == 2)
            {
                output.FirstName = "Katya";
                output.Lastname = "Vandees";
            }
            else
            {
                output.FirstName = "Frank";
                output.Lastname = "Castle";
            }

            return Task.FromResult(output);
        }
    }
}
