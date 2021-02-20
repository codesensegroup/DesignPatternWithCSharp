using Observer.Observer;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Observer
            var pressureMonitor = new PressureMonitorSubject();
            var pc = new Computer();
            var cellphone = new CellPhone();

            pressureMonitor.RegisterObserver(pc, cellphone);
            pressureMonitor.Pressure = 50;

            Console.WriteLine();

            // You also can use deligate method in this case
            var pressureMonitorDeligate = new PressureMonitorDelegateMethod();
            pressureMonitorDeligate.OnPressureChanged += pc.OnPressureChanged;
            pressureMonitorDeligate.OnPressureChanged += cellphone.OnPressureChanged;
            pressureMonitorDeligate.Pressure = 70;
        }
    }
}
