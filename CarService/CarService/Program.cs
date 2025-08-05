namespace CarService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoService autoService = new AutoService();

            autoService.AddCar(new Car("Toyota", "Camry", 2020));
            autoService.AddCar(new Car("BMW", "E39", 2002));
            autoService.AddCar(new Car("Lada", "Vesta", 2018));

            Customer customer = new Customer("Алексей", "123-456-7890");

            Car car = autoService.GetCar("Toyota", "Camry");
            if (car != null)
            {
                customer.RequestService(car);
                car.StartService();


                ServiceOrder order = new ServiceOrder(car, "Замена масла", 3000);
                order.CompleteOrder();

            }
            else
            {
                Console.WriteLine("Автомобиль не найден!");
            }
        }
    }
}
