using LibraryManagementSystemExample.Interface;

namespace LibraryManagementSystemExample;

public abstract class Library : ILibraryItem
{
    public string Name { get; set; }
    public string Author { get; set; }
    public bool InStock { get; private set; } = true;
    public DateTime? BorrowedUntil { get; private set; }

    protected Library(string name, string author, bool inStock = true)
    {
        Name = name;
        Author = author;
        InStock = inStock;
    }

    public void Borrow(int days = 14)
    {
        if (!InStock)
        {
            Console.WriteLine($"{Name} уже занята!");
        }

        InStock = false;
        BorrowedUntil = DateTime.Now.AddDays(days);
        Console.WriteLine($"{Name} выдана до {BorrowedUntil.Value:d}");
    }

    public void Return()
    {
        InStock = true;
        BorrowedUntil = null;
        Console.WriteLine($"{Name} возвращена в библиотеку.");
    }

    protected string BaseInfo() =>
        $"Название: {Name}, Автор: {Author}, В наличии: {(InStock ? "Да" : "Нет")}";

    public abstract string GetInfo();
}
