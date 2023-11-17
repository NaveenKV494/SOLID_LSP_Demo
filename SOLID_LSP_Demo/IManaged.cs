using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_Demo
{
    public interface IManaged : IEmployee
    {
        Employee Manager { get; set; }
        void AssignManager(Employee manager);
    }
}
