namespace Observer
{
    public interface IPressureMonitorObserver
    {
        void OnPressureChanged(double pressure);
    }
}
