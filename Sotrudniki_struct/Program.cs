using Sotrudniki_struct.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotrudniki_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceEmployee Employee = new ServiceEmployee();
            Employee.CreateEmployers();

            foreach (Employee item in Employee.employers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");

            foreach (Employee item in Employee.FindManager(prof.Klerk))
            {
                Console.WriteLine(item);
            }
        }
    }
}
