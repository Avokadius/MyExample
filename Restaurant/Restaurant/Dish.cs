namespace Restaurant;

public class Dish
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; private set; } = true;

    public Dish(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void MarkAsUnavailable()
    {
        IsAvailable = false;
        Console.WriteLine($"{Name} теперь не доступен!");
    }

    public void MarkAsAvailable()
    {
        IsAvailable = true;
        Console.WriteLine($"{Name} теперь доступен!");
    }
}
