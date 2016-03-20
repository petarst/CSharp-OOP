


namespace _01.MobilePhone
{
    using System;

    class Battery
    {
         public enum BatteryType
        {LiIon, NiMH, NiCd}

         private string model;
         private double? hoursIdle;
         private double? hoursTalk;

         public Battery(string model)
         {
             this.model = model;
             this.hoursIdle = null;
             this.hoursTalk = null;
         }
         public Battery(string model,double hoursIdle, double hoursTalk)
             : this (model)
         {
             this.hoursIdle = hoursIdle;
             this.hoursTalk = hoursTalk;
         }

         public string Model 
         {
             get { return this.model; }
             set 
             {
                 if (value == null || value.Length >0)
                 {
                     this.model = value;
                 }
                 else
                 {
                     throw new ArgumentException("Please, you have to enter battery model!");
                 }
             } 
         }
         public double? HoursIdle
         {
             get { return this.hoursIdle; } 
             set
             {
                      if (value == null || value > 0)
                 {
                     this.hoursIdle = value;
                 }
                 else
                 {
                     throw new ArgumentException("Please, you have to enter positive number for hours idle!");
                 }
             }
         }

         public double? HoursTalk 
         {
             get { return this.hoursTalk; } 
             set 
             {
                 if (value == null || value >0)
                 {
                     this.hoursTalk = value; 
                 }

                 else
                 {
                     throw new ArgumentException("Please, you have to enter positive number for hours talk!");
                 }
             }
         }




    }
}
