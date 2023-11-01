namespace DAL;

public class OrderedShake
{
    public Guid Id { get; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Size Size { get; set; }

    public OrderedShake()
    {
        Id = Guid.NewGuid();
    }

}


public enum Size
{
    S ,
    M,
    L
}