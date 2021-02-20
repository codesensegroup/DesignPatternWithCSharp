namespace Observer.Event
{
    public interface IPressureMonitorEvent
    {
        void OnPressureChangedEvent(object sender, double pressure);
    }
}
