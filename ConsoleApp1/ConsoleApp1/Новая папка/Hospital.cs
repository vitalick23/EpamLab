using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hospital
    {
        public Hospital(string hospitalName)
        {
            name = hospitalName;
            Secessions = new LinkedList<Secession>();
            AllDisease = new LinkedList<Disease>();
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public LinkedList<Secession> Secessions;

        public LinkedList<Disease> AllDisease;

        public string FoundPatientOnDiseanse(String diseanseName)
        {
            AllDisease.AddFirst(new Disease("qwe"));
            Disease disease = new Disease(diseanseName);
            if (CheckDisease(diseanseName))
            {
                return "Count Patient: " + ComputePatient(diseanseName); 
            }
            else return "Disease not found";
           
        }

        private bool CheckDisease (string diseanseName)
        {
            foreach (var dis in AllDisease)
            {
                if (dis.Name == diseanseName) return true;
            }
            return false;
        }

        private int ComputePatient(string diseanseName)
        {
            int CountPatient = 0;
                foreach (var s in Secessions)
                {
                    foreach (var p in s.Patients)
                    {
                        foreach (var d in p.Diseases)
                        {
                            if (d.Name == diseanseName) CountPatient++;
                        }
                    }
                }
            return CountPatient;
        }
    }
}
