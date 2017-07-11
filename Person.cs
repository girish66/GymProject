using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProject
{
    public abstract class Person
    {
        //class variables
        private string id;
        private string firstName;
        private string lastName;
        private string email;
        private string userName;
        private string password;
        private int permission;
        //default constructor
        public Person()
        {
            this.id = "";
            this.firstName = "";
            this.lastName = "";
            this.email = "";
            this.userName = "";
            this.password = "";

        }
        //constructor
        public Person(string id, string firstName, string lastName, string email, int permission, string userName, string password)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.permission = permission;
            this.userName = userName;
            this.password = password;
        }

        //get/set func for id
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        //get/set func for name
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        //get/set func for last name
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        //get/set func for address
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        //get/set func for userName
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        //get/set func for password
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        //get/set func for permission
        public int Permission
        {
            get { return permission; }
            set { permission = value; }
        }

        public abstract void addMember(string use, string pa, string first, string last, string em, int permiss, string userNa, string aeg, string weig, string gend, string heig, string bodyf, string clas, string work,string medical);
        public abstract void fillPerson(params string[] parameters);
        public abstract void addUser(string id, string first, string las, string em, int per, string us, string p,string gen,string age,string add);
        public abstract void editMember(string id,string use, string pa, string firstNam, string lastNam, string emai, int permissi, string userNam, string ge, string weiht, string geder, string heght, string bdyfat, string clases, string wokout,string medical);
        public abstract void remove(string id);
        public abstract void removeUser(string id);
        public abstract void timeTable(string ID, string firstName, string day, string shift, string date);


    }//class Person
    
}//the project




