using System;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var products = new List<Product>();
        products.Add(new Product { Name = "SmartTV", Price = 400, Category = "Electronics" });
        products.Add(new Product { Name = "Lenovo ThinkPad", Price = 1000, Category = "Electronics" });
        products.Add(new Product { Name = "Iphone", Price = 700, Category = "Electronics" });
        products.Add(new Product { Name = "Orange", Price = 2, Category = "Fruits" });
        products.Add(new Product { Name = "Banana", Price = 3, Category = "Fruits" });
        ILookup<string, Product> lookup = products.ToLookup(prod => prod.Category);
        TotalPrice(lookup);
        Console.ReadKey();
    }

    static void TotalPrice(ILookup<string, Product> lookup)
    {
        foreach (var group in lookup)
        {
            double totalPriceForCategory = group.Sum(prod => prod.Price);
            Console.WriteLine($"{group.Key} Total Price: {totalPriceForCategory}");
            foreach (var product in group)
            {
                Console.WriteLine($"{product.Name} {product.Price}");
            }
        }
    }
}
