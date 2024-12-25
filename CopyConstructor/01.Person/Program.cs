

using _01.Person;

List<Person> people=new List<Person>();

string input = "";

while(input != "END")
{
    input = Console.ReadLine();
    if(input == "END")
    {
        break;
    }

    string[] lineToken = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string name=lineToken[0];
    byte age=byte.Parse(lineToken[1]);

    people.Add(new Person(name, age));
}

//NotOrderedPeople
foreach (Person person in people)
{
    Console.WriteLine($"{person.Name} -> {person.Age}");
}
Console.WriteLine();

//PeopleBelow17y
List <Person> kids=new List<Person>();
foreach (Person person in people)
{
    if (person.Age <= 17)
    {
        kids.Add(person);
    }
}

foreach (Person kid in kids)
{
    Console.WriteLine($"{kid.Name} -> {kid.Age}");
}
Console.WriteLine();

//PeopleOver18y
List<Person> olds = new List<Person>();
foreach (Person person in people)
{
    if (person.Age >= 18)
    {
        olds.Add(person);
    }
}

foreach (Person old in olds)
{
    Console.WriteLine($"{old.Name} -> {old.Age}");
}
