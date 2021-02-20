using Observer.Event;
using System;

namespace Observer.Observer
{
    public class Computer : IPressureMonitorObserver, IPressureMonitorEvent
    {
        public void OnPressureChanged(double pressure)
        {
            Console.WriteLine($"PC is notified that the air pressure has changed: {pressure}");
        }

        public void OnPressureChangedEvent(object sender, double pressure)
        {
            Console.WriteLine($"PC is notified that the air pressure has changed by Delegate: {pressure}");
        }
    }
}
