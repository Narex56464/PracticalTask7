using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task19
    {
        private double _a;
        private double _b;
        private double _c;

        public Task19(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public bool Exp()
        {
            return (Math.Pow(_c, 2) == Math.Pow(_a, 2) + Math.Pow(_b, 2)) ||
                   (Math.Pow(_a, 2) == Math.Pow(_b, 2) + Math.Pow(_c, 2)) ||
                   (Math.Pow(_b, 2) == Math.Pow(_a, 2) + Math.Pow(_c, 2));
        }
    }
}
