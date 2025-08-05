namespace CarService;

public class ServiceOrder
{
    public Car Car { get; set; }
    public string ServiceType { get; set; }
    public decimal Cost { get; set; }

    public ServiceOrder(Car car, string serviceType, decimal cost)
    {
        Car = car;
        ServiceType = serviceType;
        Cost = cost;
    }

    public void CompleteOrder()
    {
        Car.CompleteService();
        Console.WriteLine($"Заказ на услугу '{ServiceType}' на сумму {Cost:C} завершен для автомобиля {Car.Make} {Car.Model}.");
    }
}
