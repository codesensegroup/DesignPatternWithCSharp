using System;

namespace Observer.Observer
{
    public class CellPhone : IPressureMonitorObserver
    {
        public void OnPressureChanged(double pressure)
        {
            Console.WriteLine($"CellPhone is notified that the air pressure has changed: {pressure}");
        }
    }
}
