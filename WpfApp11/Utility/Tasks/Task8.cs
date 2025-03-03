using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task8
    {
        private double _a1;
        private double _b1;
        private double _c1;
        private double _a2;
        private double _b2;
        private double _c2;

        public Task8(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            _a1 = a1;
            _b1 = b1;
            _c1 = c1;
            _a2 = a2;
            _b2 = b2;
            _c2 = c2;
        }

        public bool Largest()
        {
            return ((_a1 + _b1 + _c1) / 2) > ((_a2 + _b2 + _c2) / 2);
        }
    }
}
