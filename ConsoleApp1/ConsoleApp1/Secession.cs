using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Secession
    {
        public Secession(string secessionName)
        {
            name = secessionName;
            Patients = new LinkedList<Patient>();
        }

        public Secession (string secessionName, LinkedList <Patient> patient)
        {
            name = secessionName;
            Patients = patient;
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

        public LinkedList<Patient> Patients;

    }
}
