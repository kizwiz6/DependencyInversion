using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal class Customer
    {
        private FileLogger obj = new FileLogger();
 
        public virtual void Add()
        {
            try
            {
                // Database code
            }
            catch (Exception ex)
            {
                obj.Handle(ex.ToString());
            }
        }
    }
}
