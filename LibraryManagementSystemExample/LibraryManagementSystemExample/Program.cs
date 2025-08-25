namespace LibraryManagementSystemExample
{
    internal class Program
    {
        private static void SeedData()
        {
            stand.AddItem(new Book("Вокруг света за 80 дней", "Жюль Верн", 320));
            stand.AddItem(new Book("Гарри Поттер", "Дж. К. Роулинг", 1200));
            stand.AddItem(new Book("Дети Капитана Гранта", "Желю Верн", 1000));
            stand.AddItem(new Magazine("Forbes", "Редакция", "№10/2022"));
            stand.AddItem(new Magazine("National Geographic", "Редакция", "№5/2023"));
            stand.AddItem(new Magazine("PlayBoy", "Редакция", "№6/2023"));
            stand.AddItem(new Magazine("Succes", "Редакция", "№7/2024"));
        }

        private static void RunMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== Меню ===");
                Console.WriteLine("1) Показать все элементы");
                Console.WriteLine("2) Показать доступные");
                Console.WriteLine("3) Поиск по названию");
                Console.WriteLine("4) Взять элемент");
                Console.WriteLine("5) Вернуть элемент");
                Console.WriteLine("6) Статистика");
                Console.WriteLine("0) Выход");
                Console.Write("Выбор: ");

                string? choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        stand.PrintAll();
                        break;
                    case "2":
                        Console.WriteLine("Показать доступные: ");
                        foreach(var item in stand.GetAvailableItems())
                            Console.WriteLine(item.GetInfo());
                        break;
                    case "3":
                        Console.WriteLine("Введите часть названия: ");
                        string? query = Console.ReadLine();
                        var found = stand.FindByName(query ?? "");
                        Console.WriteLine(found != null ? found.GetInfo() : "Не найдено.");
                        break;
                    case "4":
                        Console.WriteLine("Введите название для выдачи: ");
                        var toBorrow = stand.FindByName(Console.ReadLine() ?? "");
                        if (toBorrow is Library lib1) lib1.Borrow();
                        else Console.WriteLine("Не найдено.");
                        break;

                    case "5":
                        Console.Write("Введите название для возврата: ");
                        var toReturn = stand.FindByName(Console.ReadLine() ?? "");
                        if (toReturn is Library lib2) lib2.Return();
                        else Console.WriteLine("Не найдено.");
                        break;
                    case "6":
                        stand.PrintStatistics();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }
        private static Stand stand = new Stand();
        static void Main(string[] args)
        {
            SeedData();
            RunMenu();
        }
    }
}
