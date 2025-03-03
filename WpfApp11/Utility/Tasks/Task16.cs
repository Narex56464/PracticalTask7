using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task16
    {
        private double _x;
        private double _y;
        private double _r;
        private double _R;

        public Task16(double x, double y, double r, double R)
        {
            _x = x;
            _y = y;
            _R = r;
            _R = R;
        }

        public bool Exp()
        {
            double distance = Math.Sqrt(_x * _x + _y * _y);
            return distance < _R && distance > _r;
        }
    }
}
