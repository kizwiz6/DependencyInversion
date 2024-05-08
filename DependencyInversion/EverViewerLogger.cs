using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal class EverViewerLogger : ILogger
    {
        public void Handle(string error)
        {
            // Log errors to event viewer
        }
    }
}
