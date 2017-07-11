using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProject
{
    public class SingelUser
    {
        private static Lazy<SingelUser> instance = new Lazy<SingelUser>(() => new SingelUser());

        private SingelUser() { }

        private Person person;

        public static SingelUser Instance
        {
            get
            {
                if (instance.IsValueCreated == false)
                {
                    instance = new Lazy<SingelUser>(() => new SingelUser());
                }
                return instance.Value;
            }
        }

        public void set_user(Person person)
        {
            this.person = person;
        }

     
        public Person get_user()
        {
            return this.person;
        }
    }
}
