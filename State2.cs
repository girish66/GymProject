using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProject
{
    class State2 : Member
    {
        static string Subscription = "Gold";
        State2 currentpermission(Member mem)
        {
            return (State2)mem;
        }
        public static string getSubscription()
        {
            return Subscription;
        }
    }
}
