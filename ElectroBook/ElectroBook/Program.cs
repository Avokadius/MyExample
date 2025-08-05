namespace ElectroBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new EBook("Дети Капитана Гранта", "Жюль Верн", 9.90m));
            library.AddBook(new EBook("Вокруг Света за 80 дней", "Жюль Верн", 11.90m));

            User user = new User("Синус", 10m);

            // Пользователь офрмил подписку 
            user.Subscribe();

            Subscription subscription = new Subscription(user);


            //Пользователь берет книгу 
            EBook book = library.GetEbook("Дети Капитана Гранта");
            if (book != null)
            {
                book.Borrow();
            }
            else
            {
                Console.WriteLine("Книга не найдена!");
            }

            //Обновляем подписку 
            subscription.Renew();

            //Пользователь возврощает книгу 
            book.Return();
        }
    }
}
