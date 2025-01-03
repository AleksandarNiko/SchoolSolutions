
using _02.StudentEquipment;

Backpack[] packs = new Backpack[5];
List<Notebook> notes = new List<Notebook>();
List<Book> books = new List<Book>();

for (int i = 0; i < packs.Length; i++)
{ 
    Console.WriteLine("Учебни тетрадки:");
    for (int j = 0; j < packs.Length; j++)
    {
        string[] lineToken = Console.ReadLine().Split(" ");
        notes.Add(new Notebook(lineToken[0], double.Parse(lineToken[1])));
    }

    Console.WriteLine("Учебници:");
    for (int j = 0; j < packs.Length; j++)
    {
        string[] lineToken = Console.ReadLine().Split(" ");
        books.Add(new Book(lineToken[0], double.Parse(lineToken[1])));
    }

    packs[i].NoteBooks.AddRange(notes);
    packs[i].Books.AddRange(books);
}

for (int i = 0;i < packs.Length; i++)
{
    Console.WriteLine($"{i}.Тегло: {packs[i].AllWeight()}");
}