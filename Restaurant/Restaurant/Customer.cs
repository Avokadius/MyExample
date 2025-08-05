namespace Restaurant;

public class Customer
{
    public string Name { get; set; }
    public decimal Balance { get; set; }

    public Customer(string name, decimal balance)
    {
        Name = name;
        Balance = balance;
    }

    public void PlaceOrder(Order order)
    {
        if (order.TotalCost <= Balance)
        {
            Balance -= order.TotalCost;
            Console.WriteLine($"{Name} формил заказа на сумму {order.TotalCost}");
        }
        else
        {
            Console.WriteLine($"{Name} недостаточно средст для заказа!");
        }
    }
}
