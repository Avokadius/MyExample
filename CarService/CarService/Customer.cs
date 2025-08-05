using System.Globalization;

namespace CarService;

public class Customer
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public Customer(string name,string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;

    }

    public void RequestService(Car car)
    {
        Console.WriteLine($"{Name} - Просит обслуживание для своего авто {car.Make} {car.Model}!");
    }
}
