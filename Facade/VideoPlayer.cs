using System;

namespace Facade
{
    public class VideoPlayer : IPlayer
    {
        private DVD _dvd;
        private int _time = 0;

        public void On() {
            Console.WriteLine("Powered on");
        }

        public void Insert(DVD dvd)
        {
            _dvd = dvd;
            Console.WriteLine($"Inserting {dvd.Name}");

        }

        public void Play()
        {
            Console.WriteLine("Playing "+ _dvd.Name);
        }

        public void Pause()
        {
            Console.WriteLine($"Pausing at {_time = (new Random()).Next(_time, _time + 120)}");
        }

        public void Resume()
        {
            Console.WriteLine($"Resuming from {_time}");
        }
    }
}
