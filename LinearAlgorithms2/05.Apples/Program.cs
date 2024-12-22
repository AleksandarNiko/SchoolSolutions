

double appleHarvest = 50;
int currentYear = 2023;

while (appleHarvest!=100)
{
    appleHarvest *= (1 + 0.05);
    currentYear += 2;
}

Console.WriteLine($"Реколтата ще достигне 100 тона през {currentYear}г.");