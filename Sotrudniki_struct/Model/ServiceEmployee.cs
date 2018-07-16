using GeneratorName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotrudniki_struct.Model
{
    public struct ServiceEmployee
    {
        public List<Employee> employers;

        public void CreateEmployers()
        {
            Random rnd = new Random();
            employers = new List<Employee>();
            Console.WriteLine("Введите кол-во сотрудников ");
            int x = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Generator gen = new Generator();
                Employee employee = new Employee();
                employee.Age =rnd.Next(23,60);
                employee.Name = gen.GenerateDefault((Gender)rnd.Next(2))
                .Replace("<center><b><font size=7>", "")
                .Replace("</font></b></center>", "")
                .Replace("\n", "")
                .Substring(1);

                employee.DateOfStart = DateTime.Now.AddMonths(rnd.Next(1, 50));
                employee.Salary = rnd.Next(1000, 100000);
                employee.prof = (prof)rnd.Next(3);
                employers.Add(employee);

            }
        }
        public List <Employee> FindManager(prof p)
        {
           var g= employers.Where(w => w.prof == p).Sum(s=>s.Salary);//коллекция
           int c = employers.Where(w => w.prof == p).Count();
           double avg = g / c;
            List<Employee> Managers=
            employers.Where(w => w.prof == prof.Manager && w.Salary > avg).ToList();
            return Managers.OrderBy(o=>o.Name).ToList();
        }

    }
}
