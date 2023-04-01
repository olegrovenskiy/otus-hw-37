using otus_hw_37;

Console.WriteLine("Hello, World!");
int IdItem = 0;

Customer oleg = new Customer();
Shop shop = new Shop();

shop.Goods.CollectionChanged += oleg.OnItemChanged;



while (true)
{
    Console.WriteLine("Ваши действия: А - добавить товар, D - удалить товар, Х - выйти из программы");

    var act = Console.ReadLine();


    if (act == "A")
    {
        Item newItem = new Item(IdItem, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        shop.Add(newItem);
        IdItem++;

    }
    else if (act == "D")
    {
        Console.WriteLine("Товар с каким ID удалить ?");
        string? input = Console.ReadLine();
        bool result = int.TryParse(input, out var number);
        if (result == true)
            shop.Remove(number);
        else
            Console.WriteLine("Надо ввести ID в виде цифры");

    }


    else if (act == "X")

    {
        break;
    }
    else
        Console.WriteLine("Wrong input");

}

Console.WriteLine("exit");



Console.ReadKey();  
