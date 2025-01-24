using BrassAndPoem;
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
Product product1 = new Product("Leaves of Grass", 15.00m, 0);
Product product2 = new Product("The Divine Comedy", 20.00m, 0);
Product product3 = new Product("Trumbone", 1000.00m, 1);
Product product4 = new Product("Howl by Allen Ginsberg", 30.00m, 0);
Product product5 = new Product("Trumpet", 600.00m, 1);

List<Product> products = new List<Product> { product1, product2, product3, product4, product5 };

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
ProductType type1 = new ProductType("Poem", 1);
ProductType type2 = new ProductType("Brass", 2);

List<ProductType> productTypes = new List<ProductType> { type1, type2 };
//put your greeting here
string greeting = "○•Welcome to Brass & Poem•○\n";
//implement your loop here

bool exit = false;

while (!exit)
{
    DisplayMenu();
    void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine(greeting);
        Console.WriteLine("1. Display all products");
        Console.WriteLine("2. Delete a product");
        Console.WriteLine("3. Add a new product");
        Console.WriteLine("4. Update product properties");
        Console.WriteLine("5. Exit");
    
        int choice = int.Parse(Console.ReadLine().Trim());
    
        switch (choice)
        {
            case 1:
                Options.DisplayAllProducts(products, productTypes);
                break;
            case 2:
                Options.DeleteProduct(products, productTypes);
                break;
            case 3:
                Options.AddProduct(products, productTypes);
                break;
            case 4:
                Options.UpdateProduct(products, productTypes);
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("○•Happy tooting•○");
                exit = true;
                break;
    
        }
    }

    // Pause before redisplaying the menu
    if (!exit)
    {
        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
        Console.Clear();
    }

}

// don't move or change this!
public partial class Program { }