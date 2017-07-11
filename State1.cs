using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProject
{
    class State1 : Member
    {
        static string Subscription = "Silver";
        State1 currentpermission(Member mem)
        {
            return (State1)mem;
        }
        public static string getSubscription()
        {
            return Subscription;
        }
    }
}
