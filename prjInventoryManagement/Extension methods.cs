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
        // Microsoft Learn (2025) demonstrates how to do extension methods to calculate a total.
        // This method calculates the total inventory value.
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
/*
 * Reference List
 * Microsoft Learn. 2025.Extension members (C# Programming Guide) [Source code]. Available at: <https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods> [Accessed 08 August 2025]. 
 */