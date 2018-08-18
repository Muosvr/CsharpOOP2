using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    //BusinessEmployee Class inheriting from Employee Class
    class BusinessEmployee : Employee
    {
        public BusinessEmployee(String name) : base(name, 5000)
        {
        }

        public double bonusBudget = 1000;
        public override string employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }
    }
}
