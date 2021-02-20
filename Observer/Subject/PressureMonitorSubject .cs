using System;
using System.Collections.Generic;

namespace Observer
{
    public  class PressureMonitorSubject : IPressureMonitorSubject
    {
        private double pressure;

        private HashSet<IPressureMonitorObserver> observers;

        public double Pressure
        {
            get { return pressure; }
            set
            {
                var oldPressure = pressure;
                if (oldPressure != value)
                {
                    pressure = value;
                    NotifyPressure();
                }
            }
        }

        public PressureMonitorSubject()
        {
            observers = new HashSet<IPressureMonitorObserver>();
            Console.WriteLine("Star read pressure");
        }

        public void NotifyPressure()
        {
            foreach (var observer in observers)
            {
                observer.OnPressureChanged(pressure);
            }
        }

        public void RegisterObserver(IPressureMonitorObserver observer)
        {
            observers.Add(observer); 
        }

        public void RegisterObserver(params IPressureMonitorObserver[] observer)
        {
            foreach(var ob in observer)
                observers.Add(ob);
        }

        public void UnregisterObserver(IPressureMonitorObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
