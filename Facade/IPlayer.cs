using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public interface IPlayer
    {
        void On();
        void Insert(DVD dvd);
        void Play();
        void Pause();
        void Resume();
    }
}
