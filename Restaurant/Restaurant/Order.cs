using System.Diagnostics.Contracts;

namespace Restaurant;

public  class Order
{
    public List<Dish>Dishes {  get;private set; } = new List<Dish>();

    public decimal TotalCost { get; private set; } = 0;

    public void AddDish(Dish dish)
    {
        if (dish.IsAvailable)
        {
            Dishes.Add(dish);
            TotalCost += dish.Price;
            Console.WriteLine($"Добавлено блюдо: {dish.Name}, цена: {dish.Price:C}");
        }
        else
        {
            Console.WriteLine($"{dish.Name} не доступно для добавления в заказ.");
        }

    }
}
