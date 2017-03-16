using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allergy_class;

namespace Allergy_class
{
    class main
    {
        static void Main(string[] args)
        {
            allergy b = new allergy(Allergy_class.allergy.allergy_type.SKIN, "Redness", "HOT", "Parent", "High");
            b.getallergy_type();
        }
    }
}
