using LibraryManagementSystemExample.Interface;

namespace LibraryManagementSystemExample;

public class Book:Library
{
    public int NumberOfPages { get; set; }

    public Book(string name,string author,int numberOfPages, bool inStock = true) : base (name,author, inStock)
    {
        NumberOfPages = numberOfPages;
    }

    public override string GetInfo()
    {
        return $"{BaseInfo()}, Страниц: {NumberOfPages}";
    }
}
