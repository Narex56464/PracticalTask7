using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task22
    {
        private double _v1;
        private double _m1;
        private double _v2;
        private double _m2;

        public Task22(double v1, double m1, double v2, double m2)
        {
            _v1 = v1;
            _m1 = m1;
            _v2 = v2;
            _m2 = m2;
        }

        public bool More()
        {
            return (_v1 / _m1) > (_v2 / _m2);
        }
    }
}
