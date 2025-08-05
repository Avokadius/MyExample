using System.ComponentModel.Design;

namespace CarService;
public class Car
{
    public string Make {  get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public bool IsInService { get; set; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void StartService()
    {
        IsInService = true;
        Console.WriteLine($"Автомобиль {Make} {Model} начал обслуживание.");
        
    }
    
    public void CompleteService()
    {
        IsInService = false;
        Console.WriteLine($"Автомобиль {Make} {Model} завершил обслуживание.");
    }
}
