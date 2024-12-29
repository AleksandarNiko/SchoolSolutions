
using _02.Car;

string brand=Console.ReadLine()!;
string model=Console.ReadLine()!;
double volume=double.Parse (Console.ReadLine()!);
int year=int.Parse (Console.ReadLine()!);

Car car=new Car(brand, model,volume, year);

Console.WriteLine(car.ToString());
