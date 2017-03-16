using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDemographics
{
    class Mains
    {
        static void Main(string[] args)
        {

            Patient P = new Patient("LOKESH", "2017.04.02 02:03:04:0000", Patient.patientGender.Male, "GOOD", "lees summit");
            P.getpatientGender();
        }
   
    }
}
