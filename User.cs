using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    [Serializable]
    public enum AccessLevel { admin = 0, driver = 1, mechanic = 2, none}
    public class User
    {
        public string LogIn { get; set; }
        private string Password { get; set; }
        public AccessLevel Rights { get; set; }
        public Subject project { get; set; }
        public User() { }
        public User(string login, string password, AccessLevel al, Subject p)
        {
            LogIn = login; Password = password; Rights = al; project = p;
        }
        public User(User u)
        {
            LogIn = u.LogIn; Password = u.Password; Rights = u.Rights; project = u.project;
        }

        private void ShowUserInfo()
        {
            Console.WriteLine("Access level: {0}, LogIn: {1}, Project: {2}", Rights, LogIn, project);
        }
        public void ShowUsersByProject(List<User> u, Subject p)
        {
            foreach (User item in u)
            {
                if (p.Name == item.project.Name)
                    item.ShowUserInfo();
            }
        }
        private AccessLevel CheckAccessLevel(string login, string password)
        {
            if (login == LogIn && password == Password)
                return Rights;
            return AccessLevel.none;
        }
        
        
        //public static void EnterDB(User u)
        //{
        //    string login 
        //        if(u.CheckAccessLevel()
        //    {

        //    }
        //}
    }
}



