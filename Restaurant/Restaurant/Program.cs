namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            // addDish
            restaurant.AddDish(new Dish("Паста", 12.99m));
            restaurant.AddDish(new Dish("Салат Цезарь", 9.99m));
            restaurant.AddDish(new Dish("Стейк", 25.99m));
            restaurant.AddDish(new Dish("Суп", 10.99m));

            Customer customer = new Customer("Софья",50.00m);

            Order order = new Order();

            Dish dish1 = restaurant.GetDish("Паста");
            Dish dish2 = restaurant.GetDish("Суп");

            if (dish1 != null)
            {
                order.AddDish(dish1);
            }
            if(dish2 != null)
            {
                order.AddDish(dish2);
            }

            customer.PlaceOrder(order);

        }
    }
}
