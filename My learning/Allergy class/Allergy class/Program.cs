using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allergy_class
{
    class allergy
    {

        //note this has to  be private at INTRVIEW
        public enum allergy_type { SKIN, DUST, SMOKE };
         allergy_type ax;
         public String symptoms;
         public String reactions;
         public String severity;
         public String reporter;


        public allergy(allergy_type a, String symptoms, String reactions, String reporter, String severity)
        {
            if (a.ToString() == "" || a.ToString() == null || symptoms.Trim().Length == 0 || symptoms == null || reactions.Trim().Length == 0 || reactions == null || reporter.Trim().Length == 0 || reporter == null || severity.Trim().Length == 0 || severity == null)
            {
                throw new Exception("Illegal arguments passed");

            }
            this.ax = a;
            this.symptoms = symptoms;
            this.reactions = reactions;
            this.reporter = reporter;
            this.severity = severity;
        }

        public string getallergy_type()
        {
            return ax.ToString();

        }
        public void setallergy_type(allergy_type a)
        {
            this.ax = a;
        }

       
    }
}
