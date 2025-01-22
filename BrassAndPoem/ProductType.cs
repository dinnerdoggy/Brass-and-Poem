namespace BrassAndPoem;

public class ProductType
{
    public string Name { get; set; }
    public int Id { get; set; }

    // Constructor
    public ProductType(string name, int id)
    {
        Name = name;
        Id = id;
    }
}