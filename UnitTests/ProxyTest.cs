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

            Console.WriteLine("---- �����I�s ----");
            new Proxy.Game.RealGameDisplay().Display();

            Console.WriteLine("=================");

            Console.WriteLine("---- �ϥΥN�z(�����N�z Virtual Proxy) ----");
            new Proxy.Game.ProxyGameDisplay(new Proxy.Game.RealGameDisplay()).Display();

        }

        [TestMethod]
        public void TestPerson()
        {
            Console.WriteLine("=================");

            Console.WriteLine("---- �����I�s ----");
            Proxy.Person.IPerson realPerson = new Proxy.Person.PersonBean();
            realPerson.SetLikeCount(10);
            Console.WriteLine("like " + realPerson.GetLikeCount());

            Console.WriteLine("=================");

            Console.WriteLine("---- �ϥΥN�z(�O�@�N�z Protection Proxy) ----");
            Proxy.Person.IPerson proxy = new Proxy.Person.ProxyPersonBean(new Proxy.Person.PersonBean());
            proxy.SetLikeCount(10);
            Console.WriteLine("like " + proxy.GetLikeCount());
        }

        [TestMethod]
        public void TestAOP()
        {
            Console.WriteLine("=================");
            Console.WriteLine("---- �����I�s RealCalculate ----");
            Proxy.AOP.ICalculate realCalculate = new Proxy.AOP.RealCalculate();
            realCalculate.Add(0, 2);

            Console.WriteLine("=================");
            Console.WriteLine("---- �ϥΥN�z(AOP) ProxyCalculate ----");
            Proxy.AOP.ICalculate proxy = new Proxy.AOP.ProxyCalculate(realCalculate);
            proxy.Add(0, 2);

            Console.WriteLine("=================");
            Console.WriteLine("---- �����I�s RealFightManager ----");
            Proxy.AOP.IFightManager realFightManager = new Proxy.AOP.RealFightManager();
            realFightManager.DoFight("POPO");

            Console.WriteLine("=================");
            Console.WriteLine("---- �ϥΥN�z(AOP) ProxyFightManager ----");
            Proxy.AOP.IFightManager proxyFightManager = new Proxy.AOP.ProxyFightManager(realFightManager);
            proxyFightManager.DoFight("POPO");
        }
    }
}
