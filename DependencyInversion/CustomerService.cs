using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    /// <summary>
    /// Implementation of the customer service.
    /// </summary>
    public class CustomerService : ICustomerService
    {
        private readonly ILogger _logger;

        /// <summary>
        /// Constructor for CustomerService.
        /// </summary>
        /// <param name="logger">Logger instance used for error handling.</param>
        public CustomerService(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Adds a new customer.
        /// </summary>
        public void Add()
        {
            try
            {
                Console.WriteLine("Customer added successfully.");
            }
            catch (Exception ex)
            {
                _logger.Handle(ex.ToString());
            }
        }
    }
}
