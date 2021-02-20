using System;

namespace Observer
{
    public class PressureMonitorEventMethod
    {
        public event EventHandler<double> OnPressureChanged;

        private double pressure;

        public double Pressure
        {
            get { return pressure; }
            set
            {
                var oldPressure = pressure;
                if (oldPressure != value)
                {
                    pressure = value;
                    if (OnPressureChanged != null)
                    {
                        OnPressureChanged(this, value);
                    }
                }
            }
        }
    }
}
