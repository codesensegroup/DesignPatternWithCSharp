using System;

namespace Proxy.AOP
{
    public class RealFightManager : IFightManager
    {
        public void DoFight(string username)
        {
            Console.WriteLine(username + " 帶領冒險者們與無辜的怪物戰鬥");
            Console.WriteLine("......正在戰鬥中.....");
            Console.WriteLine(username + " 帶領冒險者們洗劫怪物的家，結束一場慘無妖道的屠殺!!");
        }
    }
}
