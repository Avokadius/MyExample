namespace ElectroBook;

public class User
{
    public string Name { get; set; } //Имя 
    public decimal Balance { get; set; } // баланс

    public User(string name,decimal balance)
    {
        Name= name;
        Balance= balance;
    }

    public void Subscribe()
    {
        Console.WriteLine($"{Name} - оформил подписку на библиотеку!"); 
    }
}
