namespace Assignment_Advanced02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Product> catalog = new()
            {
                  new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
                  new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
                  new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
                  new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
                  new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
                  new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
                  new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
                  new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
                  new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
                  new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
            };
            //Smart Product Search
            //use Func<Product, bool> to define the search criteria for different product categories and conditions ,Func returns a boolean value indicating whether a product meets the specified criteria.
            Func<Product, bool> getElectronics = (Product) => Product.Category == "Electronics";
            Func<Product, bool> getStockGreaterThan0 = (Product) => Product.Stock > 0;
            Func<Product, bool> getClothingLessThan100 = (Product) => Product.Category == "Clothing" && Product.Price < 100;
            Console.WriteLine("---Electronics Products---");
            Console.WriteLine();
            Helper.PrintList<Product>("Electronics Products", SearchProducts.Search_Products(catalog, getElectronics));
            Console.WriteLine();
            Console.WriteLine("---In Stock Products---");
            Console.WriteLine();
            Helper.PrintList<Product>("In Stock Products", SearchProducts.Search_Products(catalog, getStockGreaterThan0));
            Console.WriteLine();
            Console.WriteLine("---Affordable Clothing---");
            Console.WriteLine();
            Helper.PrintList<Product>("Affordable Clothing", SearchProducts.Search_Products(catalog, getClothingLessThan100));

            //Custom Report Generator
            //use Action<Product> to define the report format for different product details,Action does not return any value but performs an action on the product object.
            Action<Product> ShortReport = (Product) => Console.WriteLine($"[{Product.Category}]{Product.Name}");
            Action<Product> DetailedeReport = (Product) => Console.WriteLine($"[{Product.Category}]{Product.Name}|Price: ${Product.Price}|Stock: {Product.Stock}");

            Console.WriteLine("----Short Report----");
            CustomReportGenerator.PrintReport(catalog, ShortReport);
            Console.WriteLine("----Detailed Report----");
            CustomReportGenerator.PrintReport(catalog, DetailedeReport);

            //TransformProducts
            //use Func<Product, string> to define the transformation logic for different product representations,Func returns a string representation of the product based on the specified transformation logic.

            Func<Product, string> SummaryList = (Product) => $"{Product.Name}({Product.Price})";
            Func<Product, string> PriceLabels = (Product) =>
            {
                if (Product.Price > 100)
                {
                    return $"{Product.Name}: Expensive";
                }
                else
                {
                    return $"{Product.Name}: Affordable";
                }
            };
            Console.WriteLine("----Summary List----");
            Console.WriteLine();
            Helper.PrintList<string>("Summary List", TranformProducts.Transform_Products(catalog, SummaryList));
            Console.WriteLine();
            Console.WriteLine("-------Price Labels-----");
            Console.WriteLine();
            Helper.PrintList<string>("Price Labels", TranformProducts.Transform_Products(catalog, PriceLabels));

            //Low-Stock Alerts
            //use Predicate<Product> to define the low-stock alert condition for products,Predicate returns a boolean value indicating whether a product meets the low-stock condition.
            Console.WriteLine("---Low-Stock Alerts---");
            Predicate<Product> lowStockAlert = (Product) =>
            {
                Console.WriteLine($"Only {Product.Stock} left!");
                return Product.Stock < 20;
            };
        }
    }
}
