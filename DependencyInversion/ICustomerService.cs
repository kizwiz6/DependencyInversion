using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    /// <summary>
    /// Interface defining the behaviour of a customer service.
    /// </summary>
    internal interface ICustomerService
    {
        void Add();
    }
}
