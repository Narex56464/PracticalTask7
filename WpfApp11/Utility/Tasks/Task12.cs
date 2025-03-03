using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task12
    {
        private double _x;
        private double _y;

        public Task12(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public bool Exp()
        {
            return (_x < 0) && (_y > 0);
        }
    }
}
