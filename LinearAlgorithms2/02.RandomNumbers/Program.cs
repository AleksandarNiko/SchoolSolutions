
Random r=new Random();
int number = r.Next(1, 10000);
int evenCount = 0;
for (int i = 0; i < number.ToString().Length; i++)
{
    if(i%2==0) evenCount++;
}
Console.WriteLine($"Number: {number}");
Console.WriteLine($"Even nums: {evenCount}");