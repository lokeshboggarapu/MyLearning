using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medication_Alarm
{
  public class Program {

	public static void main(String[] args)
    {

        DateTime time = DateTime.Now;             // Use current time.
        string format = "MMM ddd d HH:mm yyyy";   // Use this format.
        Console.WriteLine(time.ToString(format));    
		String dateInString = "20-06-2016 10:22:00 PM";
		
		String dateInString1 = "22-06-2016 10:24:00 PM";
        Medication m = new Medication(1,"lokesh","ranbaxy",DateTime.Now,DateTime.Now,10.2,"xcv",Medication.FREQUENCY.DAILY,Medication.UNITS.MG);
	//	Medication m = new MedicationBuilder().setStartDate(date).setEndDate(date1).setFrequency(FREQUENCY.HOURLY).getInstance();
		//ScheduledMedication s = new MedicationSevices();
		//s.alertNurse(m);     
	}
}

}
