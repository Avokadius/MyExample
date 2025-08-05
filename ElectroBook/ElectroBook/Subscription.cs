namespace ElectroBook;

public class Subscription
{
    public User User { get; set; }
    public DateTime ExpirationDate { get; set; }

    public Subscription(User user)
    {
        User = user;
        ExpirationDate = DateTime.Now.AddMonths(1);
    }

    public void Renew()
    {
        ExpirationDate = DateTime.Now.AddMonths(1);
        Console.WriteLine($"Подписка {User.Name} была обновлена до {ExpirationDate.ToShortDateString()}");
    }
}
