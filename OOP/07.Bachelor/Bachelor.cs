using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bachelor
{
    public class Bachelor
    {
        private double grade;
        public string Name { get; set; } = null!;

        public double[] Grades { get; set; } = new double[5];

        public string areValidGrades()
        {
            return Grades.Any(x => x < 2 || x > 6) ? "no" : "yes";
        }

        public double GetScholarship()
        {
            double money = 0;
            double averageGrade = AverageGrade();
            if (averageGrade >= 4.50 && averageGrade <= 5.49)
            {
                money = 60;
            } 
            else if(averageGrade >= 5.50 && averageGrade <= 6.00)
            {
                money = 100;
            }
            return money;
        }

        private double AverageGrade()
        {
            return Math.Round(Grades.Average(x => x),2);
        }

        public override string ToString()
        {
            return $"{Name} {AverageGrade()} {GetScholarship()}";
        }

    }
}
