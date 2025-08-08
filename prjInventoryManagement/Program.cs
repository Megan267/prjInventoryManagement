namespace prjInventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { ID = 1, Name = "Laptop", Quantity = 10, Price = 999 },
                new Product { ID = 2, Name = "Smartphone", Quantity = 25, Price = 600 },
                new Product { ID = 3, Name = "Tablet", Quantity = 15, Price = 200 }
            };

            // Using extension method to calculate total value
            Console.WriteLine($"Total Inventory Value: {products.TotalValue():C}");

            // Using extension method to filter low-stock products
            Console.WriteLine("\nLow Stock Products:");
            var lowStock = products.LowStock();
            foreach (var p in lowStock)
            {
                Console.WriteLine($"{p.Name} has quantity: {p.Quantity}");
            }


            //Anoynomous types with LINQ
            //Trivedi (2023) demonstrates how to use anonymous types in C#.
            var productInformation = from p in products select new { p.Name, p.Price };
            Console.WriteLine("Product names and Prices information:");
            foreach (var product in productInformation)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
/*
 * Reference List
 *  Trivedi, J. 2023. Anonymous Types In C# [Source code]. Available at: <https://www.c-sharpcorner.com/UploadFile/ff2f08/anonymous-types-in-C-Sharp/> [Accessed 08 August 2025]. 
 */