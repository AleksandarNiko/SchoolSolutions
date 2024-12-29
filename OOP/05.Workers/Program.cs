
using _05.Workers;

Worker[] workers = new Worker[3];

for (int i = 0; i < workers.Length; i++)
{
    workers[i] = new Worker()
    {
        Name = Console.ReadLine(),
        Work = Console.ReadLine(),
        Hours=int.Parse(Console.ReadLine()),
        Money=decimal.Parse(Console.ReadLine()),
    };
}

SortByNameAsc(workers);

foreach (Worker worker in workers)
{
    Console.WriteLine(worker.ToString());
}

static void SortByNameAsc(Worker[] workers)
{
    workers = workers.OrderBy(x => x.Name).ToArray();
}