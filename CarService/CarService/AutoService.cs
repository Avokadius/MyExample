namespace CarService;

public class AutoService
{
    public List<Car> Cars { get; set; } = new List<Car>();

    public void AddCar(Car car)
    {
        Cars.Add(car);
        Console.WriteLine($"Добавлен автомобиль: {car.Make} {car.Model}, год выпуска: {car.Year}.");
    }

    public Car GetCar(string make, string model)
    {
        return Cars.Find(car => car.Make.Equals(make, StringComparison.OrdinalIgnoreCase) && car.Model.Equals(model, StringComparison.OrdinalIgnoreCase));
    }
}
