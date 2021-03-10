using System;

namespace Proxy.Game
{
    public class RealGameDisplay : IGameDisplay
    {
        public void Display()
        {
            Console.WriteLine("顯示遊戲畫面");
        }
    }
}
