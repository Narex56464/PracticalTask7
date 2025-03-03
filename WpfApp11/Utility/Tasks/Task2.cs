using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task2
    {
        private double Salary;
        private double Experience;

        public Task2(double salary, double experience)
        {
            Salary = salary;
            Experience = experience;
        }

        public double ExtraCharge()
        {
            if(Experience >= 2 && Experience <= 5) return Salary * 0.02 * Experience;
            else if(Experience >= 5 &&  Experience <= 10) return Salary * 0.05 * Experience;
            else return Salary;
        }
    }
}
