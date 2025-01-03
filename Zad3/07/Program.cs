
int h=int.Parse(Console.ReadLine()!);
int m=int.Parse(Console.ReadLine()!);
int t=int.Parse(Console.ReadLine()!);

int totalMinutes = h * 60 + m + t;
int landingHours = (totalMinutes / 60) % 24;
int landingMinutes = totalMinutes % 60;

Console.WriteLine($"Landing at: {landingHours} {landingMinutes}");


