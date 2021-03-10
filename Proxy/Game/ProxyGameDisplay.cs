using System;

namespace Proxy.Game
{
    public class ProxyGameDisplay : IGameDisplay
    {
        private readonly IGameDisplay _gameDisplay;

        public ProxyGameDisplay(IGameDisplay gameDisplay)
        {
            this._gameDisplay = gameDisplay;
        }

        public void Display()
        {
            Console.WriteLine("遊戲讀取中.....");
            _gameDisplay.Display();
        }
    }
}
