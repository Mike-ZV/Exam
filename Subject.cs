using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Subject
    {
        public string Name { get; set; }
        public List<Automobile> Automobiles { get; set; }
        public List<User> Users { get; set; }

        public Subject() { }
        public Subject(string name) { Name = name; Automobiles = new List<Automobile>();
            Users = new List<User>(); }
        
        public void AddUser(User u)
        {
            Users.Add(u);
        }
        public void AddAuto(Automobile a)
        {
            Automobiles.Add(a);
        }
        public static void ShowSubjects(List<Subject> s)
        {
            foreach (Subject item in s)
            {
                item.ShowSubject();
            }
        }
        private void ShowSubject()
        {
            Console.WriteLine("Name: {0}", Name);
        }


        

        public void ShowAutos(List<Automobile> a)
        {
            foreach (Automobile item in a)
            {
                if (item.Project.Name == Name)
                    item.ShowAuto();
            }
        }
        

    }
}
/*
1.	Отобразить весь список проектов
2.	Должна быть возможность создать проекта
*/
