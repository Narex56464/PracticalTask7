using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task4
    {
        private double _a;
        private double _b;
        private double _c;

        public Task4(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public bool Exp()
        {
            return (((_a + _b) == 90) && _c == 90) ||
                   (((_a + _c) == 90) && _b == 90) ||
                   (((_b + _c) == 90) && _a == 90);
        }
    }
}
