using System;

namespace Proxy.Person
{
    public class ProxyPersonBean : IPerson
    {
        private readonly PersonBean _person;

        private string name;
        private int likeCount;


        public ProxyPersonBean(PersonBean person)
        {
            this._person = person;
        }


        public void SetLikeCount(int like)
        {
            Console.WriteLine("無權限修改 like 數");
        }

        public int GetLikeCount()
        {
            return this._person.GetLikeCount();
        }

        public string GetName()
        {
            return this._person.GetName();
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
