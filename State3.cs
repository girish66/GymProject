using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProject
{
    class State3 : Member
    {
        static string Subscription = "Premium";
        State3 currentpermission(Member mem)
        {
            return (State3)mem;
        }
        public static string getSubscription()
        {
            return Subscription;
        }
    }
}
