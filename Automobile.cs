using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public enum AutoType { light, heavy_cargo, passenger, cargo }
    public class Automobile
    {
        public string Model { get; set; }
        public int ProdYear { get; set; }
        public string Name { get; set; }
        public AutoType Type { get; set; }
        public int GarageNumber { get; set; }
        public bool Status { get; set; } = true;
        public Subject Project { get; set; }
        public List<Part> Parts { get; set; }
        public CheckList CL { set; get; } = null;
        

        public Automobile() { }
        public Automobile(string model, int py, string name, AutoType at, int gn, List<Part> parts, bool status = true)
        {
            Model = model; ProdYear = py; Name = name; Type = at; GarageNumber = gn;
            for (int i = 0; i < 6; i++)
            {
                parts.Add(new Part(i, true));
            }
            Status = status;
        }
        public Automobile(Automobile c)
        {
            Model = c.Model; ProdYear = c.ProdYear; Name = c.Name; Type = c.Type; GarageNumber = c.GarageNumber; Status = c.Status; Project = c.Project;
            foreach (Part item in c.Parts)
            {
                Parts.Add(item);
            }
        }

        public string GetStatus()
        {
            if (Status)
                return "Atomobile is Active";
            else return "Automobile is NOT Active";
        }
        public void ShowAutos(List<Automobile> a, int gn = 0, string model = null)
        {
            if (gn == 0 && model == null)
                foreach (Automobile item in a)
                {
                    item.ShowAuto();
                }
            else if (gn != 0 && model == null)
                foreach (Automobile item in a)
                {
                    if(gn == item.GarageNumber)
                        item.ShowAuto();
                }
            else if (gn == 0 && model != null)
                foreach (Automobile item in a)
                {
                    if (model == item.Model)
                        item.ShowAuto();
                }
            else if (gn != 0 && model != null)
                foreach (Automobile item in a)
                {
                    if (model == item.Model && gn == item.GarageNumber)
                        item.ShowAuto();
                }
        }
        public void ShowAutos(List<Automobile> a, Subject p)
        {
            p.ShowAutos(a);
        }
        //public Automobile ShowAutos(List<Automobile> a, int gn = 0, string model = null)
        //{

        //    foreach (Automobile item in a)
        //    {
        //        Console.WriteLine("Model: {0}, Production Year: {1}, Name: {2}, Type: {3}, GarageNumber: {4}, Status: {5}, Project Name: {6}",
        //            Model, ProdYear, Name, Type, GarageNumber, item.GetStatus(), Project.Name);
        //    }
        //}

        public void ShowAuto()
        {
            if (Status == false)
                Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Model: {0}, Production Year: {1}, Name: {2}, Type: {3}, GarageNumber: {4}, " +
                "Status: {5}, Project Name: {6}", Model, ProdYear, Name, Type, GarageNumber, GetStatus(), Project.Name);
            Console.ResetColor();
        }

        public void SetStatus()
        {
            foreach (Part item in Parts)
            {
                if (item.GetStatus() == false)
                    Status = false;
                Console.WriteLine("Automobile is NOT Active");
            }
            Console.WriteLine("Atomobile is Active");
        }
        public void SetStatus(bool x)
        {
            Status = x;
            if (Status)
                Console.WriteLine("Atomobile is Active");
            else Console.WriteLine("Automobile is NOT Active");
        }

        public void ShowParts(List<Part> parts)
        {
            foreach (Part item in parts)
            {
                Console.WriteLine("Name: {0}, Status: {1}", item.Name, item.GetStatus());
            }
        }
    }
}
/*
1.	Отображение всего парка машина по проектам; >
2.	Поиск машины по его гаражному номеру, модели;>
3.	Из результатов поиска должна быть возможность, создать останов для машины;
4.	Для любой машины должна быть возможность прикрепить компонент, при условии, 
что у данной машину уже не стоит данный компонент, в случае если он стоит выдать соответствующее сообщение;
5.	Для машины должна быть возможность установить статус Активна/Неактивная;>
Требования:
1.	Если машина стоит не активная, она должны отображаться красным цветом, в противном случае зеленым;>
2.	Если машина не активная для нее не должна быть возможность создания останова;
*/
