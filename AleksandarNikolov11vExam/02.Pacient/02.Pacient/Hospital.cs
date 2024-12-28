using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pacient
{
    public class Hospital
    {
        private string name;
        public Hospital(string name)
        {
            Name = name;
            Patients = new List<Patient>();
        }

        public  string Name { get=>name; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                name = value;
            }
        }

        public  List<Patient> Patients { get; set; }

        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public Patient FindPatientByName(string name)
        {
            Patient patient = null;

            foreach (Patient pat in Patients)
            {
                if (pat.Name == name) 
                {
                    patient = pat;
                }
            }

            return patient;
        }

        public List<Patient> FindPatientsByDiagnose(string diagnose)
        {
            List<Patient> patients=new List<Patient> ();

            foreach (Patient pat in Patients)
            {
                if (pat.Diagnose == diagnose)
                {
                    patients.Add(pat);
                }
            }

            return patients;
        }

        public Patient FindPatientByDiapason(byte minAge,byte maxAge)
        {
            Patient patient = null;
            foreach (Patient pat in Patients)
            {
                if(pat.Age>=minAge && pat.Age <= maxAge)
                {
                    patient=pat;
                }
            }

            return patient;
        }

        public override string ToString()
        {
            StringBuilder sb= new StringBuilder();

            sb.AppendLine("Patients:");
            foreach (Patient pat in Patients)
            {
                sb.AppendLine(pat.ToString());
            }

            return sb.ToString();
        }
    }
}
