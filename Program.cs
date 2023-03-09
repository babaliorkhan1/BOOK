using System.Data.SqlTypes;

book book 
    Book[] books = new book[3];
for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine("kitab adi daxil edin");
    string name = Console.ReadLine();
    while (!Checkname(name))
    {
        Console.WriteLine( "düzgun ad daxil edin");
        name = Console.ReadLine();
    }
    Console.Write("kitab sehifesi daxil edin");
    int Pagecount = int.Parse(Console.ReadLine());
    while (CheckPageCount(Pagecount))
    {
        Console.WriteLine("sehife sayi daxil edin");
        Pagecount = int.Parse(Console.ReadLine());
        {
            while (Search(name,Pagecount))
            {
                Console.WriteLine("bele kitab movcudddur ad ve sehife sayi qeyd edin");
                Console.WriteLine("duzgun kitab adi daxil edin");
                name = Console.ReadLine();
                Console.WriteLine("duzgun sehife sayi daxil edin");
                Pagecount = int.Parse(Console.ReadLine());
               
            }
        }

        book = new book(name, Pagecount, books);
        books[i] = book;
    }
    bool Checkname(string name)
        if (name.Lenght>3)
    {
        return true;
    }
}