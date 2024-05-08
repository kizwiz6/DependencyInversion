using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    /// <summary>
    /// Interface defining the behaviour of a logger.
    /// </summary>
    internal interface ILogger
    {
        /// <summary>
        /// Handles an error.
        /// </summary>
        /// <param name="error">Error message.</param>
        void Handle(string error);
    }
}
