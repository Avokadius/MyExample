using System.Reflection.Metadata.Ecma335;

namespace ElectroBook;

public class EBook
{
    public string Title { get; set; } // Название книги 
    public string Author { get; set; } // Автор
    public decimal Price { get; set; } // Цена

    public bool IsAvailable { get; set; } = true; // в наличии или нет

    public EBook(string title, string author, decimal price )
    {
        Title = title;
        Author = author;
        Price = price;

    }
    public void Borrow()
    {
        if( IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"{Title} был взят.");

        }
        else
        {
            Console.WriteLine($"{Title} не доступен!");
        }

    }

    public void Return()
    {
        IsAvailable = true;
        Console.WriteLine($"{Title} был возвращен.");
    }
}
