namespace HW1Version2.Library
{
    using System;
    using System.Text;

    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;

        

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
    public int HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }
    public int HoursIdle
    {
        get { return hoursIdle; }
        set { hoursIdle = value; }
    }
    public BatteryType BatteryType
    {
        get { return batteryType; }
        set { batteryType = value; }
    }
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        if (this.Model == null)
        {
            result.AppendLine("No battery");
        }
        else
        {
            result.AppendLine(string.Format ("Model is {0}", this.Model));
            result.AppendLine(string.Format("Battery type is {0}", this.BatteryType));
            result.AppendLine(string.Format("Hours Idle is {0}", this.HoursIdle));
            result.AppendLine(string.Format("Hours Talk is {0}", this.HoursTalk));
        }
        return result.ToString();

    }

    }
}
