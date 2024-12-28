
using _01.CatWorld;
using System.Runtime.CompilerServices;

//A)
Felidae felidae = new Felidae();

//Б)
Felidae felidae1 = new Felidae(false);

//В)
Console.WriteLine(felidae.Male);
Console.WriteLine(felidae1.Male);

//Г)
List<AfricanLion> africanLions=new List<AfricanLion>();
string input = "";
Console.WriteLine("Constraints: Мъжки пол=true; Женски пол=false; Тегло: цяло число");
Console.WriteLine("Въвеждай информация за африкански лъвове във формат: <пол> <тегло>!");
Console.WriteLine("Въведи END за край на програмата!");
while (input != "END")
{
    input = Console.ReadLine().ToUpper();
    if(input == "END")
    {
        break;
    }

    string[] lineToken=input.Split(' ');
    bool type=bool.Parse(lineToken[0]);
    int weight=int.Parse(lineToken[1]);
    africanLions.Add(new AfricanLion(type, weight));
}

//Д)
foreach (var item in africanLions)
{
    Console.WriteLine(item.ToString());
}

//E)
var males=new List<AfricanLion>();
var females=new List<AfricanLion>();

foreach (var item in africanLions)
{
    if (item.LionMale() == "male")
    {
        males.Add(item);
    }
    else 
    {
        females.Add(item);
    }
}
Console.WriteLine((males.Max(m=>m.Weight)).ToString());
Console.WriteLine((females.Max(f=>f.Weight)).ToString());
