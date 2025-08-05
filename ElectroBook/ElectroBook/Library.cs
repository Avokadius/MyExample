namespace ElectroBook;

public class Library
{
    private List<EBook> EBooks {  get; set; } = new List<EBook>();

    public void AddBook(EBook book)
    {
        EBooks.Add(book);
        Console.WriteLine($"Добавлена электронная книга {book.Title}, Автор: {book.Author}, Цена: {book.Price:C}");
    }
    public EBook GetEbook(string title)
    {
        return EBooks.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }
 }
