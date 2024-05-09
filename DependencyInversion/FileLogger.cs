using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    /// <summary>
    /// Implementation of logger that writes errors to a file.
    /// </summary>
    public class FileLogger : ILogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
            Console.WriteLine("Error logged to file: " + error);
        }
    }
}
