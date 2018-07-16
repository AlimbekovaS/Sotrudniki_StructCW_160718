using Sotrudniki_struct.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotrudniki_struct.Interface
{
    public interface IEmplyee
    {
         string Name { get; set; }
         int Age { get; set; }
         DateTime DateOfStart { get; set; }
         int Salary { get; set; }
         prof prof { get; set; }
    }
}
