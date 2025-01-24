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
            Console.WriteLine($"{list}. {product.Name}, {productTypes[product.ProductTypeId].Name}");
        }
        Console.WriteLine("\n");
    }

    public static void DeleteProduct(List<Product> products, List<ProductType> productTypes)
    {
        Console.Clear();
        Options.DisplayAllProducts(products, productTypes);
        Console.Write("Enter the number for the product you'd like to delete: ");
        int choice = int.Parse(Console.ReadLine()) - 1;
        string choiceName = products[choice].Name;
        products.RemoveAt(choice);
        Options.DisplayAllProducts(products, productTypes);
        Console.WriteLine($"You have deleted {choiceName}");
    }
}