
using _01.Book;

Book[] books = new Book[5];

Console.WriteLine("Въведи информация за 5 книги, всяка на нов ред във формат: име;автор;жанр");
for (int i = 0; i < books.Length; i++)
{
    string[] lineToken = Console.ReadLine()!.Split(";");
    string name = lineToken[0];
    string author = lineToken[1];
    string genre = lineToken[2];
    books[i] = new Book(name, author, genre);
}

foreach (Book book in books)
{
    Console.WriteLine(book.ToString());
}
