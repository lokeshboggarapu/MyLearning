using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Medication_Alarm
{
    
 public class Medication{

    public enum FREQUENCY { HOURLY,DAILY,LIFETIME}
    public enum UNITS {COUNT,MG,ML}
	private int id;
	private String drugName;
	private String drugManufacturer;
	private DateTime startDate;
	private DateTime endDate;
	private double dose;
	private String reasonToStop;
	private FREQUENCY frequency;
	private UNITS units;
	private bool continueMedication;
	private int nurseId;



	public Medication(int id, String name, String brand, DateTime start, DateTime end, double quantity, String reasonToStop,
			FREQUENCY frequency, UNITS units) 
    {
		this.id = id;
		this.drugName = name;
		this.drugManufacturer = brand;
		this.startDate = start;
		this.endDate = end;
		this.dose = quantity;
		this.reasonToStop = reasonToStop;
		this.frequency = frequency;
		this.units = units;
	}

	public int getId() {
		return id;
	}

	public String getDrugName() {
		return drugName;
	}

	public String getDrugManufacturer() {
		return drugManufacturer;
	}

	public DateTime getStartDate() {
		return startDate;
	}

	public DateTime getEndDate() {
		return endDate;
	}

	public double getDose() {
		return dose;
	}

	public String getReasonToStop() {
		return reasonToStop;
	}

	public FREQUENCY getFrequency() {
		return frequency;
	}

	public UNITS getUnits() {
		return units;
	}

	public bool isContinueMedication() {
		return continueMedication;
	}

	public int getNurseId() {
		return nurseId;
	}

     public void alertNurse()  {
         switch (frequency)
         {
		case FREQUENCY.DAILY:
                 Console.WriteLine("DAILY");
			    break;
        case FREQUENCY.HOURLY:
            long sec = getEndDate().Millisecond - getStartDate().Millisecond;			 
			int count=0; 
			if(getFrequency().Equals(Medication_Alarm.Medication.FREQUENCY.HOURLY)){
				count=(int)sec/(60*1000);
			}else if(getFrequency().Equals(Medication_Alarm.Medication.FREQUENCY.DAILY)){
				count=(int)sec/(60*1000*24*60);
				count=count+1;
			}
			if(System.DateTime.Now.Date>=getStartDate().Date)
            {
				for(int i=0;i<count;i++){
					Console.WriteLine("Alarm");
					Thread.Sleep(60*1000);
				}
			
	
	
		}

            break;
	}
	}
}
    
	
}





