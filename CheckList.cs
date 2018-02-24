using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    [Serializable]
    public class CheckList
    {
        public DateTime CreateDate { get; set; }
        public Automobile Car { get; set; }
        public string IssueDescription { get; set; }
        public string Advices { get; set; }
        public User user { get; set; }

        //public List<User> Users { set; get; }
        public static User GetRandMechanix(List<User> u)
        {
            int x = 0;
            foreach (User item in u)
            {
                if (item.Rights == AccessLevel.mechanic)
                    x++;
            }
            User[] uarr = new User[x];
            x = 0;
            foreach (User item in u)
            {
                if (item.Rights == AccessLevel.mechanic)
                {
                    uarr[x] = item;
                    x++;
                }
            }
            Random rn = new Random();
            return uarr[rn.Next(0, x)];
        }
        Random rn = new Random();
        
        public List<Automobile> Automobiles { set; get; }
        public CheckList() { }
        public CheckList(DateTime dt, Automobile c, string desc, string adv)
        {
            CreateDate = dt; Car = new Automobile(c);  IssueDescription = desc; Advices = adv; 
        }

        public void ShowCheckList()
        {
            Console.WriteLine("Сreation date: {0}, Car: {1} {2}, Issue: {3}, Advices: {4}, User: {5} {6}",
                CreateDate.ToString("dd.MM.yyyy"), Car.Model, Car.GarageNumber, IssueDescription, Advices, user.LogIn, user.Rights);
        }

        public void CreateCheckList(Automobile a)
        {
            if (a.Status == false && a.CL == null)
            {
                List<Component> lp = new List<Component>();
                foreach (Part item in a.Parts)
                {
                    if (item.GetStatus() == false)
                        lp.Add(item.Name);
                }
                string d = null, adv = null;
                d = "Need to repare" + string.Join(", ", lp);
                adv = string.Join(", ", lp) + " can be changed or repared";
                a.CL = new CheckList(DateTime.Now, a, d, adv);
            }

        }

        public void ShowAll(List<CheckList> CheckLists)
        {
            foreach (CheckList item in CheckLists)
            {
                item.ShowCheckList();
            }
        }
    }
}
/*
1.	Отобразить весь список остановов;
2.	Должна быть возможность создать останов для доступной машины. Если у машины стоит запрет на создание, 
то данная машина не должна отображаться в списке на создание останова;
*/
