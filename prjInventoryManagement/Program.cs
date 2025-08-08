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


            //https://www.c-sharpcorner.com/UploadFile/ff2f08/anonymous-types-in-C-Sharp/
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
 * 
 */