namespace Restaurant;

public  class Restaurant
{
    public List<Dish> Menu {  get; set; } = new List<Dish>();

    public void AddDish(Dish dish)
    {
        Menu.Add(dish);
        Console.WriteLine($"Добавлено блюдо в меню: {dish.Name}, цена: {dish.Price:C}");
    }

    public Dish GetDish(string name)
    {
        return Menu.Find(dish => dish.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}
