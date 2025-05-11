
using _01.EliBooks;
using System.Text;

var authorBooks = new Dictionary<Author,List<string>>();

string input = "";
while((input = Console.ReadLine()) != "stop")
{
    var books=new List<string>();
    var lineToken = input.Split("; ");
    string bookName=Console.ReadLine();
    string author = lineToken[0];
    string nationality=lineToken[1];
    string genre=lineToken[2];
    Author currAuthor = new Author(author, nationality, genre);

    if (authorBooks.ContainsKey(currAuthor))
    {
        authorBooks[currAuthor].Add(bookName);
    }
    else
    { 
        books.Add(bookName);
        authorBooks.Add(currAuthor, books);
    }
}

Console.WriteLine();

foreach (var item in authorBooks)
{
    Console.WriteLine(item.Key.ToString());
    Console.WriteLine(string.Join("; ", item.Value));
}

/*David Baldacci; USA; thriller
Absolute Power
Lee Child; England; thriller
Killing Floor
David Baldacci; USA; thriller
Hour Game
David Baldacci; USA; thriller
Long Shadows
stop*/
