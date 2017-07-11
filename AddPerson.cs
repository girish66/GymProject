using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TheProject
{
    public static class AddPerson
    {
        static Person person;

        public static Person FactoryMethod(String personType)
        {
            switch (personType)
            {
                case "Instractor": person = new Worker();
                    break;
                case "Member": person = new Member();
                    break;
                /* case "סטודנט": person = new Student();
                    break;*/

            }
            return person;
        }
    }
}
