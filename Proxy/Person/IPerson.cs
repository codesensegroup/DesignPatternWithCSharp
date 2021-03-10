using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Person
{
    public  interface IPerson
    {
        void SetLikeCount(int like);
        int GetLikeCount();
        string GetName();
        void SetName(string name);
    }


}
