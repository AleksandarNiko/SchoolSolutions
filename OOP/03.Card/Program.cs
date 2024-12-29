
using _03.Card;

//a) Create instance
Card card = new Card();

//b) Print list of books
Card[] cards=new Card[4];
for (int i = 0; i < 4; i++)
{
    cards[i] = new Card()
    {
        Name = Console.ReadLine(),
        Author=Console.ReadLine(),
        AvaliavableCardsCount=int.Parse(Console.ReadLine()),
    };
}

foreach (var item in cards)
{
    item.PrintInformation();
}

//v)Find a book by: Name;Author
var foundCardByName=cards.FirstOrDefault(c=>c.Name==Console.ReadLine());
var foundCardByAuthor = cards.FirstOrDefault(c => c.Author == Console.ReadLine());

foundCardByName.PrintInformation();
foundCardByAuthor.PrintInformation();


