Gardener();



static void Gardener()
{
    Console.Write("Въведи килограми за зеленчуци: ");
    int vegKg = int.Parse(Console.ReadLine()!);

    Console.Write("Въведи килограми за плодове: ");
    int fruitKg = int.Parse(Console.ReadLine()!);

    Console.Write("Въведи цена за зеленчуци: ");
    decimal vegPrice = decimal.Parse(Console.ReadLine()!);

    Console.Write("Въведи цена за плодове: ");
    decimal fruitPrice = decimal.Parse(Console.ReadLine()!);

    decimal vegFinalPrice = (vegKg * vegPrice) * 1.94m;
    decimal fruitFinalPrice = (fruitKg * fruitPrice) * 1.94m;

    Console.WriteLine($"{vegKg} кг зеленчуци на цена: {vegPrice} - Приход: {vegFinalPrice:f2} евро.");
    Console.WriteLine($"{fruitKg} кг плодове на цена: {vegPrice} - Приход: {fruitFinalPrice:f2} евро.");
    Console.WriteLine($"Общ приход: {vegFinalPrice + fruitFinalPrice:f2} евро.");
}
