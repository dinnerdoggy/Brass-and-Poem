using BrassAndPoem;
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
Product product1 = new Product("Leaves of Grass", 15.00m, 1);
Product product2 = new Product("The Divine Comedy", 20.00m, 2);
Product product3 = new Product("Trumbone", 1000.00m, 3);
Product product4 = new Product("Howl and Other Poems by Allen Ginsberg", 30.00m, 4);
Product product5 = new Product("Trumpet", 600.00m, 5);

List<Product> products = new List<Product> { product1, product2, product3, product4, product5 };
//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
ProductType type1 = new ProductType("Poem", 1);
ProductType type2 = new ProductType("Brass", 2);
//put your greeting here

//implement your loop here

void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }