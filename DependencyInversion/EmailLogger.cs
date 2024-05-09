using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    /// <summary>
    /// Implementation of logger that sends errors via email.
    /// </summary>
    public class EmailLogger : ILogger
    {
        /// <summary>
        /// Handles an error by sending it via email.
        /// </summary>
        /// <param name="error">Error message.</param>
        public void Handle(string error)
        {
            // Send errors in email
            Console.WriteLine("Error logged via email: " + error);
        }
    }
}
