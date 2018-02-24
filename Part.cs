using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum Component { engine = 0, transmission = 1, brakes = 2, body = 3, suspension = 4, chassis = 5 }
    public class Part
    {
        public Component Name { get; set; }
        public int Code { get; set; }
        private bool Status { get; set; } = true;

        public static Component GetComponent(int code)
        {
            return (Component)Enum.ToObject(typeof(Component), code);
                
        }
        public Part() { }
        public Part(Component name, int code, bool stat = true)
        {
            Name = name ; Code = code; Status = stat;
        }
        public Part(int code, bool stat = true)
        {
            Name = (Component)code; Code = code; Status = stat;
        }


        public void ChangeStatus(bool s)
        {
            Status = s;
        }
        public bool GetStatus() { return Status; }
    }
}
/*
1.	Отобразить все компоненты на проекте
2.	Должна быть возможность создать компонент и прикрепить его к машине
*/
