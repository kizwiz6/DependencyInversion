using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    /// <summary>
    /// Implementation of logger that logs errors to Event Viewer.
    /// </summary>
    public class EventViewerLogger : ILogger
    {
        public void Handle(string error)
        {
            // Log errors to event viewer
            Console.WriteLine("Error logged to Event Viewer: " + error);
        }
    }
}
