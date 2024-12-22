
//Използвам byte, защото този тип данни е от 0 до 255
Random random = new Random();
byte number = (byte)random.Next(0, 100);

byte sum=0;

for (byte i = 1; i <= number; i++)
{
    sum += (byte)(1 / i);
}

Console.WriteLine(sum);
