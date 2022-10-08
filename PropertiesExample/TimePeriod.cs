using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
   
   public class TimePeriod
    {
        private double seconds;
        public TimePeriod()
        {
            this.seconds = 0;
        }
        //Define a property to read and write to the variable seconds.
        public double Seconds
        {
            get
            {
                return this.seconds;
            }
            set
            {
                this.seconds = value;
            }
        }

        //Another option to do the same without the seconds variable!
        //public double Seconds { get; set; }
        //you can define permissions
        //public double Seconds { get; private set; }
        //Define Hours property that expose another way of reading seconds as hours with verification
        public double Hours
        {
            get
            {
                return this.seconds / 3600;
            }
            set
            {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException("Hours must be between 0 and 24.");
                this.seconds = value * 3600;
            }
        }

        public double Days
        {
            get
            {
                return this.seconds / (24 * 3600);
            }
            set
            {
                this.seconds = value * 24 * 3600;
            }
        }

        public override string ToString()
        {
            return $"Period in Days: {Days:F0} in Hours: {Hours} in Seconds: {Seconds}";
        }
    }
    }
