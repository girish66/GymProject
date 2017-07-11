using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TheProject
{
    public class Member: Person
    {
        //class variables

        private string height;
        private string weight;
        private string bodyfat;
        private string classes;
        private string workout;
        private string age;
        private string gender;
        private string med;
        private string cash;

        /* default constractor */
        public Member()
            :base()
        {
            this.age = "";
            this.height = "";
            this.weight = "";
            this.bodyfat = "";
            this.classes = " ";
            this.workout = " ";
            this.gender = " ";
            this.cash = " ";
            this.med = " ";
        }

        /* constractor */
        public Member(string id, string firstName, string lastName, string email, int permission, string userName, string password, string h, string w, string bdf, string cls, string work, string ag ,string gender,string med,string cash)
            : base(id, firstName, lastName, email, permission, userName, password)
        {
            this.age = ag;
            this.height = h;
            this.weight = w;
            this.bodyfat = bdf;
            this.classes = cls;
            this.workout = work;
            this.gender = gender;
            this.cash = cash;
            this.med = med;
        }

        /*get/set func for height */
        public string Height
        {
            get { return height; }
            set { height = value; }
        }

        /*get/set func for weight */
        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        /*get/set func for bodyfat */
        public string Bodyfat
        {
            get { return bodyfat; }
            set { bodyfat = value; }
        }

        /*get/set func for classes */
        public string Classes
        {
            get { return classes; }
            set { classes = value; }
        }

        /*get/set func for workout */
        public string Workout
        {
            get { return workout; }
            set { workout = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Medical
        {
            get { return med; }
            set { med = value; }
        }


        public string Cash
        {
            get { return cash; }
            set { cash = value; }
        }

        public override void fillPerson(params string[] parameters)
        {
            DataTable data;
            if (parameters.Length == 1)
            {
                data = Access.Get("*", "members WHERE user= '" + parameters[0] + "'");
            }
            else if (parameters.Length == 2)
            {
                data = Access.Get("*", "members WHERE userName= '" + parameters[0] + "' and password = '" + parameters[1] + "' ");
            }
            else data = null;
            if (data.Rows.Count > 0)
            {
                this.Id = data.Rows[0][0].ToString();
                this.FirstName = data.Rows[0][2].ToString();
                this.LastName = data.Rows[0][3].ToString();
                this.Email = data.Rows[0][4].ToString();
                this.Permission = int.Parse(data.Rows[0][5].ToString());
                this.UserName = data.Rows[0][6].ToString();
                this.Password = data.Rows[0][1].ToString();
                this.Height = data.Rows[0][10].ToString();
                this.Weight = data.Rows[0][8].ToString();
                this.Bodyfat = data.Rows[0][11].ToString();
                this.Classes = data.Rows[0][12].ToString();
                this.Workout = data.Rows[0][13].ToString();
                this.age = data.Rows[0][7].ToString();
                this.gender = data.Rows[0][9].ToString();
                this.med = data.Rows[0][15].ToString();
                this.cash = data.Rows[0][14].ToString();

            }
        }

        public static Boolean Validate_user_password(string username, string password)
        {
            if (Access.Get("*", "members WHERE userName= '" + username + "' and password = '" + password + "' ").Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static Boolean Exist(string id)
        {
            if (Access.Get("*", "members WHERE user= '" + id + "'").Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static void AddMember(string user, string pass, string firstName, string lastName, string email, int permission, string userName, string age, string weight, string gender, string height, string bodyfat, string classes, string workout, string med)
        {
            string cash = "0";
            try
            {
                Access.Insert("members", "'" + user + "','" + pass + "','" + firstName + "','" + lastName + "','" + email + "','" + permission + "','" + userName + "','" + age + "','" + weight + "','" + gender + "','" + height + "','" + bodyfat + "','" + classes + "','" + workout + "','" + cash + "','" + med + "'");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void EditMember(string id,string user, string pass, string firstName, string lastName, string email, int permission, string userName, string age, string weight, string gender, string height, string bodyfat, string classes, string workout,string med)
        {
            string cash = "0";
            try
            {
                Access.Update("members", "[user]= '" + user + "', [pass]= '" + pass + "', [firstName]= '" + firstName + "', [LastName]= '" + lastName + "', [email]= '" + email + "', [premission]= " + permission + ", [userName]= '" + userName + "', [age]= '" + age + "', [weight]= '" + weight + "', [gender]= '" + gender + "', [height]= '" + height + "', [bodyfat]= '" + bodyfat + "', [classes]= '" + classes + "', [workout]= '" + workout + "',[cash]= '" + cash + "', [medical]= '" + med + "' WHERE [user]= '" + id + "'");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static void Remove(string id)
        {
            try 
            {
                Access.Delete("members", " WHERE [user]= '" + id + "'");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
                
         
        }

        public static DataTable getList()
        {
            DataTable dt = new DataTable();
            dt = Access.Get("*", "members");
            return dt;
        }

        public override void addMember(string use, string pa, string first, string last, string em, int permiss, string userNa, string aeg, string weig, string gend, string heig, string bodyf, string clas, string work,string med) { }
        public override void addUser(string id, string first, string las, string em, int per, string us, string p,string gen,string age,string add) { }
        public override void editMember(string id, string use, string pa, string firstNam, string lastNam, string emai, int permissi, string userNam, string ge, string weiht, string geder, string heght, string bdyfat, string clases, string wokout, string med) { }
        public override void remove(string id) { }
        public override void removeUser(string id) { }
        public override void timeTable(string ID, string firstName, string day, string shift, string date) { }

    }
    

   
}
