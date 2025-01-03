

using _1.Letters;

List<Newsletter> day= new List<Newsletter>();
List<Newsletter> week= new List<Newsletter>();

int n=int.Parse(Console.ReadLine());

if(n<0 || n > 100)
{
    Console.WriteLine("You should enter number above 0 and below 100!");
}
else
{
	for (int i = 0; i < n; i++)
	{
		string[] lineToken = Console.ReadLine().Split(" ");
		
		string name=lineToken[0];
		double pages=double.Parse(lineToken[1]);

		if(lineToken.Length == 4)
		{
			double issueNumber=double.Parse(lineToken[2]);
			string periodicity=lineToken[3];

			if (periodicity == "ежедневник")
			{
			   day.Add(new Newsletter(name, pages,issueNumber,periodicity));			
			}
			else if(periodicity == "седмичнициk")
			{
				week.Add(new Newsletter(name, pages, issueNumber, periodicity));
			}
			else
			{
				continue;
			}
		}
		else
		{
            Console.WriteLine("Invalid input!");
        }
	}
}

foreach (var d in day)
{
    Console.WriteLine(d.ToString());
}

foreach(var w in week)
{
    Console.WriteLine(w.ToString());
}