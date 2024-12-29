using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Pupils
{
    public class Pupil
    {
        private string name;
        private double[] grades=new double[5];
        public string Name { get => name; private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name");
                }
                name = value;
            }
        }

        public double[] Grades
        {
            get => grades; private set
            {
                for (int i = 0; i < grades.Length; i++)
                {
                    if (value[i] < 2 || value[i] > 6)
                    {
                        throw new ArgumentException("Invalid grade!");
                    }
                    grades[i] = value[i];
                }
            }
        }

        public Pupil(string name, double[] grades)
        {
            this.Name = name;
            this.Grades = grades;
        }

        public double AverageGrade()
        {
            return Math.Round(Grades.Average(),2);
        }

        public override string ToString()
        {
            return $"{Name} {AverageGrade()}"
                .ToString()
                .Trim();
        }
    }
}
