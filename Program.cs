using exercHeranca.Entities;

List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char type = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());
    if (type == 'c')
    {
        products.Add(new Product(name, price));
    }
    else if (type == 'i')
    {
        Console.Write("Customs fee:");
        double customs = double.Parse(Console.ReadLine());
        products.Add(new ImportedProduct(name, price, customs));
    }
    else
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        products.Add(new UsedProduct(name, price, date));
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS: ");
foreach (Product prod in products)
{
    Console.WriteLine(prod.PriceTag());
}