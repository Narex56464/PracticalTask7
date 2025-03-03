using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task7
    {
        private double _x;
        private double _y;
        private double R;

        public Task7(double x, double y, double r)
        {
            _x = x;
            _y = y;
            R = r;
        }

        public bool Radius()
        {
            return Math.Pow(_x, 2) + Math.Pow(_y, 2) <= Math.Pow(R, 2);
        }
    }
}
