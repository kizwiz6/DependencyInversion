using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal interface ICart
    {
        void AddProduct(Product product, int quantity);
        void RemoveProduct(Product product);
        void UpdateQuantity(Product product, int quantity);
        decimal CalculateTotal();
    }
}
