
double number=double.Parse(Console.ReadLine()!);

double currNum = number;

for (int i = 0; i < 15; i++)
{
    Console.Write(currNum+" ");
    currNum += -3;
}
