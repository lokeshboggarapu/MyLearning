using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDemographics
{
    
        public class Patient
        {

            //note this has to  be private at INTRVIEW
            public String patientName;
            public string patientDOB;
            public enum patientGender { Male, Female, skin };
            patientGender ax;
            public String Disease;
            public string address;
            public Patient(String patientName, string patientDOB, patientGender a, String Disease,String address)
            {

                if (ax.ToString() == "" || ax.ToString() == null || patientDOB.Trim().Length == 0 || patientDOB == null || patientName.Trim().Length == 0 || patientName == null || Disease.Trim().Length == 0 || Disease == null || address.Trim().Length == 0 || address == null)
                {
                    throw new Exception("Illegal arguments passed");

                }
                this.patientName = patientName;
                this.patientDOB = patientDOB;
                this.ax = a;
                this.Disease = Disease;
            
            }
            public String getDisease()
            {
                return Disease;

            }
            public void setpatientGender(patientGender a)
        {
            this.ax= a;
        }
            public string getpatientGender()
            {
                return ax.ToString();

            }

        }
        

        
}
