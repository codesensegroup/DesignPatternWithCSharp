using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new PlayerFacade(new DVD("The Lord of the Rings"), new VideoPlayer());

            remoteControl.WatchVideo();
            remoteControl.Pause();
        }
    }
}
