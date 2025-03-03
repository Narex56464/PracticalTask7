using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task14
    {
        private double _a;
        private double _b;

        public Task14(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public string More()
        {
            if ((Math.Pow(_a, 2) - Math.Pow(_b, 2)) > Math.Abs(Math.Pow(_a - _b, 2))) return "Разность квадратов больше";
            else if ((Math.Pow(_a, 2) - Math.Pow(_b, 2)) < Math.Abs(Math.Pow(_a - _b, 2))) return "Модуль квадрата разности больше";
            else return "Оба одинаковы";
        }
    }
}
