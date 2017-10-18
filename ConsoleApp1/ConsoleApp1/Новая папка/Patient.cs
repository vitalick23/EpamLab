using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Patient
    {
        public Patient (string patientName)
        {
            name = patientName;
            Diseases = new LinkedList<Disease>();
        }

        public Patient(string patientName, LinkedList<Disease> patientDisease)
        {
            name = patientName;
            Diseases = patientDisease;
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

        public LinkedList<Disease> Diseases;
        

    }
}
