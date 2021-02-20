namespace Observer
{
    public interface IPressureMonitorSubject
    {
        void RegisterObserver(IPressureMonitorObserver observer);

        void UnregisterObserver(IPressureMonitorObserver observer);

        void NotifyPressure();
    }
}
