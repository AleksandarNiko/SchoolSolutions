using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.StudentSystem.Interfaces;

namespace _07.StudentSystem
{
    public class Stipendiant : IStudent,IScholarship
    {
        public Stipendiant(string name, double income)
        {
            Name = name;
            Ocenki = new List<int>();
            Income = income;
        }

        public  string Name { get; set; }

        public  List<int> Ocenki { get; set; }

        public  double Income { get; set; }




        public bool Approval()
        {
            double avgGrd = AverageSuccess();

            if (avgGrd >= 4.50)
            {
                return true;
            }
            return false;
        }

        public double AverageSuccess()
        {
            double sum = 0;

            foreach (int i in Ocenki)
            {
                sum += i;
            }

            double avg = sum / Ocenki.Count;

            return avg;
        }

        public string Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Име: {Name}");
            sb.AppendLine($"Среден успех: {AverageSuccess()}");
            if (Approval() == true)
            {
                sb.AppendLine($"Стипендия: да");
                sb.AppendLine($"Сума: {Suma():f2}");
            }
            else
            {
                sb.AppendLine($"Стипендия: не");
            }

            return sb.ToString();
        }

        public string KindScholarship()
        {
            string type = "";
            double avgGrd = AverageSuccess();

            if (avgGrd >= 4.50 && avgGrd <= 5.50 && Income < 940)
            {
                type = "социална стипендия";
            }
            else if (avgGrd > 5.50)
            {
                type = "стипендия по успех";
            }
            else
            {
                type = "Не получава стипендия";
            }
            return type;
        }

        public double Suma()
        {
            string typeMoney = KindScholarship();
            double sum = 0;

            if (typeMoney == "социална стипендия")
            {
                sum = 120;
            }
            else if (typeMoney == "стипендия по успех")
            {
                sum = 180;
            }
            else
            {
                sum = 0;
            }

            return sum;
        }
    }
}
