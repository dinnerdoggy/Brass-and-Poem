namespace BrassAndPoem;

public class Options
{
    public static void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
    {
        Console.Clear();

        int list = 0;

        foreach (Product product in products)
        {
            list++;
            Console.WriteLine($"{list}. {product.Name}, {productTypes[product.ProductTypeId].Name}, ${product.Price}");
        }
        Console.WriteLine("\n");
    }

    public static void DeleteProduct(List<Product> products, List<ProductType> productTypes)
    {
        Console.Clear();
        Options.DisplayAllProducts(products, productTypes);
        Console.Write("Enter the number for the product you'd like to delete: ");
        try
        {
            int choice = int.Parse(Console.ReadLine().Trim()) - 1;
            string choiceName = products[choice].Name;
            products.RemoveAt(choice);
            Options.DisplayAllProducts(products, productTypes);
            Console.WriteLine($"You have deleted {choiceName}");
        }
        catch
        {
            Console.WriteLine("Invalid Input");
        }


    }

    public static void AddProduct(List<Product> products, List<ProductType> productTypes)
    {
        Console.Clear();
        Console.Write("Enter the name of your product: ");

        string choiceName = "";
        try
        {
            choiceName = Console.ReadLine().Trim();
        }
        catch
        {
            Console.WriteLine("Invalid Input");
        }

        Console.Write("\nEnter your asking price: ");
        decimal choicePrice = 0m;
        try
        {
            choicePrice = decimal.Parse(Console.ReadLine().Trim());
        }
        catch
        {
            Console.WriteLine("Invalid Input");
        }

        int list = 0;
        foreach (ProductType productType in productTypes)
        {
            list++;
            Console.WriteLine($"{list}. {productType.Name}");
        }

        Console.Write("\nWhich category does your product fall under (1-2)?");
        int choiceType = 0;
        try
        {
            choiceType = int.Parse(Console.ReadLine().Trim()) - 1;
        }
        catch 
        {
            Console.WriteLine("Invalid Input");
        }

        Product newProduct = new Product(choiceName, choicePrice, choiceType);
        products.Add(newProduct);

        Options.DisplayAllProducts(products, productTypes);

        Console.WriteLine($"{newProduct.Name} has been added to products!");
    }


    // By the time I got to update I realized I could just put a whole
    // code block in a try instead of how I did it above lol
    public static void UpdateProduct(List<Product> products, List<ProductType> productTypes)
    {
        Console.Clear();
        Options.DisplayAllProducts(products, productTypes);
        Console.Write("Enter the number for the product would you like to update: ");

        int choiceProduct = 0;
        try
        {
            choiceProduct = int.Parse(Console.ReadLine().Trim()) - 1;
            Product product = products[choiceProduct];

            Console.Clear();
            Console.WriteLine($"1. {product.Name}");
            Console.WriteLine($"2. {product.Price}");
            Console.WriteLine($"3. {productTypes[product.ProductTypeId].Name}");

            Console.WriteLine("\nWhich property would you like to change (1-3)?");
            int updateChoice = int.Parse(Console.ReadLine().Trim());

            string updateSuccess = "Your product has been updated!";

            switch (updateChoice)
            {
                case 1:
                    Console.Write("Enter a new product name: ");
                    string newName = Console.ReadLine().Trim();
                    product.Name = newName;
                    Options.DisplayAllProducts(products, productTypes);
                    Console.WriteLine(updateSuccess);
                    break;
                case 2:
                    Console.Write("Enter a new price: ");
                    decimal newPrice = decimal.Parse(Console.ReadLine().Trim());
                    product.Price = newPrice;
                    Options.DisplayAllProducts(products, productTypes);
                    Console.WriteLine(updateSuccess);
                    break;
                case 3:
                    int list = 0;
                    foreach (ProductType productType in productTypes)
                    {
                        list++;
                        Console.WriteLine($"{list}. {productType.Name}");
                    }
                    Console.Write($"\nChoose a new category (1-2)");

                    int newType = int.Parse(Console.ReadLine().Trim()) - 1;
                    product.ProductTypeId = newType;
                    Options.DisplayAllProducts(products, productTypes);
                    Console.WriteLine(updateSuccess);
                    break;
            }
        }
        catch
        {
            Console.WriteLine("Invalid Input");
        }

    }
}