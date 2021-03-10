using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProxyTest
    {
        [TestMethod]
        public void TestGameLoad()
        {
            Console.WriteLine("=================");

            Console.WriteLine("---- 直接呼叫 ----");
            new Proxy.Game.RealGameDisplay().Display();

            Console.WriteLine("=================");

            Console.WriteLine("---- 使用代理(虛擬代理 Virtual Proxy) ----");
            new Proxy.Game.ProxyGameDisplay(new Proxy.Game.RealGameDisplay()).Display();

        }

        [TestMethod]
        public void TestPerson()
        {
            Console.WriteLine("=================");

            Console.WriteLine("---- 直接呼叫 ----");
            Proxy.Person.IPerson realPerson = new Proxy.Person.PersonBean();
            realPerson.SetLikeCount(10);
            Console.WriteLine("like " + realPerson.GetLikeCount());

            Console.WriteLine("=================");

            Console.WriteLine("---- 使用代理(保護代理 Protection Proxy) ----");
            Proxy.Person.IPerson proxy = new Proxy.Person.ProxyPersonBean(new Proxy.Person.PersonBean());
            proxy.SetLikeCount(10);
            Console.WriteLine("like " + proxy.GetLikeCount());
        }

        [TestMethod]
        public void TestAOP()
        {
            Console.WriteLine("=================");
            Console.WriteLine("---- 直接呼叫 RealCalculate ----");
            Proxy.AOP.ICalculate realCalculate = new Proxy.AOP.RealCalculate();
            realCalculate.Add(0, 2);

            Console.WriteLine("=================");
            Console.WriteLine("---- 使用代理(AOP) ProxyCalculate ----");
            Proxy.AOP.ICalculate proxy = new Proxy.AOP.ProxyCalculate(realCalculate);
            proxy.Add(0, 2);

            Console.WriteLine("=================");
            Console.WriteLine("---- 直接呼叫 RealFightManager ----");
            Proxy.AOP.IFightManager realFightManager = new Proxy.AOP.RealFightManager();
            realFightManager.DoFight("POPO");

            Console.WriteLine("=================");
            Console.WriteLine("---- 使用代理(AOP) ProxyFightManager ----");
            Proxy.AOP.IFightManager proxyFightManager = new Proxy.AOP.ProxyFightManager(realFightManager);
            proxyFightManager.DoFight("POPO");
        }
    }
}
