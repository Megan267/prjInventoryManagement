using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    public static class Extension_methods
    {
        // Extension methods for List<Product>
        // Reference: Microsoft Docs - Extension Methods (C# Programming Guide)
        // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
        // Calculates the total inventory value
        public static double TotalValue(this List<Product> products)
        {
            return products.Sum(p => p.Price * p.Quantity);
        }

        // The below method will filters products with quantity below the given threshold
        public static List<Product> LowStock(this List<Product> products)
        {
            return products.Where(p => p.Quantity < 20).ToList();
        }
    }
}
