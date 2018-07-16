using Sotrudniki_struct.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotrudniki_struct.Model
{
    public enum prof
    {
        Klerk, Manager, Leader, Boss
    }
    public struct Employee:IEmplyee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfStart { get; set; }
        public int Salary { get; set; }
        public prof prof {get; set;}
        public Employee(string Name, int Age, DateTime DateOfStart, int Salary, prof prof)
        {
            this.Name =Name;
            this.Age = Age;
            this.DateOfStart = DateOfStart;
            this.Salary=Salary ;
            this.prof = prof;

        }

        public override string ToString()
        {
            string str;
            str = string.Format("{0} ({1}) - {2} ({3}) \t{4} KZT", Name, Age, prof, DateOfStart, Salary);
            return str;
           
        }
    }
}
