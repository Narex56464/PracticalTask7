using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task25
    {
        private double _u1;
        private double _r1;
        private double _u2;
        private double _r2;

        public Task25(double u1, double r1, double u2, double r2)
        {
            _u1 = u1;
            _r1 = r1;
            _u2 = u2;
            _r2 = r2;
        }

        public bool More()
        {
            return (_u1 / _r1) > (_u2 / _r2);
        }
    }
}
