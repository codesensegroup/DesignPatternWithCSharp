using System;

namespace Observer
{
    public  class PressureMonitorDelegateMethod
    {
        public delegate void PressureChangedHandler(double tempature);

        public PressureChangedHandler OnPressureChanged;

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
                    OnPressureChanged.Invoke(value);
                }
            }
        }

        public PressureMonitorDelegateMethod()
        {           
            OnPressureChanged = PressureChanged;
        }

        private void PressureChanged(double pressure)
        {
            Console.WriteLine($"Pressure changed...{pressure}");
        }
    }
}
