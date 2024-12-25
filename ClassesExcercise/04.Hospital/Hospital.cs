using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    public class Hospital
    {
        private string name;
        private string city;
        private string address;

        public Hospital(string name, string city, string address)
        {
            Name = name;
            City = city;
            Address = address;
            Patients=new List<Patient>();
        }

        public string Name { get => name; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                name = value;
            }
        }

        public string City { get => city; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                city = value;
            }
        }

        public string Address { get => address; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                address = value;
            }
        }

        public  List<Patient> Patients { get; set; }

        public Patient FindPatientByName(string name)
        {
            return Patients.FirstOrDefault(p => p.Name == name);

            //Patient patient1 = null;
            //foreach(var patient in Patients)
            //{
            //    if(patient.Name == name)
            //    {  
            //        patient1 = patient;
            //    }
            //    break;
            //}

            //return patient1;
        }

        public Patient FindPatientByDiagnose(string diagnose)
        {
            return Patients.FirstOrDefault(p => p.Diagnose == diagnose);
        }

        public override string ToString()
        {
            var dangers = Patients.Where(p => p.IsDanger() == "заразен");
            var notDangers= Patients.Where(p => p.IsDanger() == "не е заразен");

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Заразни");
            foreach (var danger in dangers) 
            {
                sb.AppendLine(danger.ToString());
            }

            sb.AppendLine("Незаразни");
            foreach (var notDanger in notDangers)
            {
                sb.AppendLine(notDanger.ToString());
            }

            return sb.ToString();
        }
    }
}
