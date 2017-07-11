using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;

namespace TheProject
{
    //class variable
    public class Worker : Person
    {
        private string gender;
        private string address;
        private string age;
        private string type;
        public int count = 3;
 

        public Worker()
            :base()
        {
            this.gender = " ";
            this.address = " ";
            this.age = " ";
            
        }

        public Worker(string id, string firstName, string lastName, string email, int permission, string userName, string password, string gen, string add, string ag)
            : base(id, firstName, lastName, email, permission, userName, password)
        {
            this.gender = gen;
            this.address = add;
            this.age = ag;
            
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public override void removeUser(string id)
        {
            try
            {
                Access.Delete("users", " WHERE [id]= '" + id + "'");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }

        public static Boolean Validate_user_password(string username, string password)
        {
            if (Access.Get("*", "users WHERE userName= '" + username + "' and password = '" + password + "' ").Rows.Count > 0)
                return true;
            else
                return false;
        }


        public override void fillPerson(params string[] parameters)
        {
            DataTable data;
            if (parameters.Length == 1)
            {
                data = Access.Get("*", "users WHERE ID= " + int.Parse(parameters[0]) + "");
            }
            else if (parameters.Length == 2)
            {
                data = Access.Get("*", "users WHERE userName= '" + parameters[0] + "' and password = '" + parameters[1] + "' ");
            }
            else data = null;
            if (data.Rows.Count > 0)
            {
                
                this.Id = data.Rows[0][0].ToString();
                this.FirstName = data.Rows[0][1].ToString();
                this.LastName = data.Rows[0][2].ToString();
                this.Email = data.Rows[0][3].ToString();
                this.Type = data.Rows[0][4].ToString();
                this.UserName = data.Rows[0][5].ToString();
                this.Password = data.Rows[0][6].ToString();
                this.Gender = data.Rows[0][7].ToString();
                this.Address = data.Rows[0][8].ToString();
                this.Age = data.Rows[0][9].ToString();
                this.Permission = int.Parse(data.Rows[0][10].ToString());

            }
        }

        public override void addUser(string id, string firstName, string lastName, string email, int permission, string userName, string password,string gen,string age,string add)
        {
            try
            {                              
                Access.Insert("users", "" + id + ",'" + firstName + "','" + lastName + "','" + email + "'," + permission + ",'" + userName + "','" + password + "','" + gender + "','"+ age + "','" + address + "'");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public override void timeTable(string key, string id, string date, string shift, string name)
        {
            
            try
            {
                Access.Insert("shifts", "" + key + ",'" + id + "','" + date + "','" + shift + "','" + name + "'");
               // Access.Update("TimeTable", "[id]= '" + ID + "', [firstName]= '" + firstName + "', [Day]= '" + day + "', [Shift]= '" + shift + "', [Date]= '" + date + "' WHERE [id]= '" + ID + "'");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public override void timeTable(string ID, string firstName, string day,string shift,string date)
        //{
        //    try
        //    {
        //        //Access.Update("members", "[user]= '" + user + "', [pass]= '" + pass + "', [firstName]= '" + firstName + "', [LastName]= '" + lastName + "', [email]= '" + email + "', [premission]= " + permission + ", [userName]= '" + userName + "', [age]= '" + age + "', [weight]= '" + weight + "', [gender]= '" + gender + "', [height]= '" + height + "', [bodyfat]= '" + bodyfat + "', [classes]= '" + classes + "', [workout]= '" + workout + "',[cash]= '" + cash + "', [medical]= '" + med + "' WHERE [user]= '" + id + "'");            
        //        Access.Update("TimeTable", "[id]= '" + ID + "', [firstName]= '" + firstName + "', [Day]= '" + day + "', [Shift]= '" + shift + "', [Date]= '" + date + "' WHERE [id]= '" + ID + "'");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
    

        public static Boolean Exist(string id)
        {
            if (id == "")
                return false;
            if (Access.Get("*", "users WHERE id= '" + id + "'").Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static Boolean userNameExist(String userName)
        {
            if (Access.Get("*", "users WHERE userName= '" + userName + "'").Rows.Count > 0)
                return true;
            else
            {
                Console.WriteLine("This userName already exist");
                return false;
            }
        }

        public static DataTable getList()
        {
            DataTable dt = new DataTable();
            dt = Access.Get("*", "users");
            return dt;
        }


        public override void addMember(string user, string pass, string firstName, string lastName, string email, int permission, string userName, string age, string weight, string gender, string height, string bodyfat, string classes, string workout, string med)
        {
            try
            {
                SendEmail(user, pass, firstName, lastName, email, permission, userName, gender, weight, height, bodyfat, classes, workout, med);
            }
            catch {
                MessageBox.Show("oops!  if you would like to get email from the gym plz edit your details with a valid email address");
            }
            Member.AddMember(user,pass, firstName, lastName, email,permission, userName, age,weight, gender,  height, bodyfat, classes, workout, med);
        }

        public override void editMember(string id,string use, string pa, string firstNam, string lastNam, string emai, int permissi, string userNam, string ge, string weiht, string geder, string heght, string bdyfat, string clases, string wokout, string med)
        {
            try
            {
                SendEmail( id, pa,firstNam,lastNam,emai,permissi, userNam,geder,weiht,heght,bdyfat,clases,wokout,med);
            }
            catch
            {
                MessageBox.Show("oops!  if you would like to get email from the gym plz edit your details with a valid email address");
            }
            Member.EditMember(id,use, pa,firstNam, lastNam, emai, permissi, userNam, ge, weiht, geder, heght, bdyfat,clases,wokout,med);
        }

        public override void remove(string id)
        {
            Member.Remove(id);
        }
        public void SendEmail(string id,  string pa, string firstNam, string lastNam, string address, int permissi, string userNam, string geder,  string weiht, string heght, string bdyfat, string clases, string wokout, string med)
        {
            string medical;
            string permition;
            if(med.Equals("yes"))
                medical = "have medical permit";
            else
                medical = "don't have medical permit Plz Update it as soon as possible ";

            if (permissi.Equals("3"))
                permition = "Platinum";
            else if (permissi.Equals("2"))
                permition = "Gold";
            else
                permition = "Silver";


            MailMessage MailMesaji = new MailMessage();

            MailMesaji.Subject = "A-team-Gym-3";

            MailMesaji.Body = "Hello "+firstNam+" "+lastNam+" Welcome to AteamGym3.     \nWe're glad you've joined us as a "+permition+" member.\nyour registration info is:  \nusername - "+userNam +"    \npassword -  "+pa+"     \nKeep this info backed up and safe.\nYou "+medical+" .\nthe classes you've choose are: \n"+clases+"  \nyour current workout is : "+wokout+". \nWe Hope You Will Enjoy Our Revolution in Momentum. \nAvailable Additional Services for you:\nGym Shop\nPersonal Trainer\n     Plz DO NOT Reply! :) ";

            MailMesaji.BodyEncoding = Encoding.GetEncoding("Windows-1255");

            MailMesaji.From = new MailAddress("Ateamgym3@gmail.com");

            MailMesaji.To.Add(new MailAddress(address));

            System.Net.Mail.SmtpClient Smtp = new SmtpClient();

            Smtp.Host = "smtp.gmail.com";

            Smtp.EnableSsl = true;

            Smtp.Credentials = new System.Net.NetworkCredential("Ateamgym3", "mypassword3");

            Smtp.Send(MailMesaji);

        }


    }
}
