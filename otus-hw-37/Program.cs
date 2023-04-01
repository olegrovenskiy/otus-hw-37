using otus_hw_37;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Hello, World!");

MyLibrary MySummerLibrary = new MyLibrary();



while (true)
{
    Console.WriteLine("Ваши действия: 1 - добавить книгу; 2 - вывести список непрочитанного; 3 - выйти");

    var act = Console.ReadLine();


    if (act == "1")
    {
        
        Console.WriteLine("Введите название книги");
        string Name = Console.ReadLine();
        MySummerLibrary.AddBook(Name);

    }
    else if (act == "2")
    {
        MySummerLibrary.GetBooks();        
    }


    else if (act == "3")

    {
        break;
    }
    else
        Console.WriteLine("Wrong input");

}

Console.WriteLine("exit");



Console.ReadKey();  
