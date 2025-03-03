using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task18
    {
        private double _a;
        private double _b;
        private double _c;

        public Task18(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public bool Exp()
        {
            return (_a == _b) ||
                   (_a == _c) ||
                   (_b == _c);
        }
    }
}
