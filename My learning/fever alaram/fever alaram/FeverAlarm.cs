using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fever_alaram
{
    
    public class Temperature
    {
        public enum SCALE
        {
            CELCIUS, FARHENHEAT, KELVIN
        }
        public enum RECOREDTYPE
        {
            ARMPITS, MOUTH
        }
        public enum RECORDEDDURING
        {
            MORNING, AFTERNOON, EVENING
        }
        private double temperature;
        private SCALE scale;
        private RECOREDTYPE recordedFrom;
        private RECORDEDDURING partOfDay;
        private DateTime timeStamp;
        // private Patient patient;

        

        public Temperature(double temperature, SCALE scale, RECOREDTYPE recordedFrom, RECORDEDDURING partOfDay,
                DateTime timeStamp)
        {
           
            this.temperature = temperature;
            this.scale = scale;
            this.recordedFrom = recordedFrom;
            this.partOfDay = partOfDay;
            this.timeStamp = timeStamp;
            // this.patient = patient;
        }

        public double getTemperature()
        {
            return temperature;
        }

        public SCALE getScale()
        {
            return scale;
        }

        public RECOREDTYPE getRecordedFrom()
        {
            return recordedFrom;
        }

        public RECORDEDDURING getPartOfDay()
        {
            return partOfDay;
        }

        public DateTime getTimeStamp()
        {
            return timeStamp;
        }
        
        public void setTemperature(double temperature) {
		this.temperature = temperature;
		
	}

	public void setScale(SCALE scale) {
		this.scale = scale;
	
	}

	public void setRecordedFrom(RECOREDTYPE recordedFrom) {
		this.recordedFrom = recordedFrom;
	

	}

	public void setPartOfDay(RECORDEDDURING partOfDay) {
		this.partOfDay = partOfDay;
		
	}

	public void setTimeStamp(DateTime timeStamp) {
		this.timeStamp = timeStamp;
		
	}
        // Below method is used to convert patient temperature to celcius
	private double convertedTemperature(double temp, SCALE scale) {
        if (scale.Equals(SCALE.FARHENHEAT))
			return ((temp - 32) * (5 / 9));
		else {
			return (temp - 273.15);
		}
	}
         public bool isHavingFever(Temperature t) {
		 double normalTemperaute = 98.6;
		double patientTemperature = 0.0;
		if (t.getScale().Equals(SCALE.CELCIUS)) {
			patientTemperature = t.getTemperature();
		} else {
			patientTemperature = convertedTemperature(t.getTemperature(), t.getScale());
		}

		if (patientTemperature > normalTemperaute) {
			return true;
		} else {
			return false;
		}


	}

    }

   
	
}
