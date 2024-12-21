
Console.Write($"Въведи работни дни за месец: ");
int workDaysInMonth=int.Parse(Console.ReadLine()!);
Console.Write($"Въведи пари за ден в долари: ");
decimal moneyPerDayInUS =decimal.Parse(Console.ReadLine()!);
Console.Write($"Въведи курс на долар: ");
decimal dollarRate =decimal.Parse(Console.ReadLine()!);

decimal monthSalary = workDaysInMonth * moneyPerDayInUS;
decimal yearSalary = (12 * monthSalary) + (2.5m * monthSalary);

decimal yearSalaryWithTaxes = yearSalary - (yearSalary * 0.25m);

decimal yearSalaryInLev = yearSalaryWithTaxes * dollarRate;

decimal averageDayMoneyInLev = yearSalaryInLev / 365;
Console.WriteLine($"Чистата средна печалба на Иван на ден в лева е {averageDayMoneyInLev:f2}лв.");

