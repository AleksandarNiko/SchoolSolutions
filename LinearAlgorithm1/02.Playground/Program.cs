Console.Write("Въведи метри на площадката:");
int playgroundSideMeters=int.Parse(Console.ReadLine()!);
int playgroungArea = playgroundSideMeters * playgroundSideMeters;

Console.Write($"Въведи ширината на една плочка в метри: ");
int tileWidth = int.Parse((Console.ReadLine()!));
Console.Write($"Въведи дължината на една плочка в метри: ");
int tileLength=int.Parse((Console.ReadLine()!));
int tileArea=tileWidth * tileWidth;

Console.Write($"Въведи ширината на пейката в метри: ");
int benchWidth=int.Parse((Console.ReadLine()!));
Console.Write($"Въведи дължината на пейката в метри: ");
int benchLength =int.Parse((Console.ReadLine()!));
int benchArea=benchWidth * benchWidth;

const double tileTime = 0.2;

int neededArea=playgroungArea-benchArea;
double neededTiles=neededArea/tileArea;

double neededTime=neededTiles*tileTime;

Console.WriteLine($"Необходимо време: {neededTime}");



