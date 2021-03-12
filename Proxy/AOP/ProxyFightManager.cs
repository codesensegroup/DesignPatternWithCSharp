using System;

namespace Proxy.AOP
{
    public class ProxyFightManager : IFightManager
    {
        private readonly IFightManager _fightManager;

        public ProxyFightManager(IFightManager fightManager)
        {
            this._fightManager = fightManager;
        }

        public void DoFight(string username)
        {
            Console.WriteLine("開始時間：" + DateTime.Now);
            this._fightManager.DoFight(username);
        }
    }
}
