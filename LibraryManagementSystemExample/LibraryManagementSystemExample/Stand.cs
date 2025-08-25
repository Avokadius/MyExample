using LibraryManagementSystemExample.Interface;

namespace LibraryManagementSystemExample;

public class Stand
{
    private readonly List<ILibraryItem> libraries = new();

    public void AddItem(ILibraryItem item) => libraries.Add(item);

    public void PrintAll()
    {
        foreach (var library in libraries)
        {
            Console.WriteLine(library.GetInfo());
        }
    }

    public ILibraryItem? FindByName(string name) =>
        libraries.FirstOrDefault(l => l.GetInfo().Contains(name, StringComparison.OrdinalIgnoreCase));

    public IEnumerable<ILibraryItem> GetAvailableItems() =>
        libraries.Where(l => l is Library lib && lib.InStock);

    public void PrintStatistics()
    {
        int books = libraries.Count(l => l is Book);
        int magazines = libraries.Count(l => l is Magazine);
        int available = libraries.Count(l => l is Library lib && lib.InStock);

        Console.WriteLine($" Статистика:");
        Console.WriteLine($" Книг: {books}");
        Console.WriteLine($" Журналов: {magazines}");
        Console.WriteLine($" Доступно: {available}");
    }


}
