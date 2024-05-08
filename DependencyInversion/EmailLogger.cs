using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            // Send errors in email
        }
    }
}
